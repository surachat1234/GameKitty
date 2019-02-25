using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameKitty
{
    public class Message
    {
        public static void CreateMessage(string message)
        {
            MessageBox.Show(message, "GameKitty Error");
        }
    }
}
