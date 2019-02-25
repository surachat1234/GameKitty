using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using System.Threading;
using System.Reflection;
using System.Diagnostics;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using System.Net;
using Newtonsoft.Json;

namespace GameKitty
{
    public class Network
    {
        //Used for program icon on MainForm
        public readonly static bool networkAvailable = true;

        public readonly static string _latestVersionLink = "https://github.com/LovelyEclair/GameKitty/blob/master/version.txt";
        public readonly static string _changelogLink = "https://github.com/LovelyEclair/GameKitty/blob/master/CHANGELOG.md";

        private static readonly string _noNewVersionMessage = "You already have the latest version!";
        private static readonly string _betaVersionMessage = "You are using an experimental version!";

        private static string NewVersionMessage(string latestVersion)
        {
            return string.Format("New version is available!\n\nLatest version: {0}\nCurrent version: {1}\n\nDo you want to update?", latestVersion, Program.GetCurrentVersionTostring());
        }

        private static string NewDownloadLink(string latestVersion)
        {
            return string.Format("https://github.com/LovelyEclair/GameKitty/releases/download/{0}/GameKitty-{0}.exe", latestVersion);
        }

        public static void CheckForUpdate()
        {
            WebClient client = new WebClient
            {
                Encoding = Encoding.UTF8
            };

            string latestVersion = string.Empty;
            try
            {
                latestVersion = client.DownloadString(_latestVersionLink);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (!string.IsNullOrEmpty(latestVersion))
            {
                if (float.Parse(latestVersion) > Program.GetCurrentVersion())
                {
                    if (MessageBox.Show(NewVersionMessage(latestVersion), "Update available", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            Assembly currentAssembly = Assembly.GetEntryAssembly();

                            if (currentAssembly == null)
                            {
                                currentAssembly = Assembly.GetCallingAssembly();
                            }

                            string appFolder = Path.GetDirectoryName(currentAssembly.Location);
                            string appName = Path.GetFileNameWithoutExtension(currentAssembly.Location);
                            string appExtension = Path.GetExtension(currentAssembly.Location);

                            string archiveFile = Path.Combine(appFolder, appName + "_old" + appExtension);
                            string appFile = Path.Combine(appFolder, appName + appExtension);
                            string tempFile = Path.Combine(appFolder, appName + "_tmp" + appExtension);

                            // DOWNLOAD NEW VERSION
                            client.DownloadFile(NewDownloadLink(latestVersion), tempFile);

                            // DELETE PREVIOUS BACK-UP
                            if (File.Exists(archiveFile))
                            {
                                File.Delete(archiveFile);
                            }

                            // MAKE BACK-UP
                            File.Move(appFile, archiveFile);

                            // PATCH
                            File.Move(tempFile, appFile);

                            Application.Restart();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else if (float.Parse(latestVersion) == Program.GetCurrentVersion())
                {
                    MessageBox.Show(_noNewVersionMessage, "No update available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(_betaVersionMessage, "No update available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
