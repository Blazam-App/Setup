using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using WixSharp;
using WixSharp.UI.Forms;

namespace WixSharpSetup
{
    public partial class IISSettingsDialog : ManagedForm, IManagedDialog
    {
        public static X509Certificate2 SSLCert { get; private set; }
        public static int HTTPPort { get; private set; } = 8080;
        public static int HTTPSPort { get; private set; } = 443;

        public IISSettingsDialog()
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
            httpsPanel.Enabled = false;

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var store = new X509Store("MY", System.Security.Cryptography.X509Certificates.StoreLocation.LocalMachine);
                store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);
                var collection = store.Certificates;
                var certs = X509Certificate2UI.SelectFromCollection(collection, "Select", "Select a certificate to sign", X509SelectionFlag.SingleSelection);
                if (certs.Count > 0)
                {
                    SSLCert = certs[0];

                    sslCertLabel.Text = SSLCert.FriendlyName;
                    httpsPanel.Enabled = true;
                }
            }
            catch(Exception ex) 
            {
                sslCertLabel.Text = ex.Message;
            }
        }

        private void httpPortInput_ValueChanged(object sender, EventArgs e)
        {
            HTTPPort = (int)httpPortInput.Value;
        }

        private void httpsPortInput_ValueChanged(object sender, EventArgs e)
        {
            HTTPSPort = (int)httpsPortInput.Value;

        }
    }
}