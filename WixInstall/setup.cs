using System;
using WixSharp;

public class Script
{
    static public void Main(string[] args)
    {

        const string manufacturer = "Darron Haworth";
        const string prodBaseName = "Personal Security Toolbox";
        const string prodName = "SecurityToolbox";
        string buildConfiguration = "Release";

#if DEBUG
        buildConfiguration = "Debug";
#endif

         string msiFileName =  prodName;

        Project project =
           new Project(prodName,
               new Dir(@"%ProgramFiles64Folder%\RDH\SecurityToolbox",
                   new Files(String.Format(@"..\SecurityToolbox\Bin\{0}\*.dll", buildConfiguration)),
       new File(String.Format(@"..\SecurityToolbox\bin\{0}\SecurityToolbox.exe", buildConfiguration),
                       new FileShortcut(prodBaseName, @"%DesktopFolder%") { Advertise = true, IconFile = "RDH.ico" }))
                   );

        //Injects CLR dialog EmptyDialog between MSI dialogs InsallDirDlg and VerifyReadyDlg.
        //Passes custom action ShowCustomDialog for instantiating and popping up the CLR dialog.
        //project.InjectClrDialog("ShowCustomDialog", Dialogs.InstallDirDlg, Dialogs.VerifyReadyDlg);
        project.MajorUpgradeStrategy = MajorUpgradeStrategy.Default;
        project.Version = new Version("1.2.0.0");
        project.InstallScope = InstallScope.perMachine;
        project.Platform = Platform.x64;
        project.OutDir = @"MSI-Output";
        project.GUID = new Guid("d585bc49-de75-4d36-9515-ed3c1adee8fb");
        project.ResolveWildCards();
        project.ControlPanelInfo.ProductIcon = "RDH.ico";
        project.ControlPanelInfo.Manufacturer = manufacturer;
        project.ControlPanelInfo.Comments = prodBaseName + " Security Client";
        project.OutFileName = msiFileName;

        Compiler.BuildMsi(project);
    }
}



