using Caliburn.Micro;
using Microsoft.Deployment.WindowsInstaller;
using System;
using System.Diagnostics;
using WixSharp;
using WixSharp.UI.Forms;

namespace WixSharpSetup
{
    public partial class DatabaseFilePathDialog : ManagedForm, IManagedDialog
    {
        public ManagedForm Host;
        ISession session => Host?.Runtime.Session;
        public DatabaseFilePathDialog()
        {
            //NOTE: If this assembly is compiled for v4.0.30319 runtime, it may not be compatible with the MSI hosted CLR.
            //The incompatibility is particularly possible for the Embedded UI scenarios. 
            //The safest way to avoid the problem is to compile the assembly for v3.5 Target Framework.WixSharp Setup
            InitializeComponent();
        }

        void dialog_Load(object sender, EventArgs e)
        {
            Host = this;
            saveFileDialog1.AddExtension= true;
            saveFileDialog1.DefaultExt = ".db";
            saveFileDialog1.CreatePrompt = true;
            saveFileDialog1.CheckFileExists = false;
            saveFileDialog1.CheckPathExists = false;
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.Filter = "Sqlite database files| *.db";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Title = "Choose database path";
            
            saveFileDialog1.FileName = "database";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)+"\\Blazam";
            if (session.Property("DATABASE_TYPE") == "SQL")
            {
                Shell.GoTo<DatabaseDialog>();
            }

            banner.Image = Runtime.Session.GetResourceBitmap("WixUI_Bmp_Banner");
            Text = "[ProductName] Setup";

            //resolve all Control.Text cases with embedded MSI properties (e.g. 'ProductName') and *.wxl file entries
            base.Localize();
        }

        void back_Click(object sender, EventArgs e)
        {
            Shell.GoPrev();
        }

        void next_Click(object sender, EventArgs e)
        {
            Shell.GoNext();
        }

        void cancel_Click(object sender, EventArgs e)
        {
            Shell.Cancel();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                filePathTextBox.Text = saveFileDialog1.FileName;
            }
        }
    }
}