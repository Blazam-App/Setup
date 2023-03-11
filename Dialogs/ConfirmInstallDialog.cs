using Setup;
using System;
using System.Diagnostics;
using WixSharp;
using WixSharp.UI.Forms;

namespace WixSharpSetup
{
    public partial class ConfirmInstallDialog : ManagedForm, IManagedDialog
    {
        private ISession session;

        public ConfirmInstallDialog()
        {
            //NOTE: If this assembly is compiled for v4.0.30319 runtime, it may not be compatible with the MSI hosted CLR.
            //The incompatibility is particularly possible for the Embedded UI scenarios. 
            //The safest way to avoid the problem is to compile the assembly for v3.5 Target Framework.WixSharp Setup
            InitializeComponent();
        }

        void dialog_Load(object sender, EventArgs e)
        {
            banner.Image = Runtime.Session.GetResourceBitmap("WixUI_Bmp_Banner");
            Text = "[ProductName] Setup";
            session =Runtime.Session;
            installType.Text = session.Property("INSTALL_TYPE");
            databaseType.Text = session.Property("DATABASE_TYPE");
            installPath.Text = session.Property("WixSharp_UI_INSTALLDIR");
            //resolve all Control.Text cases with embedded MSI properties (e.g. 'ProductName') and *.wxl file entries
            base.Localize();
        }

        void back_Click(object sender, EventArgs e)
        {
            if (DatabaseDialog.Skipped)
                Shell.GoTo<Setup.InstallDirDialog>();
            else
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
    }
}