using System;
using System.Diagnostics;
using WixSharp;
using WixSharp.UI.Forms;

namespace WixSharpSetup
{
    public partial class DatabaseTypeDialog : ManagedForm, IManagedDialog
    {
        private const string DATABASE_TYPE = "DATABASE_TYPE";
        public ManagedForm Host;
        ISession session => Host?.Runtime.Session;
        public DatabaseTypeDialog()
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
            //resolve all Control.Text cases with embedded MSI properties (e.g. 'ProductName') and *.wxl file entries
            if (session[DATABASE_TYPE] == null)
                session[DATABASE_TYPE] = "SQLite";
            switch (session[DATABASE_TYPE])
            {
                case "SQLite":
                    sqliteRadioButton.Checked = true;
                    break;
                case "SQL":
                    sqlRadioButton.Checked = true;

                    break;

                case "MYSQL":
                    mysqlRadioButton.Checked = true;
                    break;

            }

            base.Localize();
        }

        void back_Click(object sender, EventArgs e)
        {
            Shell.GoPrev();
        }

        void next_Click(object sender, EventArgs e)
        {
            switch (session[DATABASE_TYPE])
            {
                case "SQLite":
                    Shell.GoTo<DatabaseFilePathDialog>();
                    break;
                case "SQL":
                case "MYSQL":
                    Shell.GoTo<DatabaseDialog>();


                    break;

            }
        }

        void cancel_Click(object sender, EventArgs e)
        {
            Shell.Cancel();
        }


        private void sqliteRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            session[DATABASE_TYPE] = "SQLite";

        }

        private void sqlRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            session[DATABASE_TYPE] = "SQL";

        }

        private void mysqlRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            session[DATABASE_TYPE] = "MYSQL";
        }
    }
}