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
        public event EventHandler ProcessKill;
        public event EventHandler SystemMessage_Open;

        public MainForm()
        {
            InitializeComponent();
            this.menuStrip_Main.AllowMerge = false;
        }

        #region Controls Events               
        private void menuItem_ProcessKill_Click(object sender, EventArgs e) => ProcessKill.Invoke(this, new EventArgs());        
        private void menuItem_SystemMessage_Click(object sender, EventArgs e) => SystemMessage_Open.Invoke(sender, new EventArgs());
        #endregion


    }
}
