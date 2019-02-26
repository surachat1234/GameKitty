using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace GameKitty
{
    public partial class ContentDefragment : Form
    {
        private Process tmpProcess;

        private readonly string arguments = "workingsets|modifiedpagelist|standbylist|priority0standbylist";
        private readonly string tmpPath = Path.Combine(Path.GetTempPath(), "ramfree.exe");

        public ContentDefragment()
        {
            InitializeComponent();
            Options.ApplyTheme(this);
        }

        private void button_CloseGameKitty_Click(object sender, EventArgs e)
        {
            Options.SaveSettings();
            this.Close();
        }

        private void button_RamFree_Click(object sender, EventArgs e)
        {
            //Write embedded executable to temporary path
            File.WriteAllBytes(tmpPath, Properties.Resources.EmptyStandbyList);
            
            if (File.Exists(tmpPath))
            {
                using (tmpProcess = new Process())
                {
                    try
                    {
                        tmpProcess.StartInfo.FileName = tmpPath;
                        tmpProcess.StartInfo.Arguments = arguments;

                        tmpProcess.StartInfo.CreateNoWindow = true;
                        tmpProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                        tmpProcess.Start();

                        //Disable button for blocking multiple use
                        button_RamFree.Enabled = false;

                        tmpProcess.WaitForExit(2000);
                        Thread.Sleep(2000);

                        //Delete temporary executable and enable button after event end
                        if (tmpProcess.HasExited)
                        {
                            button_RamFree.Enabled = true;

                            if (File.Exists(tmpPath))
                            {
                                File.Delete(tmpPath);
                            }

                            Message.CreateMessage("RAM defragment success!");

                            this.Focus();
                        }
                    }
                    catch(Exception ex)
                    {
                        Message.CreateMessage("Failed to execute RAM defragment.");
                        return;
                    }
                }
            }
            else
            {
                Message.CreateMessage("Failed to write temporary executable for RAM defragment.");
            }
        }
    }
}
