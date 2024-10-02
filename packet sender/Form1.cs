using System.Net.Sockets;
using System.Text;

namespace packet_sender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int linesToSendPerInterval = 1; // Default value, can be changed by user input
        private string file = "log.txt"; // File path, can be changed as needed
        private int intervalSeconds = 30; // Default interval in seconds
        private int totalLinesSent = 0; // Total number of lines sent
        private List<string> linesToProcess = new List<string>(); // List to hold all lines to be sent

        private void send_btn_Click(object sender, EventArgs e)
        {
            string ipAddress = address_txt.Text;
            int port;
            txtSentData.Clear();

            if (!int.TryParse(port_txt.Text, out port))
            {
                MessageBox.Show("Invalid port number.");
                return;
            }
            // Read lines per interval from the text box
            if (!int.TryParse(linesPerInterval_txt.Text, out linesToSendPerInterval))
            {
                MessageBox.Show("Invalid number of lines per interval.");
                return;
            }
            // Read interval duration from the text box
            if (!int.TryParse(intervalSeconds_txt.Text, out intervalSeconds))
            {
                MessageBox.Show("Invalid interval duration.");
                return;
            }

            string file = fileName.Text;
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            string filePath = Path.Combine(desktopPath, file); // Path to your text file
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Remove the timestamp part from each line
                        int index = line.IndexOf(":\t ");
                        if (index != -1)
                        {
                            line = line.Substring(index + 1).TrimStart(); // Remove timestamp and leading whitespace
                        }
                        else
                        {
                            index = line.IndexOf(": ");
                            if(index != -1)
                            {
                                line = line.Substring(index + 1).TrimStart();
                            }
                        }
                        linesToProcess.Add(line);
                        //MessageBox.Show(line);
                    }
                }
                MessageBox.Show($"Read {linesToProcess.Count} lines from log file.");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error reading log file: " + ex.Message);
                return;
            }

            // Start the timer
            timer1.Interval = intervalSeconds * 1000; // Convert seconds to milliseconds
            timer1.Start();
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            try
            {

                using (TcpClient client = new TcpClient(address_txt.Text, int.Parse(port_txt.Text)))
                using (NetworkStream stream = client.GetStream())
                {
                    int linesRemaining = linesToProcess.Count - totalLinesSent;
                    int linesToSend = Math.Min(linesToSendPerInterval, linesRemaining);

                    // Send the next chunk of lines
                    for (int i = totalLinesSent; i < totalLinesSent + linesToSend; i++)
                    {
                        byte[] data = HexStringToByteArray(linesToProcess[i]);
                        stream.Write(data, 0, data.Length);

                        // Append sent data to the txtSentData text field
                        txtSentData.AppendText(linesToProcess[i] + Environment.NewLine);
                    }

                    // Update total lines sent
                    totalLinesSent += linesToSend;

                    // Update the label with the total number of lines sent
                    linesSent_lbl.Text = $"Lines Sent: {totalLinesSent}";

                    // If all lines have been sent, stop the timer
                    if (totalLinesSent >= linesToProcess.Count)
                    {
                        timer1.Stop();
                        MessageBox.Show("All lines sent successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show("Error: " + ex.Message);
            }
        }

        private byte[] HexStringToByteArray(string hex)
        {
            int numberChars = hex.Length;
            byte[] bytes = new byte[numberChars / 2];
            for (int i = 0; i < numberChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return bytes;
        }

        private void UpdateSentDataTextBox(string line)
        {
            if (txtSentData.InvokeRequired)
            {
                txtSentData.Invoke(new Action<string>(UpdateSentDataTextBox), line);
            }
            else
            {
                txtSentData.AppendText(line + Environment.NewLine);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
