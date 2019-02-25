using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;
using Microsoft.Win32;
using System.IO;
using System.Security.Cryptography;
using System.Reflection;

namespace GameKitty
{
    static class Program
    {
        /* VERSION PROPERTIES */
        /* DO NOT LEAVE THEM EMPTY */

        // Enter current version here
        internal readonly static float Major = 1;
        internal readonly static float Minor = 0;

        internal static string GetCurrentVersionTostring()
        {
            return Major.ToString() + "." + Minor.ToString();
        }

        internal static float GetCurrentVersion()
        {
            return float.Parse(GetCurrentVersionTostring());
        }

        /* END OF VERSION PROPERTIES */

        internal static MainForm MainForm;

        readonly static string _adminMissingMessage = "GameKitty needs to be run as administrator!";
        readonly static string _unsupportedMessage = "GameKitty works on Windows 10(maybe 7 and 8.1)!";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!Utilities.IsAdmin())
            {
                HelperForm f = new HelperForm(null, MessageType.Error, _adminMissingMessage);
                f.ShowDialog();

                Application.Exit();
            }
            else
            {
                if (Utilities.IsCompatible())
                {
                    string resource = "GameKitty.Newtonsoft.Json.dll";
                    EmbeddedAssembly.Load(resource, "Newtonsoft.Json.dll");
                    AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);

                    if (!Directory.Exists(Required.CoreFolder))
                    {
                        Required.Deploy();
                    }

                    // for backward compatibility
                    if (File.Exists(Options.SettingsFile))
                    {
                        if (File.ReadAllText(Options.SettingsFile).Contains("FirstRun"))
                        {
                            File.Delete(Options.SettingsFile);
                        }
                    }

                    // load settings, if there is no settings, load defaults
                    Options.LoadSettings();

                    Application.Run(new MainForm());
                }
                else
                {
                    HelperForm f = new HelperForm(null, MessageType.Error, _unsupportedMessage);
                    f.ShowDialog();

                    Application.Exit();
                }
            }            
        }

        static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            return EmbeddedAssembly.Get(args.Name);
        }
    }
}
