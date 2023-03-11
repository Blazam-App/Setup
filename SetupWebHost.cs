using Microsoft.Deployment.WindowsInstaller;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using WixSharp;
using WixSharpSetup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Setup
{
    public static class SetupWebHost
    {
        
       
        public static Session Session;
        [CustomAction]
        public static ActionResult Setup(Session session)
        {
            session.Log("Installtion type=" + session["INSTALL_TYPE"]);
            session.Log("Installtion path=" + session["INSTALLDIR"]);
            string createSiteCommand = "New-IISSite -Name \"Blazam\" -BindingInformation \"*:"+IISSettingsDialog.HTTPPort+":\" -PhysicalPath \""+ session["WixSharp_UI_INSTALLDIR"] + "\"";
            if (MessageBox.Show(createSiteCommand, "IIS Site creation") == DialogResult.OK)
            {
                var proc = Process.Start("powershell", createSiteCommand);
                var reesult = proc.WaitForExit(5000);
                return ActionResult.Success;
            }
                return ActionResult.Failure;


        }

    }
}
