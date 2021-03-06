﻿/*
 * Created by SharpDevelop.
 * Author: Mike Galiati 
 * Date: 3/2/2012
 * Time: 4:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 * 
 * - Added a check to make sure the cal columns have the same number of items. 
 * - Set the tab order.
 * - Changed script file output to Unix line endings (no carriage return just linefeed).
 * - Trimmed leading and trailing whitespace from all of the parts and cal data 
 *   before appending to command strings.
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;              // Process
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using MyHelp;                          // Browser

namespace CaldsScriptGenerator
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        string ProcessScriptFile = "CalGenProcessScript.txt";
        string EngScriptFile     = "CalGenEngScript.txt";
        string PartsListFile     = "CalGenPartsList.txt";
        int numNameLines = 0;
        int numOffsetLines = 0;
        int numValLines = 0;
            
        
        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
        }
       
        /// <summary>
        /// This is where it all happens!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GoButtonClick(object sender, EventArgs e)
        {
        	List<string> partsSrc = new List<string>(); // Declare new source parts List.
        	List<string> partsDst = new List<string>(); // Declare new destination parts List.
                
            // Verify that the output path exists.
            if (!Directory.Exists(outputFolderTextBox.Text)) 
            {
                UpdateStatusLabel("Output folder Does Not Exist! Please enter a valid output folder.");
                return;
            }
        	
            // If the source parts list is needed, verify that it exists.
            if (IsSrcPartsListRequired() && (partNumSrcTextBox.Text.Length == 0)) 
            {
                UpdateStatusLabel("Enter at least 1 source part, please.");
                return;
            }
            else 
            {
            	// Read the lines from the source parts textbox.
            	foreach (string part in partNumSrcTextBox.Lines) 
            	{
            	    // If the part isn't blank add it to the list.
            	    if (part != "") 
            	    {
            	        partsSrc.Add(part); // add the part to our List
                    }
            	}
            }
        	
            // If the destination parts list is needed, verify that it exists.
            if (IsDestPartsListRequired() && (partNumDestTextBox.Text.Length == 0)) 
            {
                UpdateStatusLabel("Enter at least 1 destination part, please.");
                return;
            }
            else 
            {
            	// Read the lines from the destination parts textbox.
            	foreach (string part in partNumDestTextBox.Lines) 
            	{
            	    // If the part isn't blank add it to the list.
            	    if (part != "") 
            	    {
            	        partsDst.Add(part); // add the part to our List
                    }
            	}
            }
            
            // Display a warning message if Checkin Copy or Update Status if selected.
            ConfirmPpvOrValRelease();
            
            // Create a writer and open the file (using @ because it ignores escape sequences (such as "\")).
            TextWriter tw = new StreamWriter(outputFolderTextBox.Text + "\\" + ProcessScriptFile);
        	
            // Set new line character to Unix style because Filezilla won't convert the new line using SFTP.
            if (unixFormatCheckBox.Checked) 
            {
                tw.NewLine = "\n";
            }
        	
            waDefault(tw);
            mkHandle(tw);
            activatePart(partsSrc, tw);
            mkcopy(partsSrc, tw);
            
            if (transferCheckBox.Checked || uploadCheckBox.Checked) 
            {
                mkcopy(partsDst, tw);
            }
            
            chcalcopy(partsSrc, tw);
            copyBenchValues(partsSrc, tw);
            transfer(partsSrc, partsDst, tw);
            bldImage(partsSrc, tw);
            upload(partsSrc, partsDst, tw);
            
            // Batch Cal Edit, Checkin Copy, Update Status, Create Class 2, Calplot. 
            // If the Upload or Transfer checkboxes are checked, 
            // Then process the destination parts,
            // Else process the source parts.
            if (uploadCheckBox.Checked || transferCheckBox.Checked)
            {
                batchCaledit(partsDst, tw);
                checkinCopy(partsDst, tw);
                updateStatus(partsDst, tw);
                createClass2(partsDst, tw);
                calplot(partsDst, tw);
            }
            else
            {
                batchCaledit(partsSrc, tw);
                checkinCopy(partsSrc, tw);
                updateStatus(partsSrc, tw);
                createClass2(partsSrc, tw);
                calplot(partsSrc, tw);
            }
            
            // close the Process Script file.
            tw.Close();
            
        	// Update the status text box.
            UpdateStatusLabel("The Process Script file '" + ProcessScriptFile + "' was created.");
        }

        void ConfirmPpvOrValRelease()
        {
            string caption = "Warning";
   			MessageBoxButtons buttons = MessageBoxButtons.OK;

   			// Is the Check In Copy radio button is check?
   			if (checkinCopyRadioButton.Checked)
            {
                // Is the PPV Release radio button checked?
   			    if (ppvRelRadioButton.Checked)
                {
        			string message = "You are about to Check In part(s) with PPV Release status.";
        			MessageBox.Show(message, caption, buttons);
                }
                // Is the Validation Release radio button checked?
   			    else if (valRelRadioButton.Checked)
                {
        			string message = "You are about to Check In part(s) with Validation Release status.";
        			MessageBox.Show(message, caption, buttons);
                }
            }
            // Is the Update Status radio button checked?
            else if (updateStatusRadioButton.Checked && (revokeCheckBox.Checked == false))
            {
                if (revokeCheckBox.Checked)
                {
                    // Is the PPV Release radio button checked?
       			    if (ppvRelRadioButton.Checked)
                    {
            			string message = "You are about to Revoke the PPV Release status.";
            			MessageBox.Show(message, caption, buttons);
                    }
                    // Is the Validation Release radio button checked?
       			    else if (valRelRadioButton.Checked)
                    {
            			string message = "You are about to Revoke Validation Release status.";
            			MessageBox.Show(message, caption, buttons);
                    }
                }
                else // Revoke not checked
                {
                    // Is the PPV Release radio button checked?
       			    if (ppvRelRadioButton.Checked)
                    {
            			string message = "You are about to Update Status to PPV Release.";
            			MessageBox.Show(message, caption, buttons);
                    }
                    // Is the Validation Release radio button checked?
       			    else if (valRelRadioButton.Checked)
                    {
            			string message = "You are about to Update Status to Validation Release.";
            			MessageBox.Show(message, caption, buttons);
                    }
                }
            }
        }


        /// <summary>
        /// This function checks if the source parts list is required.
        /// </summary>
        /// <returns></returns>
        bool IsSrcPartsListRequired()
        {
        	if (activateCheckBox.Checked        ||
                mkcopyCheckBox.Checked          ||
                chcalcopyCheckBox.Checked       ||
                copyBenchCheckBox.Checked       ||
                batchCaleditCheckBox.Checked    ||
                transferCheckBox.Checked        ||
                bldImageCheckBox.Checked        ||
                checkinCopyRadioButton.Checked  ||
                updateStatusRadioButton.Checked ||
                createClass2CheckBox.Checked    ||
                calplotCheckBox.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// This function checks if the destination parts list is required.
        /// </summary>
        /// <returns></returns>
        bool IsDestPartsListRequired()
        {
        	if (transferCheckBox.Checked || uploadCheckBox.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void waDefault(TextWriter tw)
        {
        	// Is the Work Area Default checkbox checked?
        	if (waDefaultCheckBox.Checked)
        	{
        	    tw.WriteLine("wadefault swpart=" + waDefSwPartTextBox.Text.Trim() + " libname=" + waDefLibTextBox.Text.Trim());
            }
        }
        
        void mkHandle(TextWriter tw)
        {
        	// Is the Work Area Default checkbox checked?
        	if (mkHandleCheckBox.Checked)
        	{
        	    tw.WriteLine("Mkhandle member=" + mkHandleSwPartTextBox.Text.Trim());
            }
        }
        
        void activatePart(List<string> parts, TextWriter tw)
        {
        	// Is the Activate Part checkbox checked?
        	if (activateCheckBox.Checked)
        	{
                string intended = (intendedCheckBox.Checked) ? "y" : "n";
            	foreach (string part in parts)
            	{
            	    tw.WriteLine("Activate_Part member=" + part.Trim() + " Intended_for_Vehicle_Assembly_Plant_use=" + intended);
            	}
            }
        }
        
        void mkcopy(List<string> parts, TextWriter tw)
        {
            if (mkcopyCheckBox.Checked)
            {
            	foreach (string part in parts)
            	{
                    // Set up a pattern to test for a cal that is an array (like "NAME(1/33 0)") 
                    string command = "Mkcopy member=" + part.Trim();
                    string pattern = @"(.+)\.([A-Za-z]{2})";
                
                    // Does the part include it's dls (12345678.AB)?
                    if (Regex.Match(command, pattern).Success)
                    {
                        command = Regex.Replace(command, pattern, "$1 revision=$2");
                    }
                    tw.WriteLine(command);
            	}
            }
        }
        
        void chcalcopy(List<string> parts, TextWriter tw)
        {
            if (chcalcopyCheckBox.Checked)
            {
            	foreach (string part in parts)
            	{
            	    tw.WriteLine("chcalcopy calcopy=" + part.Trim() + " swpart=" + chcalcopySwPartTextBox.Text.Trim() + " terse");
            	}
            }
        }
        
        void copyBenchValues(List<string> parts, TextWriter tw)
        {
            if (copyBenchCheckBox.Checked)
            {
            	foreach (string part in parts)
            	{
            	    tw.WriteLine("Copy_Bench_Values copy=" + part.Trim());
            	}
            }
        }
        
        void batchCaledit(List<string> parts, TextWriter tw)
        {
            if (batchCaleditCheckBox.Checked)
            {
                // Write the Batch Cal Edit command to the Process Script.
                tw.WriteLine("Batch_caledit file=" + PartsListFile + " script=" + EngScriptFile);

                // Create a writer and open the parts list file.
                TextWriter twPart = new StreamWriter(outputFolderTextBox.Text + "\\" + PartsListFile);
            	
                // Set new line character to Unix style because Filezilla won't convert the new line using SFTP.
                if (unixFormatCheckBox.Checked) 
                {
                    twPart.NewLine = "\n";
                }
        	
                // Write each part in the list to the parts list file.
            	foreach (string part in parts)
            	{
                    // The Regex.Replace is removing any extension.
            	    twPart.WriteLine(Regex.Replace(part.Trim(), @"(\w)\.[a-zA-Z]{2}", "$1"));
            	}

                // close the parts list file.
                twPart.Close();
                
            	// Write the cal name, index, and value to the eng script file.
                if (writeCalsToFile() == false) 
                {
                    UpdateStatusLabel("Eng script not written. Cal data not right.");
                    return;
                }
            }
        }
            
        bool writeCalsToFile() 
        {
            bool rv = false;
            
            // Verify that the number of items in each cal column match.
            if (DoCalTextBoxLengthsMatch())
            {
                // Create a writer and open the file (using @ because it ignores escape sequences (such as "\")).
                TextWriter tw = new StreamWriter(outputFolderTextBox.Text + "\\" + EngScriptFile);
    
                // Set new line character to Unix style because Filezilla won't convert the new line using SFTP.
                if (unixFormatCheckBox.Checked) 
                {
                    tw.NewLine = "\n";
                }
            	
                // Write the cals to an engineering script.
                for (int i = 0; i < numNameLines; i++) 
                {
            	    string name   = calNameTextBox.Lines[i].Trim();
            	    string offset = calOffsetTextBox.Lines[i].Trim();
            	    string val    = calValTextBox.Lines[i].Trim();
            	    
                    // If the part isn't blank add it to the list.
            	    if ((name != String.Empty) && (offset != String.Empty) && (val != String.Empty))
            	    {
            	        tw.WriteLine("cu\t" + name + "\t" + offset + "\t" + val);
            	        rv = true;
                    }
            	}
    
                tw.WriteLine("sync");
                tw.WriteLine("wq");
                
                // close the Process Script file.
                tw.Close();
    
            	// Update the status text box.
                UpdateStatusLabel("The Engineering Script file '" + EngScriptFile + "' was created.");
            }
            else
            {
                string len = "(" 
                    + numNameLines.ToString() + ", "
                    + numOffsetLines.ToString() + ", "
                    + numValLines.ToString() + ")."; 
                MessageBox.Show("There is something wrong with the cals. The number of items in each list do not match " + len);
            }
            
            return rv;
        }
        
        /// <summary>
        /// Verifies if the number of items in the cal name, cal offset and cal value match.
        /// </summary>
        /// <returns></returns>
        bool DoCalTextBoxLengthsMatch()
        {
            numNameLines = 0;
            numOffsetLines = 0;
            numValLines = 0;
            
            for (int i = 0; i < calNameTextBox.Lines.Length; i++)
            {
                if (!String.IsNullOrWhiteSpace(calNameTextBox.Lines[i]))
                {
                    numNameLines++;
                }    
            }
            
            for (int i = 0; i < calOffsetTextBox.Lines.Length; i++)
            {
                if (!String.IsNullOrWhiteSpace(calOffsetTextBox.Lines[i]))
                {
                    numOffsetLines++;
                }    
            }

            for (int i = 0; i < calValTextBox.Lines.Length; i++)
            {
                if (!String.IsNullOrWhiteSpace(calValTextBox.Lines[i]))
                {
                    numValLines++;
                }    
            }
            
            if ((numNameLines == numOffsetLines) && (numNameLines == numValLines))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        /// <summary>
        /// This function builds the transfer commands and copies them to the process script file.
        /// </summary>
        /// <param name="partsSrc"> The source parts list</param>
        /// <param name="partsDst"> The destination parts list</param>
        /// <param name="tw"> The process script output file to write the commands to</param>
        void transfer(List<string> partsSrc, List<string> partsDst, TextWriter tw)
        {
            if (transferCheckBox.Checked)
            {
                string[] pin  = partsSrc.ToArray();
                string[] pout = partsDst.ToArray();
                
            	// Make sure the parts lists are the same size.
                if (pin.Length == pout.Length)
            	{
                	for (int i = 0; i < pin.Length; i++)
                	{
                	    tw.WriteLine("transfer object=" + pin[i].Trim() + " copy=" + pout[i].Trim() + " terse");
                	}
            	}
                else
                {
                    // Display a message stating that the parts lists are different sizes.
                    MessageBox.Show("Transfer Failed: Number of parts in each list must match.");
                }
            }
        }
        
        void bldImage(List<string> parts, TextWriter tw)
        {
            if (bldImageCheckBox.Checked)
            {
            	foreach (string part in parts)
            	{
            	    tw.WriteLine("bldimage object=" + part.Trim());
            	}
            }
        }
        
        /// <summary>
        /// This function builds the upload command and copies it to the process script file.
        /// upload copy=2233445566 ptpfile=11223344.pta ptponly
        /// </summary>
        /// <param name="partsSrc"></param>
        /// <param name="partsDst"></param>
        /// <param name="tw"></param>
        void upload(List<string> partsSrc, List<string> partsDst, TextWriter tw)
        {
            if (uploadCheckBox.Checked)
            {
                string[] pin  = partsSrc.ToArray();
                string[] pout = partsDst.ToArray();
                
            	// Make sure the parts lists are the same size.
                if (pin.Length == pout.Length)
            	{
                	for (int i = 0; i < pin.Length; i++)
                	{
                	    tw.WriteLine("upload copy=" + pout[i].Trim() + " ptpfile=" + pin[i].Trim() + ".pta ptponly");
                	}
            	}
                else
                {
                    // Display a message stating that the parts lists are different sizes.
                    MessageBox.Show("Upload Failed: Number of parts in each list must match.");
                }
            }
        }
        
        void checkinCopy(List<string> parts, TextWriter tw)
        {
            if (checkinCopyRadioButton.Checked)
            {
                string rel = String.Empty;
                //string prod = String.Empty;
                
                // Remove any spaces from the log message and rev name strings.
                string logMsg  = logMessageTextBox.Text.Replace(" ", "");
                string revName = revNameTextBox.Text.Replace(" ", "");
                
                // Set the release string based on the release radio buttons.
                if (valRelRadioButton.Checked) 
                {
                    rel = " Validation_Release";
                }
                else if (ppvRelRadioButton.Checked) 
                {
                    rel = " PPV_Release";
                }
                else 
                {
                    rel = " Development_Release";
                }
            	
//                if (productionIntentCheckBox.Checked)
//                {
//                    prod = " Production_Intent";
//                }

                if (revNameTextBox.Text == "")
                {
                    MessageBox.Show("Check In Copy Error: Please enter a Rev Name.");
                }
                else
                {
                    foreach (string part in parts)
                	{
                        tw.WriteLine("Checkin_Copy copy=" + part.Trim() + " logmessage=" + logMsg +
                                      " revname=" + revName + rel);
                	}
                }
            }
        }
        
        void updateStatus(List<string> parts, TextWriter tw)
        {
            if (updateStatusRadioButton.Checked)
            {
                bool dlsMissing = false;
                string revoke = String.Empty;
                string rel = String.Empty;
//                string prod = String.Empty;
                
                // Set the Revoke flage if the checkbox is checked.
                if (revokeCheckBox.Checked)
                {
                    revoke = " revoke";
                }
                
                // Set the release string based on the release radio buttons.
                if (valRelRadioButton.Checked) 
                {
                    rel = " Validation_Release";
                }
                else if (ppvRelRadioButton.Checked) 
                {
                    rel = " PPV_Release";
                }
                else 
                {
                    rel = " Development_Release";
                }
                
//                if (productionIntentCheckBox.Checked)
//                {
//                    prod = " Production_Intent";
//                }

    
                foreach (string part in parts)
            	{
                    // Set up a pattern to test for a cal that is an array (like "NAME(1/33 0)")
                    string command = "Update_Status member=" + part.Trim();
                    string pattern = @"(.+)\.([A-Za-z]{2})";
                
                    // Does the part include it's dls (12345678.AB)?
                    if (Regex.Match(command, pattern).Success)
                    {
                        command = Regex.Replace(command, pattern, "$1 revision=$2");
                        
                         // Update_Status member=12080201 revision=AB PPV_Release Production_Intent
                         //tw.WriteLine(command + revoke + rel + prod);
                         tw.WriteLine(command + revoke + rel);
                    }
                    else
                    {
                        dlsMissing = true;
                    }
                }
                
                if (dlsMissing == true)
                {
                    string msg = "Warning the Update Status command requires a DLS " +
                        "(revision) extension for each part. It was missing on one " +
                        "or more parts. The Update Status command was not written to " +
                        "the process script for those parts.";
                    MessageBox.Show(msg);
                }
            }
        }
        
        void createClass2(List<string> parts, TextWriter tw)
        {
            if (createClass2CheckBox.Checked)
            {
            	foreach (string part in parts)
            	{
                    // The Regex.Replace is removing any extension.
            	    tw.WriteLine("Create_Class2 object=" + Regex.Replace(part.Trim(), @"(\w)\.[a-zA-Z]{2}", "$1"));
            	}
            }
        }
        
        void calplot(List<string> parts, TextWriter tw)
        {
            if (calplotCheckBox.Checked)
            {
            	foreach (string part in parts)
            	{
                    // The Regex.Replace is removing any extension.
                    tw.WriteLine("calplot object=" + Regex.Replace(part.Trim(), @"(\w)\.[a-zA-Z]{2}", "$1") +
            	                 " output=" + prefixTextBox.Text.Trim() + part.Trim() + "." + extTextBox.Text.Trim());
            	}
            }
        }
        
        /// <summary>
        /// This function is called when the user clicks the Add Src Parts
        /// button. It allows the user to select a parts list file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PartsListSrcButtonClick(object sender, EventArgs e)
        {
    	    DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
    	    
    	    if (result == DialogResult.OK) // Test result.
    	    {
        		string file = openFileDialog1.FileName;
                
        		// Does file exist?
            	if (File.Exists(file))
                {
                    // Open the file and copy the contents to the Parts text box.
                    using (StreamReader r = new StreamReader(file))
                    {
                        // Use while != null pattern for loop
                        // "part" is a part number in the file. One part per line.
                        string part;
                        while ((part = r.ReadLine()) != null)
                        {
                            // Add the part to the textbox.
                            partNumSrcTextBox.AppendText(part);
                            partNumSrcTextBox.AppendText(Environment.NewLine);
                        }
                    }
                    UpdateStatusLabel("Parts from file '" + Path.GetFileName(file) + "' were added to the source parts list.");
            	}
            	else
            	{
            	    MessageBox.Show("File Does Not Exist!");
            	}
    	    }
        }
        
        void PartsListDestButtonClick(object sender, EventArgs e)
        {
    	    DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
    	    
    	    if (result == DialogResult.OK) // Test result.
    	    {
        		string file = openFileDialog1.FileName;
                
        		// Does file exist?
            	if (File.Exists(file))
                {
                    // Open the file and copy the contents to the Parts text box.
                    using (StreamReader r = new StreamReader(file))
                    {
                        // Use while != null pattern for loop
                        // "part" is a part number in the file. One part per line.
                        string part;
                        while ((part = r.ReadLine()) != null)
                        {
                            // Add the part to the textbox.
                            partNumDestTextBox.AppendText(part);
                            partNumDestTextBox.AppendText(Environment.NewLine);
                        }
                    }
                    UpdateStatusLabel("Parts from file '" + Path.GetFileName(file) + "' were added to the destination parts list");
            	}
            	else
            	{
            	    MessageBox.Show("File Does Not Exist!");
            	}
    	    }
        }

        void EngScriptOpenButtonClick(object sender, EventArgs e)
        {
    	    DialogResult result = openFileDialog2.ShowDialog(); // Show the dialog.
    	    
    	    if (result == DialogResult.OK) // Test result.
    	    {
        		string file = openFileDialog2.FileName;
                
        		// Does file exist?
            	if (File.Exists(file))
                {
                    // Open the file and copy the contents to the Parts text box.
                    using (StreamReader r = new StreamReader(file))
                    {
                        // Use while != null pattern for loop
                        bool valid = false;
                        string line;
                        while ((line = r.ReadLine()) != null)
                        {
                            // Split the line on tabs.
                            string[] field = Regex.Split(line, "\t");

                            // Verify that the file is an Engineering script. It should have 4 columns of data.
                            // If the first field is "sync" or "wq", skip it.
                            if ((field.Length == 4) && !field[0].Equals("sync") && !field[0].Equals("wq"))
                            {
                                // Add the cal name to the textbox.
                                calNameTextBox.AppendText(field[1]);
                                calNameTextBox.AppendText(Environment.NewLine);
                                
                                // Add the cal index to the textbox.
                                calOffsetTextBox.AppendText(field[2]);
                                calOffsetTextBox.AppendText(Environment.NewLine);
    
                                // Add the cal hex value to the textbox.
                                calValTextBox.AppendText(field[3].PadLeft(2, '0'));
                                calValTextBox.AppendText(Environment.NewLine);

                                valid = true; // indicate that a good record was found
                            }
                        }
                        
                        if (valid == true) 
                        {
                            UpdateStatusLabel("Cals from file '" + Path.GetFileName(file) + "' were added to the Cals list.");
                        }
                        else 
                        {
                            MessageBox.Show("Couldn't find any valid records. Is this an engineering script?");
                        }
                    }
            	}
            	else
            	{
            	    MessageBox.Show("File Does Not Exist!");
            	}
    	    }
        }

        void OutputFolderButtonClick(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) 
            {
                outputFolderTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        
        // Open the User's Guide in a web browser.
        void UsersGuideToolStripMenuItemClick(object sender, EventArgs e)
        {
            string site = "https://gmweb.gm.com/sites/CalSupport/Calds%20Script%20Generator";
            if (Browser.Launch(site))
            {
                UpdateStatusLabel("Unable to launch '" + site + "'.");
            }
        }
        
        void CalSupportToolsSiteToolStripMenuItemClick(object sender, EventArgs e)
        {
            string site = "https://gmweb.gm.com/sites/CalSupport";
            if (Browser.Launch(site))
            {
                UpdateStatusLabel("Unable to launch '" + site + "'.");
            }
        }

        void UpdateStatusLabel(string s)
        {
            toolStripStatusLabel1.Text = DateTime.Now + ": " + s;
        }
        
        void AboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }
        
        void SrcClearButtonClick(object sender, EventArgs e)
        {
            partNumSrcTextBox.Clear();
        }
        
        void ClrDstButtonClick(object sender, EventArgs e)
        {
            partNumDestTextBox.Clear();
        }
        
        void ClearCalsButtonClick(object sender, EventArgs e)
        {
            calNameTextBox.Clear();
            calOffsetTextBox.Clear();
            calValTextBox.Clear();
        }

        void CalOffsetTextBoxDoubleClick(object sender, EventArgs e)
        {
            CalOffset();
        }
       
        void CalOffset()
        {
            string line = String.Empty;
            string lastLine = String.Empty;
            int arrayIndex = 0;
            
            // Clear all data from the cal offset textbox.
            calOffsetTextBox.Clear();
            
            // Split the Cal Name textbox on the newline character so that we 
            // can get the number of lines.
            string [] lines = calNameTextBox.Text.Split('\n');

            // Insert a zero for the offset for each calname.
            for (int i = 0; i < lines.Length; i++)
            {
                // Remove leading and trailing whitespace from the line.
                line = lines[i].Trim();
                
                // If the string is not empty, insert a zero offset for the calname.
                if (!String.IsNullOrEmpty(line))
                {
                    // Is the cal an array (same calname as the last)?
                    if (line.Equals(lastLine))
                    {
                        // Increment the index and set the offset to the index.
                        arrayIndex++;
                        calOffsetTextBox.Text += arrayIndex.ToString();
                    }
                    else
                    {
                        // Not an array. Append a zero to the offset textbox and 
                        // reset the index.
                        calOffsetTextBox.Text += "0";
                        arrayIndex = 0;
                    }
                    
                    // Add a New Line character after each offset value.
                    calOffsetTextBox.Text += Environment.NewLine;
                }
                
                // Save the last line for the next iteration.
                lastLine = line;
            }            
        }
       
        void AutoFillCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            CalOffset();
        }

        /// <summary>
        /// This function is called when the Check-In Copy radio button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CheckinCopyRadioButtonClick(object sender, EventArgs e)
        {
            if (checkinCopyRadioButton.Checked)
            {
                // Checkin Copy was clicked while it was set. So, disable it.
                checkinCopyRadioButton.Checked = false;
                revokeCheckBox.Enabled = false;
                devRelRadioButton.Enabled = false;
                ppvRelRadioButton.Enabled = false;
                valRelRadioButton.Enabled = false;
                logMessageTextBox.Enabled = false;
                revNameTextBox.Enabled = false;
                //productionIntentCheckBox.Enabled = false;
            }
            else
            {
                // Enable it.
                checkinCopyRadioButton.Checked = true;
                updateStatusRadioButton.Checked = false;
                revokeCheckBox.Enabled = false;
                devRelRadioButton.Enabled = true;
                ppvRelRadioButton.Enabled = true;
                valRelRadioButton.Enabled = true;
                logMessageTextBox.Enabled = true;
                revNameTextBox.Enabled = true;
                //productionIntentCheckBox.Enabled = true;
            }
        }
        
        /// <summary>
        /// This function is called when the Update Status radio button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void UpdateStatusRadioButtonClick(object sender, EventArgs e)
        {
            if (updateStatusRadioButton.Checked)
            {
                // Update Status was clicked while it was set. So, disable it.
                updateStatusRadioButton.Checked = false;
                revokeCheckBox.Enabled = false;
                devRelRadioButton.Enabled = false;
                ppvRelRadioButton.Enabled = false;
                valRelRadioButton.Enabled = false;
                //productionIntentCheckBox.Enabled = false;
            }
            else
            {
                // Enable it.
                updateStatusRadioButton.Checked = true;
                checkinCopyRadioButton.Checked = false;
                revokeCheckBox.Enabled = true;
                devRelRadioButton.Enabled = true;
                ppvRelRadioButton.Enabled = true;
                valRelRadioButton.Enabled = true;
                logMessageTextBox.Enabled = false;
                revNameTextBox.Enabled = false;
                //productionIntentCheckBox.Enabled = true;
            }
        }
        
        void CalNameTextBoxTextChanged(object sender, EventArgs e)
        {
            CalEditWarning();
            
            if (autoFillCheckBox.Checked)
            {
                CalOffset();
            }
        }
        
        void BatchCaleditCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            CalEditWarning();
        }

        /// <summary>
        /// This function gives a warning by setting the background color of the
        /// Batch Cal Edit checkbox to yellow if there is something typed in the
        /// Cal Name text box and the batch cal edit checkbox is not checked. Or
        /// the box is checked but the cal name is empty.
        /// </summary>
        void CalEditWarning()
        {
            // Is text box empty.
            if (String.IsNullOrWhiteSpace(calNameTextBox.Text))
            {
                if (batchCaleditCheckBox.Checked)
                {
                    // Warning: No cal entered but Batch Cal Edit is checked.
                    batchCaleditCheckBox.BackColor = Color.Yellow;
                }
                else
                {
                    // OK: No cal entered and Batch Cal Edit is not checked.
                    batchCaleditCheckBox.BackColor = DefaultBackColor;
                }
            }
            else // text box has something in it besides whitespace.
            {
                if (batchCaleditCheckBox.Checked)
                {
                    // OK: Batch Cal Edit checked and cal entered.
                    batchCaleditCheckBox.BackColor = DefaultBackColor;
                }
                else
                {
                    // Warning: Batch Cal Edit not checked and cal entered.
                    batchCaleditCheckBox.BackColor = Color.Yellow;
                }
            }
        }
    }
}
