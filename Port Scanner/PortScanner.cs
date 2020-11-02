// Added inheritance to PortScanner Form below - for Mat Skin controls
using MaterialSkin.Controls;
// Also add this 'using':
using MaterialSkin;
using System;
//For StreamReader/Writer
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// For ipconfig.exe implementation
using System.Net.Sockets;
using System.Net;
using System.Runtime.InteropServices.ComTypes;

namespace Port_Scanner
{
    public partial class PortScanner : MaterialForm
    {
        private string splitter = "";
        private string description = "";
        // Two int vars which will later be assigned to user defined texbox entries in 'Scanner' tab
        private int startPort;
        private int endPoint;
        // For the scan loop
        private int portCounter = 0;
        public PortScanner()
        {
            InitializeComponent();
            // Declare a variable to reference the material form
            var skinManager = MaterialSkinManager.Instance;
            // Skin manager add form to manage THIS form
            skinManager.AddFormToManage(this);
            // Light or Dark - I prefer dark
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            // Make sure to set the TextShade to 'WHITE' if using the DARK theme
            SkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Lime400, TextShade.WHITE);
        }

        private void EnableIPCounter()
        {
            foundIpLbl.Visible = true;
            foundIpLblDesc.Visible = true;
        }

        //bool isTrue = false;

        /* TODO => Why is Tab removal at runtime throwing an exception??
        private bool TabNumber(bool value)
        {

            if (tabToggle.TabPages.Contains(portInfoPage))
            {
                value = true;

                tabToggle.SelectedTab = ipInfoPage;
                tabToggle.TabPages.RemoveAt(1);
                // tabToggle.Controls.Remove(portInfoPage);
            }
            else
            {
                value = false;
            }
            return isTrue;
        }*/
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
            // Disabled for now => See 'TODO' above...
            //TabNumber(isTrue);

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

            if (ipListBox.SelectedIndex != -1 && ipListBox.SelectedItem.ToString() != splitter && ipListBox.SelectedItem.ToString() != description)
            {
                chosenItem = ipListBox.SelectedItem.ToString();
                ipAddressTextbox.Text = chosenItem;
                tabToggle.SelectedTab = portInfoPage;
            }
            else
            {
                MessageBox.Show("Please choose from one of the IPs and click the proceed button below.");
                tabToggle.SelectedTab = ipInfoPage;
            }
            //tabToggle.SelectedTab = portInfoPage;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Run my consolidated method to clear everything and disable where appropriate
            DisableAndClear();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            // End the program
            this.Close();
        }
        public void scanPortsButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Exec these next 2 statements to prevent them from racking up a long list of appended item...personal pet peeve. Start a fresh scan each time with a fresh openPort counter
                portCountListBox.Items.Clear();
                portCounter = 0;
                // Convert from/to textbox entries to int variables
                bool isTrue = false;
                startPort = Convert.ToInt32(fromTextBox.Text);
                endPoint = Convert.ToInt32(toTextBox.Text);
                if (startPort > 0)
                {

                    //}
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
                            portCountListBox.Items.Add("Port " + currPort + " is open." + Environment.NewLine);
                            // In order to increment the 'open ports found' box, I'm setting isTrue to True IF currport successfully connects (line above)
                            isTrue = true;
                            if (isTrue)
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
                            portCountListBox.Items.Add("Port " + currPort + " is closed." + Environment.NewLine);

                        }
                        // To increase the progress bar
                        scanProgressBar.PerformStep();
                    }
                    // Set the cursor back to normal..for this app I set default to 'Hand'
                    Cursor.Current = Cursors.Hand;
                    MessageBox.Show("Thankyou for your patience. Kyle's TCP scanner has completed. Your results are now available to view.");
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
        private void PortScanner_Load(object sender, EventArgs e)
        {

            tabToggle.TabPages.Remove(portInfoPage);
        }
    }
}


