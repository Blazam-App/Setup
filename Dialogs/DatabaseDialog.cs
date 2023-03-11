
using Microsoft.Deployment.WindowsInstaller;
using Setup;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Windows;
using WixSharp;
using WixSharp.UI.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WixSharpSetup
{
    public partial class DatabaseDialog : ManagedForm, IManagedDialog
    {
        string appSettingsPath = Path.GetFullPath(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + @"\Blazam Server\appsettings.json");
        public static bool Skipped = false;
        public ManagedForm Host;
        ISession session => Host?.Runtime.Session;
        public DatabaseDialog()
        {
            //NOTE: If this assembly is compiled for v4.0.30319 runtime, it may not be compatible with the MSI hosted CLR.
            //The incompatibility is particularly possible for the Embedded UI scenarios. 
            //The safest way to avoid the problem is to compile the assembly for v3.5 Target Framework.WixSharp Setup
            InitializeComponent();
        }

        void dialog_Load(object sender, EventArgs e)
        {
            Host = this;
            banner.Image = Runtime.Session.GetResourceBitmap("WixUI_Bmp_Banner");
            Text = "[ProductName] Setup";
            
            if (InstallationType.installationType == "SERVICE")
            {
                
               /* if (System.IO.File.Exists(appSettingsPath))
                {
                    Skipped = true;
                    Shell.GoNext();
                }*/
            }

            if (session.Property("DATABASE_TYPE") == "SQLite")
            {
                Shell.GoTo<DatabaseFilePathDialog>();
            }


            ErrorBox.Text = appSettingsPath + System.IO.File.Exists(appSettingsPath).ToString() + 
                InstallationType.installationType;
            next.Enabled = false;
            CustomPanel.Visible = false;
            ErrorBox.Visible = true;

            if (session.Property("DATABASE_TYPE") == "MYSQL")
            {
                PortBox.Value = 3306;
                testButton.Visible = false;
                next.Enabled = true;
                ErrorBox.Text = "The installer is incapable of checking MySQL connection settings." +
                    " Please test the settings and verify yourself.";
            }
                //resolve all Control.Text cases with embedded MSI properties (e.g. 'ProductName') and *.wxl file entries
                base.Localize();
        }

        void back_Click(object sender, EventArgs e)
        {
            Shell.GoPrev();
        }

        void next_Click(object sender, EventArgs e)
        {
            ApplyAppSettingsAction.Username = UsernameBox.Text;
            ApplyAppSettingsAction.Password = PasswordBox.Text;
            ApplyAppSettingsAction.Database = DatabaseBox.Text;
            ApplyAppSettingsAction.Server = ServerBox.Text; 
            ApplyAppSettingsAction.Port= PortBox.Text;  
            ApplyAppSettingsAction.Custom= ConnectionStringBox.Text;  

            Shell.GoNext();
        }

        void cancel_Click(object sender, EventArgs e)
        {
            Shell.Cancel();
        }
        private void testButton_Click(object sender, EventArgs e)
        {
            if(DatabaseBox.Text==null || DatabaseBox.Text == "")
            {
                ErrorBox.Text = "Database name must be provided!";
                return;
            }
            string connString = $"Server={ServerBox.Text},{PortBox.Value};Database={DatabaseBox.Text};User ID={UsernameBox.Text};Password={PasswordBox.Text};Connection Timeout=10;";
            ErrorBox.Text = "Testing connection please wait...";
            try
            {
                if (session.Property("DATABASE_TYPE") == "MYSQL")
                {

                    SqlConnection testConn = new SqlConnection(connString);
                    testConn.Open();
                    if (testConn.State == System.Data.ConnectionState.Open)
                    {
                        ErrorBox.Text = "Test Successful \r\n"
                            + "MySQL Version: " + testConn.ServerVersion;
                    }
                    testConn.Close();

                }
                else
                {
                    SqlConnection testConn = new SqlConnection(connString);
                    testConn.Open();
                    if (testConn.State == System.Data.ConnectionState.Open)
                    {
                        ErrorBox.Text = "Test Successful \r\n"
                            + "SQL Version: " + testConn.ServerVersion;
                    }
                    testConn.Close();
                }
                next.Enabled = true;
                NeedTestLabel.Visible = false;
            }
            catch (Exception ex)
            {
                ErrorBox.Text = ex.Message;
                next.Enabled = false;
                NeedTestLabel.Visible = true;
            }
        }

        private void customButton_Click(object sender, EventArgs e)
        {
            GuidedPanel.Visible = !GuidedPanel.Visible;
            CustomPanel.Visible = !CustomPanel.Visible;
        }
    }
}