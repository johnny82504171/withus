using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Withus.Controllers;
using Withus.Forms;
using Withus.Views;

namespace Withus
{
    class MainController
    {
        IMainView mainView { get; set; }

        SystemConsole systemConsole;

        public MainController(IMainView mainView)
        {
            this.mainView = mainView;                        
            mainView.ProcessKill += ProcessKill;
            SystemConsole_Load();
        }

        private void SystemConsole_Load()
        {
            systemConsole = new SystemConsole();
            new SystemConsoleController(systemConsole);
            systemConsole.MdiParent = (MainForm)this.mainView;
            systemConsole.Show();
        }

        private void ProcessKill(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
