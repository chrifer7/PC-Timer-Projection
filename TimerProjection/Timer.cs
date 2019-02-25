using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TPView {
    public class Timer {
        int remainingTime = 0;
        public static int deltaTime = 1000; // in milliseconds
        public static int limitTime = -100000; // in seconds

        private FrmProjectionPanel frmProjectionPanel;

        public Timer(FrmProjectionPanel frmProjectionPanel) {            
            this.frmProjectionPanel = frmProjectionPanel;
        }

        public void StartTimer() {
            int hours = 0, minutes = 0, seconds = 0;
            //MessageBox.Show("Hilo: " + ThrTimer.Name);

            while (remainingTime > limitTime) {
                hours = (Math.Abs(remainingTime) / (60 * 60));
                minutes = (Math.Abs(remainingTime) % (60 * 60)) / (60);
                seconds = ((Math.Abs(remainingTime) % (60 * 60)) % (60));
                frmProjectionPanel.ProjectionText("" +
                    (remainingTime < 0 ? "-" : "") +
                    (hours > 0 ? (hours < 10 ? ("0" + hours) : "" + hours) + ":" : "" ) +
                    (minutes < 10 ? ("0" + minutes) : "" + minutes) + ":" +
                    (seconds < 10 ? ("0" + seconds) : "" + seconds)
                );
                //Console.WriteLine(remainingTime);

                try {
                    Thread.Sleep(deltaTime);
                }
                catch (Exception) {
                }

                if (remainingTime <= frmProjectionPanel.CriticalTime)
                    frmProjectionPanel.InverseColors();

                remainingTime -= 1;
            }

            //this.frmProjectionPanel.Visible = false;
            //ThrTimer.Interrupt();
            StopTimer();
        }

        public void StartThread(){
            //StopTimer();

            Thread thrTimer = new Thread(new ThreadStart(StartTimer));
            thrTimer.Name = "Thread Timer "+new DateTime();
            ThrTimer = thrTimer;

            try {
                thrTimer.Start();
            }
            catch (Exception e) {
                //MessageBox.Show("Error en el hilo");
            }
        }

        public void StopTimer() {            
            if (ThrTimer != null) {
                remainingTime = limitTime;
                ThrTimer.Interrupt();                
            }
            this.frmProjectionPanel.SetVisible(false);
            this.FrmControlPanel.EnableBtnIniciar();
        }

        public int RemainingTime {
            get { return remainingTime; }
            set { remainingTime = value; }
        }

        public Thread ThrTimer { get; set; }

        public FrmControlPanel FrmControlPanel { get; set; }
    }
}
