/*
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
using System.Diagnostics;         // Process
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

using System.Runtime.InteropServices; // DllImport


namespace CaldsScriptGenerator
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]
        static extern int SetScrollPos(IntPtr hWnd, int nBar, 
                                       int nPos, bool bRedraw);
        [DllImport("user32.dll")]
        static extern int SendMessage(IntPtr hWnd, int wMsg, 
                               int wParam, int lParam);
        const int EM_LINESCROLL = 0x00B6;
        
        string ProcessScriptFile = "CalGenProcessScript.txt";
        string EngScriptFile     = "CalGenEngScript.txt";
        string PartsListFile     = "CalGenPartsList.txt";
        
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
                UpdateStatusBar("Output folder Does Not Exist! Please enter a valid output folder.");
                return;
            }
        	
            // If the source parts list is needed, verify that it exists.
            if (IsSrcPartsListRequired() && (partNumSrcTextBox.Text.Length == 0)) 
            {
                UpdateStatusBar("Enter at least 1 source part, please.");
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
                UpdateStatusBar("Enter at least 1 destination part, please.");
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
            
            if (transferCheckBox.Checked || uploadCheckBox.Checked) {
                mkcopy(partsDst, tw);
            }
            
            chcalcopy(partsSrc, tw);
            copyBenchValues(partsSrc, tw);
            transfer(partsSrc, partsDst, tw);
            bldImage(partsSrc, tw);
            upload(partsSrc, partsDst, tw);
            batchCaledit(tw);
            
            // Checkin Copy, Create Class 2, Calplot. 
            // If the Upload or Transfer checkboxes are checked, 
            // Then process the destination parts,
            // Else process the source parts.
            if (uploadCheckBox.Checked || transferCheckBox.Checked)
            {
                checkinCopy(partsDst, tw);
                createClass2(partsDst, tw);
                calplot(partsDst, tw);
            }
            else
            {
                checkinCopy(partsSrc, tw);
                createClass2(partsSrc, tw);
                calplot(partsSrc, tw);
            }
            
            // close the Process Script file.
            tw.Close();

        	// Update the status text box.
            UpdateStatusBar("The Process Script file '" + ProcessScriptFile + "' was created.");
        }

        /// <summary>
        /// This function checks if the source parts list is required.
        /// </summary>
        /// <returns></returns>
        bool IsSrcPartsListRequired()
        {
        	if (activateCheckBox.Checked     ||
                mkcopyCheckBox.Checked       ||
                chcalcopyCheckBox.Checked    ||
                copyBenchCheckBox.Checked    ||
                batchCaleditCheckBox.Checked ||
                transferCheckBox.Checked     ||
                bldImageCheckBox.Checked     ||
                checkincopyCheckBox.Checked  ||
                createClass2CheckBox.Checked ||
                calplotCheckBox.Checked        )
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
        
        void batchCaledit(TextWriter tw)
        {
            if (batchCaleditCheckBox.Checked)
            {
                // Write the Batch Cal Edit command to the Process Script.
                tw.WriteLine("Batch_caledit file=" + PartsListFile + " script=" + EngScriptFile);

                // Write the source parts list to a file.
                if (unixFormatCheckBox.Checked)
                {
                    // Unix format.
                    File.WriteAllText(outputFolderTextBox.Text + "\\" + PartsListFile, partNumSrcTextBox.Text.Replace("\r\n", "\n"));
                }
                else
                {
                    File.WriteAllText(outputFolderTextBox.Text + "\\" + PartsListFile, partNumSrcTextBox.Text);
                }
                // Write the cal name, index, and value to the eng script file.
                if (writeCalsToFile() == false) 
                {
                    UpdateStatusBar("Eng script not written. Cal data not right.");
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
                for (int i = 0; i < calNameTextBox.Lines.Length; i++) 
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
                UpdateStatusBar("The Engineering Script file '" + EngScriptFile + "' was created.");
            }
            else
            {
                string len = "(" 
                    + calNameTextBox.Lines.Length.ToString() + ", "
                    + calOffsetTextBox.Lines.Length.ToString() + ", "
                    + calValTextBox.Lines.Length.ToString() + ")."; 
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
            bool rv = false;
            
            if ((calNameTextBox.Lines.Length   == calOffsetTextBox.Lines.Length) &&
                (calOffsetTextBox.Lines.Length == calValTextBox.Lines.Length))
            {
                rv = true;
            }
            
            return rv;
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
            if (checkincopyCheckBox.Checked)
            {
                string rel = "";
                
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
        /// This function is called when the user clicks the button (with the 
        /// three dots in it) next to the Parts List edit box. It allows the 
        /// user to select a parts list file.
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
                    UpdateStatusBar("Parts from file '" + Path.GetFileName(file) + "' were added to the source parts list.");
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
                    UpdateStatusBar("Parts from file '" + Path.GetFileName(file) + "' were added to the source parts list");
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
                            if (field.Length == 4) {
                                valid = true; // indicate that a good record was found
                                
                                // Add the cal name to the textbox.
                                calNameTextBox.AppendText(field[1]);
                                calNameTextBox.AppendText(Environment.NewLine);
                                
                                // Add the cal index to the textbox.
                                calOffsetTextBox.AppendText(field[2]);
                                calOffsetTextBox.AppendText(Environment.NewLine);
    
                                // Add the cal hex value to the textbox.
                                calValTextBox.AppendText(field[3].PadLeft(2, '0'));
                                calValTextBox.AppendText(Environment.NewLine);
                            }
                        }
                        
                        if (valid == true) {
                            UpdateStatusBar("Cals from file '" + Path.GetFileName(file) + "' were added to the Cals list.");
                        }
                        else {
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
        
        
        // Tries to open the User's Guide in a web browser.
        void UsersGuideToolStripMenuItem1Click(object sender, EventArgs e)
        {
            bool error = false;
           	string[] browsers = { "chrome.exe", "firefox.exe", "iexplore.exe" };
            string site = "https://gmweb.gm.com/sites/CalSupport/Calds%20Script%20Generator";
            
            Process browser = new Process();
            browser.StartInfo.Arguments = site;
            
            // Look for a web browser.
            foreach (string b in browsers) 
            {
                error = false;
                browser.StartInfo.FileName  = b;
                try
                {
                    browser.Start();
                }
                catch
                {
                    error = true;
                }
                
                if (error == false) 
                {
                    // The browser was launched without error, break out of the loop.
                    break;
                }
            }

            // Send a message to the status text box if we couldn't open a browser.
            if (error == true)
            {
                UpdateStatusBar(site);
            }
        }
        
        void UpdateStatusBar(string s)
        {
            toolStripStatusLabel1.Text = DateTime.Now + ": " + s;
        }
        
        void AboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }
        
        void PartNumbersTextBoxMouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox99.Clear();
        }
        
        void CalVScrollBarScroll(object sender, ScrollEventArgs e)
        {
            //int position;
            
            //position = CalVScrollBar.Value;

            //SetScrollPos(calNameTextBox.Handle,1,calNameTextBox.Lines.Length-1,true);
            //SendMessage(calNameTextBox.Handle,EM_LINESCROLL,0,calNameTextBox.Lines.Length-1);
            
            //SetScrollPos(calNameTextBox.Handle,1,position,true);
            //SendMessage(calNameTextBox.Handle,EM_LINESCROLL,0,position);
        }
    }
}
