using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Threading;

namespace TPView {
    public partial class FrmControlPanel : Form {
        //private FrmProjectionPanel frmProjectionPanel;
        delegate void EnableBtnIniciarCallback();

        Point FrmProjPanelLocation = new Point(0,0);

        FontDialog fontActivityDlg = new FontDialog();
        FontDialog fontTimerDlg = new FontDialog();
        ColorDialog backColorDlg = new ColorDialog();
        ColorDialog fontColorDlg = new ColorDialog();

        public FrmControlPanel(FrmProjectionPanel frmProjectionPanel) {
            InitializeComponent();

            //Screen[] screens = Screen.AllScreens;
            cbxPantalla.DataSource = Screen.AllScreens;
            //cbxPantalla.ValueMember = "au_id";
            cbxPantalla.DisplayMember = "DeviceName";
            cbxPantalla.SelectedIndex = 0;

            this.FrmProjectionPanel = frmProjectionPanel;
            //this.FrmProjectionPanel.Owner = this;

            fontActivityDlg.Font = this.FrmProjectionPanel.drawFontActivity;
            fontTimerDlg.Font = this.FrmProjectionPanel.drawFontTimer; 
            backColorDlg.Color = FrmProjectionPanel.DefaultBackColor;
            fontColorDlg.Color = FrmProjectionPanel.DefaultFontColor;
        }

        private void btnIniciar_Click(object sender, EventArgs e) {
            if (this.txtActivity.Text.Length <= 0) {
                MessageBox.Show("Debe escribir una actividad", "Timer Projection",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.FrmProjectionPanel.ProjectionText(this.txtActivity.Text);
            this.FrmProjectionPanel.StopTimer();
            this.FrmProjectionPanel.ActivityName = txtActivity.Text;            
            this.FrmProjectionPanel.RemainingTime = (int)nudDurationHours.Value * 60 * 60 + 
                                                    (int)nudDurationMinutes.Value * 60 + 
                                                    (int)nudDurationSeconds.Value;
            this.FrmProjectionPanel.CriticalTime = (int)nudCriticalTime.Value;
            nudCriticalTime.Value = this.FrmProjectionPanel.CriticalTime;
            this.FrmProjectionPanel.StartTimer();

            this.FrmProjectionPanel.Location = FrmProjPanelLocation;
            this.FrmProjectionPanel.ClientSize = new Size(Screen.AllScreens[cbxPantalla.SelectedIndex].Bounds.Width, Screen.AllScreens[cbxPantalla.SelectedIndex].Bounds.Height);
            //this.FrmProjectionPanel.Size = new Size(Screen.AllScreens[cbxPantalla.SelectedIndex].WorkingArea.Width, Screen.AllScreens[cbxPantalla.SelectedIndex].WorkingArea.Height);
            this.FrmProjectionPanel.TopMost = true;
            this.FrmProjectionPanel.Show();            
            //this.FrmProjectionPanel.Visible = true;

            //this.Text = "" + FrmProjPanelLocation + " - " + (FrmProjectionPanel != null ? "" + FrmProjectionPanel.Location : "");

            this.btnIniciar.Enabled = false;
            this.cbxPantalla.Enabled = false;
        }

        public void EnableBtnIniciar() {
            if (this.btnIniciar.InvokeRequired) {
                EnableBtnIniciarCallback d = new EnableBtnIniciarCallback(EnableBtnIniciar);
                try {
                    this.Invoke(d, new object[] { });
                }
                catch (Exception e) {
                }
            }
            else {
                this.btnIniciar.Enabled = true;
                this.cbxPantalla.Enabled = true;
            }           
        }

        public FrmProjectionPanel FrmProjectionPanel { get; set; }

        private void btnStop_Click(object sender, EventArgs e) {
            this.FrmProjectionPanel.StopTimer();
            this.FrmProjectionPanel.Visible = false;
        }

        private void btnAbout_Click(object sender, EventArgs e) {
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.Owner = this;
            frmAbout.Visible = true;
        }

        private void btnBackgroundColor_Click(object sender, EventArgs e) {
            if (backColorDlg.ShowDialog() == DialogResult.OK) {                
                FrmProjectionPanel.DefaultBackgroundColor = backColorDlg.Color;
            }
        }

        private void btnColorTiempo_Click(object sender, EventArgs e) {
            if (fontColorDlg.ShowDialog() == DialogResult.OK) {
                FrmProjectionPanel.DefaultFontColor = fontColorDlg.Color;
            }
        }

        private void btnFontTiempo_Click(object sender, EventArgs e) {
            if (fontTimerDlg.ShowDialog() == DialogResult.OK) {
                this.FrmProjectionPanel.drawFontTimer = fontTimerDlg.Font;
            }
        }

        private void btnFontActividad_Click(object sender, EventArgs e) {
            if (fontActivityDlg.ShowDialog() == DialogResult.OK) {
                this.FrmProjectionPanel.drawFontActivity = fontActivityDlg.Font;
                //this.FrmProjectionPanel.currFontColor = fontDlg.Color;
            }
        }

        private void cbxPantalla_SelectedIndexChanged(object sender, EventArgs e) {
            if (this.FrmProjectionPanel != null) {
                FrmProjPanelLocation = Screen.AllScreens[cbxPantalla.SelectedIndex].WorkingArea.Location;
                FrmProjectionPanel.Location = FrmProjPanelLocation;
                //MessageBox.Show("Location " + FrmProjPanelLocation);
            }

            //this.Text = ""+FrmProjPanelLocation + " - " + (FrmProjectionPanel != null ? ""+FrmProjectionPanel.Location : "");
            //MessageBox.Show("Index " + cbxPantalla.SelectedIndex);            
        }

        

    }
}
