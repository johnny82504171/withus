using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Withus.Views;
using System.Windows.Forms;
using Withus.Forms;

namespace Withus.Controllers
{
    
    public class SystemConsoleController
    {
        MainForm mainForm;
        ISystemConsoleView systemConsoleView { get; set; }
        
        public SystemConsoleController(MainForm main, ISystemConsoleView systemConsoleView)
        {
            this.systemConsoleView = systemConsoleView;
            this.mainForm = main;
            systemConsoleView.SystemConsole_Close += SystemConsole_Close;
        }

        private void SystemConsole_Close(object sender, EventArgs e)
        {
            mainForm.menuItem_SystemConsole.Enabled = true;
        }
    }
}
