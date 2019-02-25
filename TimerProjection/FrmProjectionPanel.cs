using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace TPView {
    public partial class FrmProjectionPanel : Form {
        public static Color DefaultFontColor = Color.White;
        public static Color DefaultBackgroundColor = Color.Black;
        public Color currFontColor;
        public Color currBackColor;

        public Font drawFontTimer;
        public Font drawFontActivity;
        private SolidBrush drawBrush;
        private StringFormat stringFormat1;
        private StringFormat stringFormat2;        

        private String msg;
        private String activityName;

        private Timer tpTimer;
        private int criticalTime;

        delegate void SetVisibleCallback(bool value);

        public FrmProjectionPanel() {
            InitializeComponent();

            stringFormat1 = new StringFormat();
            stringFormat1.Alignment = StringAlignment.Center;
            stringFormat1.LineAlignment = StringAlignment.Center;

            stringFormat2 = new StringFormat();
            stringFormat2.Alignment = StringAlignment.Center;
            stringFormat2.LineAlignment = StringAlignment.Far;

            FormBorderStyle = FormBorderStyle.None;
            //WindowState = FormWindowState.Maximized;

            currFontColor = DefaultFontColor;
            currBackColor = DefaultBackgroundColor;
            
            drawFontTimer = new Font("Arial", 180);
            drawFontActivity = new Font("Arial", 40);
            drawBrush = new SolidBrush(currFontColor);
            
            this.msg = "";
            this.Paint += new PaintEventHandler(this.PaintProjection);
        }

        public void PaintProjection(object sender, PaintEventArgs e) {
            this.BackColor = this.currBackColor;
            this.drawBrush.Color = this.currFontColor;

            Rectangle rect1 = new Rectangle(5, 5, this.Width - 5, this.Height - 5);

            Graphics g = e.Graphics;
            //g.DrawString(msg, drawFont, drawBrush, 10, 40);
            g.DrawString(msg, drawFontTimer, drawBrush, rect1, stringFormat1);
            g.DrawString(ActivityName, drawFontActivity, drawBrush, rect1, stringFormat2);            
        }

        public void ProjectionText(String msg) {
            this.msg = msg;
            Invalidate();
        }
                
        public TPView.Timer TpTimer {
            get { return tpTimer; }
            set { tpTimer = value; }
        }
        
        public int RemainingTime {
            get { return tpTimer.RemainingTime; }
            set { tpTimer.RemainingTime = value; }
        }

        public String ActivityName {
            get { return activityName; }
            set { activityName = value; }
        }

        internal void StopTimer() {
            if (TpTimer.ThrTimer != null && TpTimer.ThrTimer.IsAlive) {
                TpTimer.RemainingTime = 0;
                TpTimer.StopTimer();
            }            
            this.Visible = false;            
        }

        public void SetVisible(bool value){
            if (this.InvokeRequired) {
                SetVisibleCallback d = new SetVisibleCallback(SetVisible);
                try {
                    this.Invoke(d, new object[] { value });
                }
                catch (Exception e) {
                }
            }
            else {
                this.Visible = value;
            }            
        }
        
        private void FrmProjectionPanel_KeyDown(object sender, KeyEventArgs e) {
            //MessageBox.Show("Evento FrmProjectionPanel_KeyDown");
            //ProjectionText("PP Key down: " + e.KeyCode);
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
                StopTimer();
        }

        private void FrmProjectionPanel_MouseDoubleClick(object sender, MouseEventArgs e) {
            //WindowState = FormWindowState.Minimized;
            StopTimer();
        }
        
        public void StartTimer() {
            currBackColor = DefaultBackgroundColor;
            currFontColor = DefaultFontColor;

            TpTimer.StartThread();            
        }

        public int CriticalTime {
            get { return criticalTime; }
            set { criticalTime = (value <= RemainingTime ? value : RemainingTime ); }
        }



        internal void InverseColors() {
            Color temp = currFontColor;
            currFontColor = currBackColor;
            currBackColor = temp;
        }
    }        

}
