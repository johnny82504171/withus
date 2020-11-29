using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Withus
{
    public interface IMainView
    {      
       enum MDIType
        {
            SystemMessage
        }
        event EventHandler SystemMessage_Open;
        event EventHandler ProcessKill;        

        void MessageApender(string message); 
    }
}
