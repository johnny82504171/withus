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

        public MainController(IMainView mainView)
        {
            this.mainView = mainView;              
            mainView.SystemMessage_Open += Create_MDI;
            mainView.ProcessKill += ProcessKill;

            //테스트 코드
            Thread thread = new Thread(new ThreadStart(ThreadTest));
            thread.Start();

            /* 테스트코드를 보아하니..
             * 메인에서 메인폼의 객체를 만들고,
             * 메인에서 새로운 메인컨트롤러의 객체를 만들고 메인폼의 객체를 던져줬으니
             * 메인폼과 메인컨트롤러는 같은 곳을 바라보며 계속 대기 상태인 것인가?             
             */
        }
        private void ThreadTest()
        {
            while (true)
            {
                Console.WriteLine("111111111");
                Thread.Sleep(1500);
            }
        }

        private void ProcessKill(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void Create_MDI(object sender, EventArgs e)
        {
            MainForm parent = (MainForm)this.mainView;

            switch (((ToolStripMenuItem)sender).Name.Split('_')[1])
            {             
                case "SystemConsole":
                    parent.menuItem_SystemConsole.Enabled = false;
                    parent.CreateMDIs(IMainView.MDIType.SystemMessage);
                    break;
            }               
        }

        private void View_MessageBox(object sender, EventArgs e)
        {
            mainView.MessageApender("테스트");
        }
    }
}
