using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using Withus.Controllers;
using Withus.Forms;
using Withus.Views;

namespace Withus
{
    public partial class MainForm : Form, IMainView
    {
        public MainForm() => InitializeComponent();

        public void CreateMDIs(IMainView.MDIType type)
        {
            if (type == IMainView.MDIType.SystemMessage)
            {
                SystemConsole systemConsole = new SystemConsole();
                new SystemConsoleController(this,systemConsole);
                systemConsole.MdiParent = this;
                systemConsole.Show();
            }
        }

        public void MessageApender(string message) => MessageBox.Show($"{message}");              

        #region Controls Events
        
        
        public event EventHandler ProcessKill;
        //1. UI 메뉴 중 "프로그램 종료" 클릭 시 => 해당 델리게이트에게 던져줌 근대 어뜨케!
        private void menuItem_ProcessKill_Click(object sender, EventArgs e) => ProcessKill.Invoke(this, new EventArgs());


        public event EventHandler SystemMessage_Open;
        private void menuItem_SystemMessage_Click(object sender, EventArgs e) => SystemMessage_Open.Invoke(sender, new EventArgs());
        #endregion


    }
}
