﻿using Microsoft.Deployment.WindowsInstaller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Forms;
using WixSharp;
using WixSharp.Bootstrapper;
using WixSharp.CommonTasks;
using WixSharp.UI.WPF;

namespace Setup
{
    internal class Program
    {
        private const string SourcePath = @"..\BLAZAM\BLAZAM\bin\Release\net6.0\publish\";
        public static string DestinationPath = @"%ProgramFiles%\Blazam Server\";
        public static File service;

        static void Main()
        {
            //_ = AspNetCore6();

            var msi = BuildMsi();

            /*
            var bootstrapper =
                              new Bundle("SampleInstaller",
                              AspNetCore6(),
                                  new MsiPackage(msi) { DisplayInternalUI = true, Compressed = true })
                              {
                                  UpgradeCode = new Guid("c14f14eb-6a0a-4969-a94e-3d2aa19b3ec4"),
                                  Version = new Version(1, 0, 0, 0),
                              };
            bootstrapper.IncludeWixExtension(WixExtension.Util);
            bootstrapper.AddWixFragment("Wix/Bundle",
                new UtilRegistrySearch
                {
                    Root = WixSharp.RegistryHive.LocalMachine,
                    Key = @"SOFTWARE\WOW6432Node\Microsoft\Updates\.NET\Microsoft .NET *",
                    Value = "PackageVersion",
                    Variable = "NetVersion"
                    

                });
            bootstrapper.Build("Install.exe");
            */
        }

        private static string BuildMsi()
        {

            var project = new ManagedProject("BLAZAM",
                              new ManagedAction(
                                      SetupWebHost.Setup,
                                      Return.check,
                                      When.Before,
                                      Step.InstallInitialize,
                                      Condition.NOT_Installed),
                              new ManagedAction(
                                      ApplyAppSettingsAction.Apply,
                                      Return.check,
                                      When.After,
                                      Step.InstallFinalize, 
                                      Condition.NOT_Installed),
                              new Dir(DestinationPath,
                                  new Files(SourcePath + "*"),
                                  service = new File(SourcePath + "blazam.exe")));
            project.ManagedUI = ManagedUI.Default;
            project.ControlPanelInfo.NoModify = true;
            project.ControlPanelInfo.Manufacturer = "BlazamApp";
            project.ControlPanelInfo.Name = "Blazam";
            project.InstallPrivileges = InstallPrivileges.elevated;
            project.InstallScope = InstallScope.perMachine;
            project.LicenceFile = SourcePath + "license.rtf";
            project.GUID = new Guid("6fe30b47-2577-43ad-9095-1861ba25889b");
            project.UpgradeCode = Guid.NewGuid();
            project.ProductId = new Guid("6fe30b47-2577-43ad-9095-1861ba25889b");
            project.EnableUninstallFullUI();
            // project.GenerateProductGuids();

            service.ServiceInstaller = new ServiceInstaller
            {
                Name = "Blazam Server",
                Account = ".\\LOCAL_SERVICE",
                StartOn = SvcEvent.Install,
                StopOn = SvcEvent.InstallUninstall_Wait,
                RemoveOn = SvcEvent.Uninstall_Wait
            };

            // project.ManagedUI = ManagedUI.DefaultWpf; // all stock UI dialogs

            //custom set of UI WPF dialogs
            project.ManagedUI = new ManagedUI();

            project.ManagedUI.InstallDialogs.Add<Setup.WelcomeDialog>()
                                            .Add<Setup.LicenceDialog>()
                                            .Add<WixSharpSetup.InstallationType>()
                                            .Add<WixSharpSetup.NetCoreDialog>()
                                            .Add<WixSharpSetup.ServiceSettings>()
                                            .Add<WixSharpSetup.AspHostingDialog>()
                                            .Add<WixSharpSetup.IISSettingsDialog>()

                                            .Add<Setup.InstallDirDialog>()
                                          .Add<WixSharpSetup.DatabaseTypeDialog>()
                                            .Add<WixSharpSetup.DatabaseDialog>()
                                            .Add<WixSharpSetup.DatabaseFilePathDialog>()
                                            .Add<WixSharpSetup.ConfirmInstallDialog>()
                                            .Add<Setup.ProgressDialog>()
                                            .Add<Setup.ExitDialog>();

            project.ManagedUI.ModifyDialogs.Add<Setup.MaintenanceTypeDialog>()
                                           .Add<Setup.FeaturesDialog>()
                                           .Add<Setup.ProgressDialog>()
                                           .Add<Setup.ExitDialog>();

            //project.SourceBaseDir = "<input dir path>";
            //project.OutDir = "<output dir path>";



            return project.BuildMsi();
        }

      
    }
}