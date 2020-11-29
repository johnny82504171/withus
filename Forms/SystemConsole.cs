using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Withus.Views;

namespace Withus.Forms
{
    public partial class SystemConsole : Form, ISystemConsoleView
    {
        public event EventHandler SystemConsole_Load;
        public event EventHandler SystemConsole_Tray;

        public SystemConsole() => InitializeComponent();        

        private void menuItem_SystemConsole_Tray_Click(object sender, EventArgs e) => SystemConsole_Tray.Invoke(sender, new EventArgs());

        private void SystemConsole_Load_Event(object sender, EventArgs e) => SystemConsole_Load.Invoke(sender, new EventArgs());
    }
}
