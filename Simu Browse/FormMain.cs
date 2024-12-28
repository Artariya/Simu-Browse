using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System.IO;
using IWshRuntimeLibrary;
using File = System.IO.File;
using System.Reflection;
using System.Net;
using System.Data.SQLite;

namespace Simu_Browse
{
    public partial class FormMain : Form
    {
        private WebView2 webView;
        private SQLiteConnection sqliteConn;
        private string UserAgent;
        private int Width;
        private int Height;


        public FormMain()
        {
            InitializeComponent();

            // db connection
            sqliteConn = new SQLiteConnection("Data Source=devices.db;Version=3;");
            if (!File.Exists("devices.db"))
            {
                SQLiteConnection.CreateFile("devices.db");
            }
            sqliteConn.Open();
            CreateDevicesTable();
            LoadDataSql();

            // load saved data
            UserAgent = iniData.ReadData("device", "user_agent", "Mozilla/5.0 (iPhone; CPU iPhone OS 17_2 like Mac OS X) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/17.5.42 Mobile/AB58W2 Safari/619.6.1");
            Width = int.Parse(iniData.ReadData("device", "width", "430"));
            Height = int.Parse(iniData.ReadData("device", "height", "932"));
            checkBoxFixSize.Checked = iniData.ReadData("setting", "fix_size") == "1" ? true : false;

            // webView
            webView = new WebView2();
            panelBrowser.Controls.Add(webView);
            UpdateWebViewPosition();
            InitializeWebView();
        }

        private async void InitializeWebView()
        {
            await webView.EnsureCoreWebView2Async(null);

            // user agent
            webView.CoreWebView2.Settings.UserAgent = UserAgent;

            // evnets
            webView.CoreWebView2.NavigationCompleted += WebView_NavigationCompleted;
            webView.CoreWebView2.NavigationStarting += webView_NavigationStarting;
            webView.CoreWebView2.SourceChanged += CoreWebView2_SourceChanged;

            LoadPage();
        }

        private void LoadPage()
        {
            // Get the command line arguments
            string[] args = Environment.GetCommandLineArgs();

            // Check if the program was opened with a URL as an argument
            if (args.Length > 1)
            {
                string url = args[1];
                if (Uri.IsWellFormedUriString(url, UriKind.Absolute))
                {
                    // Navigate WebView2 to the provided URL
                    webView.Source = new Uri(url);
                }
                else
                {
                    MessageBox.Show("The URL is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // If no URL is passed, load a default page
                webView.Source = new Uri("https://www.google.com"); // Or any default URL
            }
        }

        private async void WebView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            // event ready
            await webView.CoreWebView2.ExecuteScriptAsync(File.ReadAllText(Path.Combine(Application.StartupPath, "ready.js")));
        }

        private async void webView_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)

        {
            // event loading
            await webView.CoreWebView2.ExecuteScriptAsync(File.ReadAllText(Path.Combine(Application.StartupPath, "onLoading.js")));
        }

        private void CoreWebView2_SourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
        {
            string currentUrl = webView.CoreWebView2.Source.ToString();
            textBoxUrl.Text = currentUrl;
            buttonBackward.Enabled = webView.CanGoBack;
            buttonForward.Enabled = webView.CanGoForward;
        }

