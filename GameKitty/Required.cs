﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GameKitty
{
    internal static class Required
    {
        internal readonly static string CoreFolder = CleanHelper.ProgramData + "\\GameKitty\\";
        internal readonly static string ReadyMadeMenusFolder = CleanHelper.ProgramData + "\\GameKitty\\ReadyMadeMenus\\";
        internal readonly static string ScriptsFolder = CleanHelper.ProgramData + "\\GameKitty\\Required\\";
        internal readonly static string ExtractedIconsFolder = CleanHelper.ProgramData + "\\GameKitty\\ExtractedIcons\\";
        internal readonly static string FavIconsFolder = CleanHelper.ProgramData + "\\GameKitty\\FavIcons\\";

        internal static void Deploy()
        {
            if (!Directory.Exists(CoreFolder))
            {
                Directory.CreateDirectory(CoreFolder);
            }
            if (!Directory.Exists(ReadyMadeMenusFolder))
            {
                Directory.CreateDirectory(ReadyMadeMenusFolder);
            }
            if (!Directory.Exists(ScriptsFolder))
            {
                Directory.CreateDirectory(ScriptsFolder);
            }
            if (!Directory.Exists(ExtractedIconsFolder))
            {
                Directory.CreateDirectory(ExtractedIconsFolder);
            }
            if (!Directory.Exists(FavIconsFolder))
            {
                Directory.CreateDirectory(FavIconsFolder);
            }

            try
            {
                File.WriteAllText(ReadyMadeMenusFolder + "DesktopShortcuts.reg", Properties.Resources.DesktopShortcuts);
            }
            catch { }
            try
            {
                File.WriteAllText(ReadyMadeMenusFolder + "SystemShortcuts.reg", Properties.Resources.SystemShortcuts);
            }
            catch { }
            try
            {
                File.WriteAllText(ReadyMadeMenusFolder + "PowerMenu.reg", Properties.Resources.PowerMenu);
            }
            catch { }
            try
            {
                File.WriteAllText(ReadyMadeMenusFolder + "SystemTools.reg", Properties.Resources.SystemTools);
            }
            catch { }
            try
            {
                File.WriteAllText(ReadyMadeMenusFolder + "WindowsApps.reg", Properties.Resources.WindowsApps);
            }
            catch { }

            try
            {
                File.WriteAllText(ScriptsFolder + "DisableOfficeTelemetryTasks.bat", Properties.Resources.DisableOfficeTelemetryTasks);
            }
            catch { }
            try
            {
                File.WriteAllText(ScriptsFolder + "DisableOfficeTelemetryTasks.reg", Properties.Resources.DisableOfficeTelemetry);
            }
            catch { }
            try
            {
                File.WriteAllText(ScriptsFolder + "EnableOfficeTelemetryTasks.bat", Properties.Resources.EnableOfficeTelemetryTasks);
            }
            catch { }
            try
            {
                File.WriteAllText(ScriptsFolder + "EnableOfficeTelemetryTasks.reg", Properties.Resources.EnableOfficeTelemetry);
            }
            catch { }
            try
            {
                File.WriteAllText(ScriptsFolder + "DisableTelemetryTasks.bat", Properties.Resources.DisableTelemetryTasks);
            }
            catch { }
            try
            {
                File.WriteAllText(ScriptsFolder + "EnableTelemetryTasks.bat", Properties.Resources.EnableTelemetryTasks);
            }
            catch { }
            try
            {
                File.WriteAllText(ScriptsFolder + "DisableXboxTasks.bat", Properties.Resources.DisableXboxTasks);
            }
            catch { }
            try
            {
                File.WriteAllText(ScriptsFolder + "EnableXboxTasks.bat", Properties.Resources.EnableXboxTasks);
            }
            catch { }
            try
            {
                File.WriteAllText(ScriptsFolder + "OneDrive_Uninstaller.bat", Properties.Resources.OneDrive_Uninstaller);
            }
            catch { }
            try
            {
                File.WriteAllText(ReadyMadeMenusFolder + "InstallTakeOwnership.reg", Properties.Resources.InstallTakeOwnership);
            }
            catch { }
            try
            {
                File.WriteAllText(ReadyMadeMenusFolder + "RemoveTakeOwnership.reg", Properties.Resources.RemoveTakeOwnership);
            }
            catch { }
        }

        internal static void Clean()
        {
            CleanHelper.EmptyFolder(CoreFolder);
        }
    }
}
