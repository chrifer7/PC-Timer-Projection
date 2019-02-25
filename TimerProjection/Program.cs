using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TPView;
using System.Threading;

namespace TimerProjection {
    static class Program {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmProjectionPanel frmProjectionPanel = new FrmProjectionPanel();
            FrmControlPanel frmControlPanel = new FrmControlPanel(frmProjectionPanel);

            TPView.Timer tpTimer = new TPView.Timer(frmProjectionPanel);
            //Thread thrTimer = new Thread(new ThreadStart(tpTimer.StartTimer));
            //thrTimer.Name = "Thread Timer";
            //tpTimer.ThrTimer = thrTimer;
            frmProjectionPanel.TpTimer = tpTimer;
            tpTimer.FrmControlPanel = frmControlPanel;
            //thrTimer.Start();
            
            Application.Run(frmControlPanel);
        }
    }
}
