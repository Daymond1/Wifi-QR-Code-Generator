using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using QRCoder;

namespace Wifi_QR_Code_Generator
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
            LoadWifiProfiles();

        }

        private void LoadWifiProfiles()
        {
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = "-Command \"(netsh wlan show profiles) | Select-String ':\\s' | ForEach-Object { $_ -replace '.*: ', '' }\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            string[] lines = output.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            SSIDlist.Items.Clear();

            if (lines.Length == 0)
            {
                SSIDlist.Items.Add("Nothing to show");
                CopyPasswd.Enabled = false;
                ShowPassword.Enabled = false;
                pictureBoxQr.Enabled = false;
            }
            else
            {
                foreach (string line in lines)
                {
                    string profileName = line.Trim();
                    if (!string.IsNullOrWhiteSpace(profileName))
                    {
                        SSIDlist.Items.Add(profileName);
                    }
                }

                CopyPasswd.Enabled = true;
                ShowPassword.Enabled = true;
                pictureBoxQr.Enabled = true;
            }

            SSIDlist.SelectedIndexChanged += (s, e) =>
            {
                if (SSIDlist.SelectedItem != null && SSIDlist.SelectedItem.ToString() == "Nothing to show")
                {
                    SSIDlist.ClearSelected();
                }
                else
                {
                    QRGenerate();
                }
            };
        }

        private void QRGenerate()
        {
            if (SSIDlist.SelectedItem != null)
            {
                string selectedProfile = SSIDlist.SelectedItem.ToString();
                (string password, string encryptionType, bool isHidden) = GetWifiPassword(selectedProfile);
                TextBoxPassword.Text = password;

                if (password == "Password not found")
                {
                    MessageBox.Show("Could not find the password for this network.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string qrCodeText = $"WIFI:S:{selectedProfile};T:{encryptionType};P:{password};H:{(isHidden ? "true" : "false")};;";

                using (var qrGenerator = new QRCodeGenerator())
                {
                    QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrCodeText, QRCodeGenerator.ECCLevel.Q);
                    using (var qrCode = new QRCode(qrCodeData))
                    {
                        Bitmap qrCodeImage = qrCode.GetGraphic(4);
                        pictureBoxQr.Image = qrCodeImage;
                    }
                }
            }
        }




        private (string password, string encryptionType, bool isHidden) GetWifiPassword(string profileName)
        {
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "powershell.exe",
                    Arguments = $"-Command \"netsh wlan show profile name='{profileName}' key=clear\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            string password = "Password not found";
            string authenticationType = "unknown";
            bool isHidden = false;

            string[] lines = output.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                if (line.Trim().StartsWith("Key Content"))
                {
                    password = line.Split(':')[1].Trim();
                }
                else if (line.Trim().StartsWith("Authentication"))
                {
                    authenticationType = line.Split(':')[1].Trim();
                }
                else if (line.Trim().StartsWith("SSID name"))
                {
                    isHidden = line.Contains("(Hidden)");
                }
            }

            string encryptionType = GetEncryptionType(authenticationType);

            return (password, encryptionType, isHidden);
        }

        private string GetEncryptionType(string authenticationType)
        {
            if (authenticationType.Contains("WPA3"))
            {
                return "WPA3";
            }
            else if (authenticationType.Contains("WPA2"))
            {
                return "WPA2";
            }
            else if (authenticationType.Contains("WEP"))
            {
                return "WEP";
            }
            else if (authenticationType.Contains("None"))
            {
                return "";
            }

            return "Unknown";
        }


        private void nightForm1_Click(object sender, EventArgs e)
        {
        }

        private void ShowPassword_Click(object sender, EventArgs e)
        {

            if (TextBoxPassword.UseSystemPasswordChar)
            {

                TextBoxPassword.UseSystemPasswordChar = false;
                ShowPassword.Text = "Hide Password";
                QRGenerate();
            }
            else
            {

                TextBoxPassword.UseSystemPasswordChar = true;
                ShowPassword.Text = "Show Password";
            }
        }

        private void CopyPasswd_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(TextBoxPassword.Text))
            {

                Clipboard.SetText(TextBoxPassword.Text);


                MessageBox.Show("Password copied to clipboard!", "Copying password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                MessageBox.Show("Password not found to copy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nightLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var url = "https://github.com/Daymond1";
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true 
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening link: " + ex.Message);
            }
        }
    }
}