        private void UpdateWebViewPosition()
        {
            if (webView != null)
            {
                if (checkBoxFixSize.Checked)
                {
                    webView.Dock = DockStyle.None;
                    webView.Size = new Size(Width, Height);
                    webView.Location = new Point(
                        (panelBrowser.Width - Width) / 2,
                        (panelBrowser.Height - Height) / 2
                    );
                }
                else
                {
                    webView.Dock = DockStyle.Fill;
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            webView.Source = new Uri(textBoxUrl.Text);
        }

        private void panelBrowser_SizeChanged(object sender, EventArgs e)
        {
            UpdateWebViewPosition();
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            if (webView.CanGoForward)
            {
                webView.GoForward();
            }
        }

        private void buttonBackward_Click(object sender, EventArgs e)
        {
            if (webView.CanGoBack)
            {
                webView.GoBack();
            }
        }

        public void CreateShortcut()
        {
            // Get the current URL from WebView2
            string url = webView.Source.ToString();

            if (string.IsNullOrEmpty(url))
            {
                MessageBox.Show("No URL found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the user's desktop path
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string shortcutPath = Path.Combine(desktopPath, $"{GetSiteName(url)}.lnk");

            // Get the executable path of the program
            string appPath = Assembly.GetExecutingAssembly().Location;

            // Create an 'icons' folder next to the executable
            string iconFolderPath = Path.Combine(Path.GetDirectoryName(appPath), "icons");

            // Make sure the 'icons' folder exists
            if (!Directory.Exists(iconFolderPath))
            {
                Directory.CreateDirectory(iconFolderPath);
            }

            // Download the favicon
            string iconUrl = $"{new Uri(url).Scheme}://{new Uri(url).Host}/favicon.ico";
            string iconFilePath = Path.Combine(iconFolderPath, GetSiteName(url).Replace('.', '_') + ".ico");

            // Download the favicon and save it to the 'icons' folder
            DownloadIcon(iconUrl, iconFilePath);

            // Create a shortcut object
            var shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath);

            // Set shortcut properties
            shortcut.TargetPath = appPath;
            shortcut.Arguments = url; // Pass the URL as an argument to the program
            shortcut.IconLocation = iconFilePath; // Set the site's icon for the shortcut
            shortcut.Save();

            // Show a success message
            MessageBox.Show("Shortcut created successfully on your desktop.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Method to download the favicon and save it locally
        private void DownloadIcon(string iconUrl, string destinationPath)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile(iconUrl, destinationPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to download icon: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to extract the site name from the URL (used for the shortcut name)
        private string GetSiteName(string url)
        {
            // Extract the domain name from the URL
            Uri uri = new Uri(url);
            return uri.Host.Replace("www.", "");
        }

        private void buttonShortcut_Click(object sender, EventArgs e)
        {
            CreateShortcut();
        }

        private void buttonSelectDevice_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridViewDevices.SelectedRows;

            if (selectedRow.Count > 0)
            {
                string deviceName = selectedRow[0].Cells["Name"].Value.ToString();
                MessageBox.Show($"Selected device: {deviceName}", "Device Selected", MessageBoxButtons.OK);
                File.WriteAllText(Path.Combine(Application.StartupPath, "selected_device.txt"), selectedRow[0].Cells["Id"].Value.ToString());
                UserAgent = selectedRow[0].Cells["UserAgent"].Value.ToString();
                iniData.ReadData("device", "user_agent", UserAgent);
                Width = int.Parse(selectedRow[0].Cells["Width"].Value.ToString());
                int.Parse(iniData.ReadData("device", "width", Width.ToString()));
                Height = int.Parse(selectedRow[0].Cells["Height"].Value.ToString());
                int.Parse(iniData.ReadData("device", "height", Height.ToString()));
                webView.CoreWebView2.Settings.UserAgent = UserAgent;
            }
            else
            {
                MessageBox.Show("No device selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewDevices_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string name = dataGridViewDevices.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            string userAgent = dataGridViewDevices.Rows[e.RowIndex].Cells["UserAgent"].Value.ToString();
            int width = Convert.ToInt32(dataGridViewDevices.Rows[e.RowIndex].Cells["Width"].Value);
            int height = Convert.ToInt32(dataGridViewDevices.Rows[e.RowIndex].Cells["Height"].Value);

            string updateQuery = "UPDATE devices SET Name = @Name, UserAgent = @UserAgent, Width = @Width, Height = @Height WHERE Name = @Name";
            SQLiteCommand command = new SQLiteCommand(updateQuery, sqliteConn);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@UserAgent", userAgent);
            command.Parameters.AddWithValue("@Width", width);
            command.Parameters.AddWithValue("@Height", height);

            command.ExecuteNonQuery();
        }

        // Function to get the selected device name
        public string GetSelectedDevice()
        {
            var selectedRow = dataGridViewDevices.SelectedRows;
            if (selectedRow.Count > 0)
            {
                return selectedRow[0].Cells["Name"].Value.ToString();
            }
            return string.Empty; // Return empty if no row is selected
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqliteConn.Close();
        }

        private void LoadDataSql()
        {
            string query = "SELECT * FROM devices";
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query, sqliteConn);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            dataGridViewDevices.DataSource = dataTable;
        }

        private void CreateDevicesTable()
        {
            string createTableQuery = @"
            CREATE TABLE IF NOT EXISTS devices (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Name TEXT NOT NULL,
                UserAgent TEXT,
                Width INTEGER,
                Height INTEGER
            )";

            SQLiteCommand command = new SQLiteCommand(createTableQuery, sqliteConn);
            command.ExecuteNonQuery();
        }

        private void buttonAddDevice_Click(object sender, EventArgs e)
        {
            AddDeviceForm addDeviceForm = new AddDeviceForm();

            if (addDeviceForm.ShowDialog() == DialogResult.OK)
            {
                string name = addDeviceForm.DeviceName;
                string userAgent = addDeviceForm.DeviceUserAgent;
                int width = addDeviceForm.DeviceWidth;
                int height = addDeviceForm.DeviceHeight;
                AddDeviceToDatabase(name, userAgent, width, height);
                LoadDataSql();
            }
        }

        private void AddDeviceToDatabase(string name, string userAgent, int width, int height)
        {
            string insertQuery = "INSERT INTO devices (Name, UserAgent, Width, Height) VALUES (@name, @userAgent, @width, @height)";

            SQLiteCommand command = new SQLiteCommand(insertQuery, sqliteConn);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@userAgent", userAgent);
            command.Parameters.AddWithValue("@width", width);
            command.Parameters.AddWithValue("@height", height);

            command.ExecuteNonQuery();
        }

        private void buttonDeleteDevice_Click(object sender, EventArgs e)
        {
            if (dataGridViewDevices.SelectedRows.Count > 0)
            {
                int selectedDeviceId = Convert.ToInt32(dataGridViewDevices.SelectedRows[0].Cells["Id"].Value);
                DeleteDeviceFromDatabase(selectedDeviceId);
                LoadDataSql();
            }
            else
            {
                MessageBox.Show("Please select a device to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteDeviceFromDatabase(int deviceId)
        {
            string deleteQuery = "DELETE FROM devices WHERE Id = @deviceId";

            SQLiteCommand command = new SQLiteCommand(deleteQuery, sqliteConn);
            command.Parameters.AddWithValue("@deviceId", deviceId);

            command.ExecuteNonQuery();
        }

        private void checkBoxFixSize_CheckedChanged(object sender, EventArgs e)
        {
            iniData.WriteData("setting", "fix_size", checkBoxFixSize.Checked ? "1" : "0");
            UpdateWebViewPosition();
        }
    }
}
