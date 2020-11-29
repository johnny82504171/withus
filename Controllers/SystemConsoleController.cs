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
        SystemConsole systemConsole;
        ISystemConsoleView systemConsoleView { get; set; }
        
        public SystemConsoleController(ISystemConsoleView systemConsoleView)
        {
            this.systemConsoleView = systemConsoleView;          
            systemConsole = (SystemConsole)this.systemConsoleView;            
            systemConsoleView.SystemConsole_Tray += SystemConsole_Tray;
            systemConsoleView.SystemConsole_Load += SystemConsole_Load;
        }        

        private void SystemConsole_Load(object sender, EventArgs e)
        {
            string strDateTime = DateTime.Now.ToString("yy.MM.dd HH:mm:ss");
            string message = "System Initialized";
            systemConsole.richTextBox_SystemConsole.AppendText($"[{strDateTime}] {message}\n");
            systemConsole.richTextBox_SystemConsole.ScrollToCaret();
        }
        private void SystemConsole_Tray(object sender, EventArgs e)
        {            
            systemConsole.WindowState = FormWindowState.Minimized;
        }
    }
}
