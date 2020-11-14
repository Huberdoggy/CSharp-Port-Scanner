// Added inheritance to PortScanner Form below - for Mat Skin controls
using MaterialSkin.Controls;
// Also add this 'using':
using MaterialSkin;
using System;
//For StreamReader/Writer
using System.IO;
// For use with relative helpfile path
using System.Reflection;
///////////////////////////////////
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
// Just as a precaution to use the sleep timeout once => after the first Writer closes the file
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
// For ipconfig.exe implementation
using System.Net.Sockets;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using Syncfusion.XlsIO;

namespace Port_Scanner
{
    public partial class PortScanner : MaterialForm
    {
        // To store values from portScanList box later..
        List<string> resultsList = new List<string>();
        private string splitter = "";
        private string description = "";
        // For use with relative helpfile path
        private string executableLocation = "";
        // For use with relative helpfile path
        private string chmLocation = "";
        // Two int vars which will later be assigned to user defined texbox entries in 'Scanner' tab
        private int startPort;
        private int endPoint;
        // For the scan loop
        private int portCounter = 0;
        // Init a field for saveFile so that it can be used by 2 functions easily - first my CSV creator, then my XLSX formatter
        SaveFileDialog saveFile = new SaveFileDialog();
        public PortScanner()
        {

            // Must be set TRUE in order for manual key press event shortcuts to be identified => in this case, I use ALT+X to end program if they don't want to click Exit
            this.KeyPreview = true;
            InitializeComponent();
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzQ1NTg2QDMxMzgyZTMzMmUzMFRSMVNhbEtVbUhiemQ2SUR2aEgyRG1OK2JXZnJBTlhJUlJTK1lyd3FyU2M9");
            // Declare a variable to reference the material form
            var skinManager = MaterialSkinManager.Instance;
            // Skin manager add form to manage THIS form
            skinManager.AddFormToManage(this);
            // Light or Dark - I prefer dark
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            // Make sure to set the TextShade to 'WHITE' if using the DARK theme
            SkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Lime400, TextShade.WHITE);

        }
        private void PortScanner_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(PortScanner_KeyDown);
            // Will be visible after they complete the first step
            tabToggle.TabPages.Remove(portInfoPage);
        }
        // Manually created this KeyDown event due to incompatibilites with the custom material skin on my Exit Button
        private void PortScanner_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt)
            {
                switch (e.KeyCode)
                {
                    case Keys.X:
                        this.Close();
                        break;
                }
            }
            // Run this if Darrell/the user hits F1. It MUST be run outside the switch case since it's not checking for an ALT+Key comobo...
            else if (e.KeyCode.ToString() == "F1")
            {
                executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                chmLocation = Path.Combine(executableLocation, "MyHelpFile.chm");
                System.Windows.Forms.Help.ShowHelp(null, chmLocation);
            }

        }

        private void EnableIPCounter()
        {
            foundIpLbl.Visible = true;
            foundIpLblDesc.Visible = true;
        }

        private void DisableAndClear()
        {
            foundIpLbl.Visible = false;
            foundIpLblDesc.Visible = false;
            ipListBox.Items.Clear();
            foundIpLbl.Text = "";
            getIPButton.Enabled = true;
            getIPButton.Visible = true;
            proceedButton.Visible = false;
            ipAddressTextbox.Text = "";
            scanProgressBar.Value = 0;
            portCountListBox.Items.Clear();
            fromTextBox.Text = "";
            toTextBox.Text = "";
            openPortsLabelDesc.Visible = false;
            openPortsLabel.Visible = false;
            openPortsLabel.Text = "";
            portCounter = 0;
            saveButton.Visible = false;
        }
        private void getIPButton_Click(object sender, EventArgs e)
        {
            // Assign variables for the host entry name and the IP address string
            IPHostEntry host;
            int counter = 0;
            string localIP = "";
            // 'host' will be assigned to a method from Sys.NET which retrieves IP info for the specified hostname
            host = Dns.GetHostEntry(Dns.GetHostName());

            try
            {

                // Loop thru each IP in the DNS listing
                foreach (IPAddress ip in host.AddressList)
                {
                    // Seaarch for local network Ips. If match found, assign its val to my var 'localIP' and output it.
                    // To verify correct info, run 'ipconfig.exe /all ' from Windows command line and notice that your IPV4's for connected adapters are shown in my program
                    if (ip.AddressFamily.ToString() == "InterNetwork")
                    {
                        EnableIPCounter();
                        // Show them how many were found under the relevant filter
                        counter += 1;
                        foundIpLbl.Text = counter.ToString();
                        localIP = ip.ToString();
                        splitter = "******************";
                        description = "Found IP Address: " + Environment.NewLine;
                        ipListBox.Items.Add(description);
                        ipListBox.Items.Add(splitter);
                        ipListBox.Items.Add(localIP);
                        ipListBox.Items.Add(Environment.NewLine);
                    }

                }
                // Do this to only allow 1 run of the loop and prevent racking up a long list.
                // Since I customized my designer with a material skin, it's not allowing me to change BackColor in code
                // So instead of doing a color change/disable, I'm going to keep it simple and do this.
                getIPButton.Enabled = false;
                getIPButton.Visible = false;
                proceedButton.Visible = true;
                if (tabToggle.TabPages.Count < 2)
                {
                    tabToggle.TabPages.Insert(1, portInfoPage);
                }

            }
            catch (Exception ex)
            {
                DisableAndClear();
                MessageBox.Show(ex.Message);
            }

        }
        private void proceedButton_Click(object sender, EventArgs e)
        {

            string chosenItem = "";
            // A temporary workaround so that they cant select whitespace and proceed
            if (ipListBox.SelectedIndex == 3 || ipListBox.SelectedIndex > 6)
            {
                MessageBox.Show("For your convenience, the app can paste data into the next step. But you must select a valid IP from the list.");
                tabToggle.SelectedTab = ipInfoPage;
            }
            // If they make a selection (not whitespace) and selection is not equal to my text headings in the listbox (i.e make them select from a valid IP address)
            else if (ipListBox.SelectedIndex != -1 && ipListBox.SelectedItem.ToString() != splitter && ipListBox.SelectedItem.ToString() != description && ipListBox.SelectedItem != null)
            {
                chosenItem = ipListBox.SelectedItem.ToString();
                ipAddressTextbox.Text = chosenItem;
                tabToggle.SelectedTab = portInfoPage;
                MessageBox.Show("NOTICE: Scan can take a long time when range is high. For optimal results, consider using a start/end port range of roughly 20-30");
            }
            else // If null and click proceed
            {
                MessageBox.Show("For your convenience, the app can paste data into the next step. But you must select a valid IP from the list.");
                tabToggle.SelectedTab = ipInfoPage;
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            // Go back to the first tab
            tabToggle.SelectedTab = ipInfoPage;
        }
        private void helpButton_Click(object sender, EventArgs e)
        {
            // Pass my help.chm file to the ShowHelp() method and pop it open in a new window. adjust this for relative path since it won't always be ref to my machine's drive structure
            executableLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            chmLocation = Path.Combine(executableLocation, "MyHelpFile.chm");
            System.Windows.Forms.Help.ShowHelp(null, chmLocation);

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Run my consolidated method to clear everything and disable where appropriate
            DisableAndClear();
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            {
                this.Close();
            }
            // End the program
            this.Close();
        }
        public void scanPortsButton_Click(object sender, EventArgs e)
        {
            saveButton.Visible = false;
            // To track number of open ports identified (if any)
            bool found = false;
            // Exec these next 2 statements to prevent them from racking up a long list of appended item...personal pet peeve. Start a fresh scan each time with a fresh openPort counter
            portCounter = 0;
            openPortsLabel.Text = portCounter.ToString();
            portCountListBox.Items.Clear();
            try
            {
                // Convert from/to textbox entries to int variables
                startPort = Convert.ToInt32(fromTextBox.Text);
                endPoint = Convert.ToInt32(toTextBox.Text);
                if (startPort > 0)
                {
                    // Reset the progress bar
                    scanProgressBar.Value = 0;

                    // Set max val for progress bar
                    scanProgressBar.Maximum = endPoint - startPort + 1;

                    // Using the cursors class, indicate to the user that the app is busy
                    Cursor.Current = Cursors.WaitCursor;

                    // Here we essentially follow the 'i is less than..etc, but we're swapping i with 'currPort' and incrementing while it's less than or equal to endPoint
                    for (int currPort = startPort; currPort <= endPoint; currPort++)
                    {
                        // Create a new instance of TcpClient
                        TcpClient tcpportScan = new TcpClient();

                        try
                        {
                            // To connect to the current port using IP from the textbox entry and currPort as the 2nd parameter
                            tcpportScan.Connect(ipAddressTextbox.Text, currPort);
                            // If no exception, then that means the 'current port' is open
                            portCountListBox.Items.Add("Port " + currPort.ToString() + " is OPEN." + Environment.NewLine);
                            // In order to increment the 'open ports found' box, I'm setting isTrue to True IF currport successfully connects (line above)
                            found = true;
                            if (found)
                            {
                                portCounter += 1;
                            }

                            openPortsLabelDesc.Visible = true;
                            openPortsLabel.Visible = true;
                            openPortsLabel.Text = portCounter.ToString();
                            // Else the catch happens and no open port counting happens
                        }
                        catch
                        {

                            // If there IS an exception, then the current port is closed
                            portCountListBox.Items.Add("Port " + currPort.ToString() + " is closed." + Environment.NewLine);

                        }
                        // To increase the progress bar
                        scanProgressBar.PerformStep();
                    }
                    // Set the cursor back to normal..for this app I set default to 'Hand'
                    Cursor.Current = Cursors.Hand;
                    MessageBox.Show("Thank you for your patience. Kyle's TCP scanner has completed. Your results are now available to view.");
                    saveButton.Visible = true;
                }
                else
                {
                    MessageBox.Show("Please enter a start port greater than zero.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        // Init this var to false
        private bool didSave = false;
        private void FormatCSV(List<string> iList)
        {
            // Init a counter var and an instance of Writer
            int position;
            StreamWriter outputfile;
            // Instantiate and instance of date time and format it to short-date string
            var current = DateTime.Today;
            string my_dateToday = current.ToShortDateString();
            // Prepop initial directory to user's home folder for convenience - they can choose to save elsewhere
            string csvpath = Environment.ExpandEnvironmentVariables(@"C:\Users\%USERNAME%\Desktop");
            saveFile.InitialDirectory = csvpath;
            saveFile.Filter = "CSV (*.csv) |*.csv";

            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK == false)
            {
                saveFile.Dispose();
                MessageBox.Show("You canceled the operation.");

            }
            else if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                outputfile = File.CreateText(saveFile.FileName);
                // I converted the entire contents of the scanner listbox to string, so this will add all contents to my List parameter for each scan line
                foreach (string result in portCountListBox.Items)
                {
                    iList.Add(result);
                }
                // Write in this order so that my latter function can format it nicely using DATE/PORT as col headings, and the iterable data as row items per line
                string first = iList[0];
                outputfile.WriteLine("DATE" + "," + "PORT");
                outputfile.WriteLine(my_dateToday);
                outputfile.WriteLine("IP ADDRESS");
                outputfile.Write(ipAddressTextbox.Text + "," + first);
                outputfile.WriteLine();

                // Start at 1 so that my formatting ends up how I want it
                for (position = 1; position < iList.Count; position++)
                {
                    outputfile.WriteLine("," + iList[position]);
                }
                outputfile.Close();
                MessageBox.Show($"Data was succesfully written to: {saveFile.FileName} " +
                    $"please wait a moment while your file is formatted....");
                // Allow the next 'Convert' function to execute
                didSave = true;

            }
        }
        // Will track the completion of the XlSX conversion status
        private bool prettified = false;
        private void ConvertToXlsx()
        {

            try
            {

                using (ExcelEngine excelEngine = new ExcelEngine())
                {

                    IApplication application = excelEngine.Excel;
                    application.DefaultVersion = ExcelVersion.Excel2016;

                    //Preserve data types as per the value
                    application.PreserveCSVDataTypes = true;

                    //Read my CSV file
                    Stream csvStream = File.OpenRead(Path.GetFullPath(saveFile.FileName));

                    //Reads CSV stream as a workbook
                    IWorkbook workbook = application.Workbooks.Open(csvStream);
                    IWorksheet sheet = workbook.Worksheets[0];

                    // Formatting CSV data as a table
                    IListObject table = sheet.ListObjects.Create("PortsTable", sheet.UsedRange);
                    table.BuiltInTableStyle = TableBuiltInStyles.TableStyleDark10;
                    IRange location = table.Location;
                    location.AutofitColumns();

                    // Define/apply header style
                    IStyle headerStyle = workbook.Styles.Add("HeaderStyle");
                    headerStyle.BeginUpdate();
                    headerStyle.Color = Syncfusion.Drawing.Color.LightGreen;
                    headerStyle.Font.FontName = "Consolas";
                    headerStyle.Font.Color = Syncfusion.XlsIO.ExcelKnownColors.Dark_blue;
                    headerStyle.Font.Bold = true;
                    headerStyle.Font.Size = 16;
                    headerStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                    headerStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Medium;
                    headerStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Medium;
                    headerStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Medium;
                    headerStyle.EndUpdate();


                    // Define and apply a body style
                    IStyle bodyStyle = workbook.Styles.Add("BodyStyle");
                    bodyStyle.BeginUpdate();
                    bodyStyle.Font.FontName = "Cambria";
                    bodyStyle.Font.Color = Syncfusion.XlsIO.ExcelKnownColors.BlackCustom;
                    bodyStyle.Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Medium;
                    bodyStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Medium;
                    bodyStyle.Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Medium;
                    bodyStyle.Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Medium;
                    bodyStyle.EndUpdate();

                    // Define a few additonal tweaks
                    IStyle increaseStyle = workbook.Styles.Add("IncreaseStyle");
                    increaseStyle.BeginUpdate();
                    increaseStyle.Color = Syncfusion.Drawing.Color.LightSkyBlue;
                    increaseStyle.Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Medium;
                    increaseStyle.Font.Size = 14;
                    increaseStyle.Font.Bold = true;

                    // Modify this range seperately so it doesn't get messed up
                    sheet.Range["A1:A1"].HorizontalAlignment = ExcelHAlign.HAlignCenter;
                    sheet.Range["A2:A2"].DateTime.ToShortDateString();
                    sheet.Range["A2:A2"].CellStyle.Color = Syncfusion.Drawing.Color.LightSkyBlue;
                    sheet.Range["A2:A2"].CellStyle.Font.Bold = true;
                    sheet.Range["A2:A2"].CellStyle.Font.Size = 14;
                    sheet.Range["A2:A4"].HorizontalAlignment = ExcelHAlign.HAlignLeft;
                    sheet.Range["A2:A4"].Borders[ExcelBordersIndex.EdgeLeft].LineStyle = ExcelLineStyle.Medium;
                    sheet.Range["A2:A2"].Borders[ExcelBordersIndex.EdgeRight].LineStyle = ExcelLineStyle.Medium;
                    sheet.Range["A2:A4"].Borders[ExcelBordersIndex.EdgeBottom].LineStyle = ExcelLineStyle.Medium;
                    sheet.Range["A3:A4"].Borders[ExcelBordersIndex.EdgeTop].LineStyle = ExcelLineStyle.Medium;
                    sheet.Range["A3:A3"].HorizontalAlignment = ExcelHAlign.HAlignCenter;
                    sheet.Range["B1:B100"].HorizontalAlignment = ExcelHAlign.HAlignCenter;
                    sheet.Range["B2:B3"].CellStyle.Color = Syncfusion.Drawing.Color.Black;

                    // Custom widths
                    sheet.Columns[0].ColumnWidth = 20.00;

                    // Then Apply header style
                    sheet.Range["A1:A1"].CellStyle = headerStyle;
                    sheet.Range["A3:A3"].CellStyle = headerStyle;
                    sheet.Range["B1:B1"].CellStyle = headerStyle;
                    // And the body style
                    sheet.Range["A4:A4"].CellStyle = bodyStyle;
                    sheet.Range["B4:B100"].CellStyle = bodyStyle;
                    // Additions
                    sheet.Range["A2:A2"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;
                    sheet.Range["A4:A4"].CellStyle = increaseStyle;
                    sheet.Range["A4:A4"].CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter;


                    // Apply a conditional format for cells with the text 'Open'
                    IConditionalFormats condition = sheet.Range["B4:B100"].ConditionalFormats;
                    IConditionalFormat condition1 = condition.AddCondition();

                    condition1.FormatType = ExcelCFType.SpecificText;
                    condition1.Text = "Open";
                    condition1.Operator = ExcelComparisonOperator.ContainsText;
                    condition1.BackColor = ExcelKnownColors.Red;

                    // Save file in the same directory as the initial raw CSV from StreamWriter
                    Stream excelStream;
                    string makeoverPath = Environment.ExpandEnvironmentVariables(@"C:\Users\%USERNAME%\Desktop\makeover.xlsx");
                    excelStream = File.Create(Path.GetFullPath(makeoverPath));
                    workbook.SaveAs(excelStream);
                    // Release all resources => IMPORTANT!
                    excelStream.Dispose();
                    MessageBox.Show("SUCCESS! Your original file " + saveFile.FileName + " has been converted to .XLSX. You can view it at: " + makeoverPath);
                    // Flip this on so that below I can safely delete the ugly .CSV original file
                    prettified = true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            scanProgressBar.Value = 0;
            // Run my method
            FormatCSV(resultsList);
            // Wait 3 seconds to ensure file is closed
            Thread.Sleep(3000);
            if (didSave == true)
            {
                // Then, run my method using the Syncfusion package to format .xlsx nicely
                ConvertToXlsx();
                if (prettified == true)
                {
                    // I'm doing this to force the reclamation of resources/memory since I was getting errors that the original file was still in use
                    System.GC.Collect();
                    System.GC.WaitForPendingFinalizers();
                    // Call it one more time to ensure cleanup of dead objects
                    System.GC.Collect();
                    // Now, finally, delete the original CSV so that only the new prettified .XSLX remains in the directory path
                    File.Delete(saveFile.FileName);
                }
                else
                {
                    MessageBox.Show("Something happened. CSV was NOT converted to .XLSX");
                }
            }
            else
            {
                // Prevents sporadic errors when canceling between saveFile dialogs
                MessageBox.Show("Something happened. Raw .CSV was not formatted");
            }

        }


    }
}


