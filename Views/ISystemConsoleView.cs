using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Withus.Views
{
    public interface ISystemConsoleView
    {
        event EventHandler SystemConsole_Tray;
        event EventHandler SystemConsole_Load;
    }
}
