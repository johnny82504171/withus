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
        public SystemConsole() => InitializeComponent();            

        public event EventHandler SystemConsole_Close;
        private void SystemConsole_FormClosing(object sender, FormClosingEventArgs e) => SystemConsole_Close.Invoke(sender, new EventArgs());
    }
}
