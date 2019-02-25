namespace TPView {
    partial class FrmControlPanel {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmControlPanel));
            this.lblActivity = new System.Windows.Forms.Label();
            this.txtActivity = new System.Windows.Forms.TextBox();
            this.lblDurationHours = new System.Windows.Forms.Label();
            this.nudDurationHours = new System.Windows.Forms.NumericUpDown();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.nudDurationMinutes = new System.Windows.Forms.NumericUpDown();
            this.lblDurationMinutes = new System.Windows.Forms.Label();
            this.nudDurationSeconds = new System.Windows.Forms.NumericUpDown();
            this.lblDurationSeconds = new System.Windows.Forms.Label();
            this.gbxTiming = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpPantalla = new System.Windows.Forms.GroupBox();
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.cbxPantalla = new System.Windows.Forms.ComboBox();
            this.grpFondo = new System.Windows.Forms.GroupBox();
            this.btnBackgroundColor = new System.Windows.Forms.Button();
            this.lblCriticalTime = new System.Windows.Forms.Label();
            this.nudCriticalTime = new System.Windows.Forms.NumericUpDown();
            this.lblCriticalTimeSecs = new System.Windows.Forms.Label();
            this.grpTiempo = new System.Windows.Forms.GroupBox();
            this.btnColorTiempo = new System.Windows.Forms.Button();
            this.btnFontActividad = new System.Windows.Forms.Button();
            this.btnFontTiempo = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurationHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurationMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurationSeconds)).BeginInit();
            this.gbxTiming.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpPantalla.SuspendLayout();
            this.grpFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCriticalTime)).BeginInit();
            this.grpTiempo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Location = new System.Drawing.Point(12, 15);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(65, 17);
            this.lblActivity.TabIndex = 0;
            this.lblActivity.Text = "Actividad";
            // 
            // txtActivity
            // 
            this.txtActivity.Location = new System.Drawing.Point(69, 12);
            this.txtActivity.MaxLength = 50;
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.Size = new System.Drawing.Size(349, 23);
            this.txtActivity.TabIndex = 1;
            this.txtActivity.Text = "Mi actividad";
            // 
            // lblDurationHours
            // 
            this.lblDurationHours.AutoSize = true;
            this.lblDurationHours.Location = new System.Drawing.Point(13, 22);
            this.lblDurationHours.Name = "lblDurationHours";
            this.lblDurationHours.Size = new System.Drawing.Size(46, 17);
            this.lblDurationHours.TabIndex = 2;
            this.lblDurationHours.Text = "Horas";
            // 
            // nudDurationHours
            // 
            this.nudDurationHours.Location = new System.Drawing.Point(54, 19);
            this.nudDurationHours.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudDurationHours.Name = "nudDurationHours";
            this.nudDurationHours.Size = new System.Drawing.Size(70, 23);
            this.nudDurationHours.TabIndex = 4;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(424, 12);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(171, 53);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // nudDurationMinutes
            // 
            this.nudDurationMinutes.Location = new System.Drawing.Point(180, 19);
            this.nudDurationMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudDurationMinutes.Name = "nudDurationMinutes";
            this.nudDurationMinutes.Size = new System.Drawing.Size(70, 23);
            this.nudDurationMinutes.TabIndex = 7;
            this.nudDurationMinutes.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblDurationMinutes
            // 
            this.lblDurationMinutes.AutoSize = true;
            this.lblDurationMinutes.Location = new System.Drawing.Point(130, 21);
            this.lblDurationMinutes.Name = "lblDurationMinutes";
            this.lblDurationMinutes.Size = new System.Drawing.Size(57, 17);
            this.lblDurationMinutes.TabIndex = 6;
            this.lblDurationMinutes.Text = "Minutos";
            // 
            // nudDurationSeconds
            // 
            this.nudDurationSeconds.Location = new System.Drawing.Point(317, 19);
            this.nudDurationSeconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudDurationSeconds.Name = "nudDurationSeconds";
            this.nudDurationSeconds.Size = new System.Drawing.Size(69, 23);
            this.nudDurationSeconds.TabIndex = 9;
            // 
            // lblDurationSeconds
            // 
            this.lblDurationSeconds.AutoSize = true;
            this.lblDurationSeconds.Location = new System.Drawing.Point(256, 21);
            this.lblDurationSeconds.Name = "lblDurationSeconds";
            this.lblDurationSeconds.Size = new System.Drawing.Size(72, 17);
            this.lblDurationSeconds.TabIndex = 8;
            this.lblDurationSeconds.Text = "Segundos";
            // 
            // gbxTiming
            // 
            this.gbxTiming.Controls.Add(this.lblDurationHours);
            this.gbxTiming.Controls.Add(this.nudDurationSeconds);
            this.gbxTiming.Controls.Add(this.nudDurationHours);
            this.gbxTiming.Controls.Add(this.lblDurationSeconds);
            this.gbxTiming.Controls.Add(this.lblDurationMinutes);
            this.gbxTiming.Controls.Add(this.nudDurationMinutes);
            this.gbxTiming.Location = new System.Drawing.Point(15, 38);
            this.gbxTiming.Name = "gbxTiming";
            this.gbxTiming.Size = new System.Drawing.Size(403, 57);
            this.gbxTiming.TabIndex = 10;
            this.gbxTiming.TabStop = false;
            this.gbxTiming.Text = "Tiempo asignado";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(425, 71);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(170, 23);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "Detener";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpPantalla);
            this.groupBox1.Controls.Add(this.grpFondo);
            this.groupBox1.Controls.Add(this.grpTiempo);
            this.groupBox1.Location = new System.Drawing.Point(15, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 207);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de proyección";
            // 
            // grpPantalla
            // 
            this.grpPantalla.Controls.Add(this.lblSeleccionar);
            this.grpPantalla.Controls.Add(this.cbxPantalla);
            this.grpPantalla.Location = new System.Drawing.Point(17, 19);
            this.grpPantalla.Name = "grpPantalla";
            this.grpPantalla.Size = new System.Drawing.Size(369, 54);
            this.grpPantalla.TabIndex = 15;
            this.grpPantalla.TabStop = false;
            this.grpPantalla.Text = "Pantalla";
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.AutoSize = true;
            this.lblSeleccionar.Location = new System.Drawing.Point(6, 22);
            this.lblSeleccionar.Name = "lblSeleccionar";
            this.lblSeleccionar.Size = new System.Drawing.Size(82, 17);
            this.lblSeleccionar.TabIndex = 15;
            this.lblSeleccionar.Text = "Seleccionar";
            // 
            // cbxPantalla
            // 
            this.cbxPantalla.FormattingEnabled = true;
            this.cbxPantalla.Location = new System.Drawing.Point(75, 19);
            this.cbxPantalla.Name = "cbxPantalla";
            this.cbxPantalla.Size = new System.Drawing.Size(205, 25);
            this.cbxPantalla.TabIndex = 0;
            this.cbxPantalla.SelectedIndexChanged += new System.EventHandler(this.cbxPantalla_SelectedIndexChanged);
            // 
            // grpFondo
            // 
            this.grpFondo.Controls.Add(this.btnBackgroundColor);
            this.grpFondo.Controls.Add(this.lblCriticalTime);
            this.grpFondo.Controls.Add(this.nudCriticalTime);
            this.grpFondo.Controls.Add(this.lblCriticalTimeSecs);
            this.grpFondo.Location = new System.Drawing.Point(17, 79);
            this.grpFondo.Name = "grpFondo";
            this.grpFondo.Size = new System.Drawing.Size(369, 54);
            this.grpFondo.TabIndex = 14;
            this.grpFondo.TabStop = false;
            this.grpFondo.Text = "Fondo";
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.Location = new System.Drawing.Point(6, 19);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new System.Drawing.Size(75, 23);
            this.btnBackgroundColor.TabIndex = 14;
            this.btnBackgroundColor.Text = "Color";
            this.btnBackgroundColor.UseVisualStyleBackColor = true;
            this.btnBackgroundColor.Click += new System.EventHandler(this.btnBackgroundColor_Click);
            // 
            // lblCriticalTime
            // 
            this.lblCriticalTime.AutoSize = true;
            this.lblCriticalTime.Location = new System.Drawing.Point(87, 24);
            this.lblCriticalTime.Name = "lblCriticalTime";
            this.lblCriticalTime.Size = new System.Drawing.Size(96, 17);
            this.lblCriticalTime.TabIndex = 0;
            this.lblCriticalTime.Text = "Tiempo crítico";
            // 
            // nudCriticalTime
            // 
            this.nudCriticalTime.Location = new System.Drawing.Point(168, 22);
            this.nudCriticalTime.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudCriticalTime.Name = "nudCriticalTime";
            this.nudCriticalTime.Size = new System.Drawing.Size(69, 23);
            this.nudCriticalTime.TabIndex = 10;
            this.nudCriticalTime.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // lblCriticalTimeSecs
            // 
            this.lblCriticalTimeSecs.AutoSize = true;
            this.lblCriticalTimeSecs.Location = new System.Drawing.Point(243, 24);
            this.lblCriticalTimeSecs.Name = "lblCriticalTimeSecs";
            this.lblCriticalTimeSecs.Size = new System.Drawing.Size(15, 17);
            this.lblCriticalTimeSecs.TabIndex = 11;
            this.lblCriticalTimeSecs.Text = "s";
            // 
            // grpTiempo
            // 
            this.grpTiempo.Controls.Add(this.btnColorTiempo);
            this.grpTiempo.Controls.Add(this.btnFontActividad);
            this.grpTiempo.Controls.Add(this.btnFontTiempo);
            this.grpTiempo.Location = new System.Drawing.Point(17, 139);
            this.grpTiempo.Name = "grpTiempo";
            this.grpTiempo.Size = new System.Drawing.Size(369, 54);
            this.grpTiempo.TabIndex = 13;
            this.grpTiempo.TabStop = false;
            this.grpTiempo.Text = "Texto";
            // 
            // btnColorTiempo
            // 
            this.btnColorTiempo.Location = new System.Drawing.Point(6, 19);
            this.btnColorTiempo.Name = "btnColorTiempo";
            this.btnColorTiempo.Size = new System.Drawing.Size(75, 23);
            this.btnColorTiempo.TabIndex = 1;
            this.btnColorTiempo.Text = "Color";
            this.btnColorTiempo.UseVisualStyleBackColor = true;
            this.btnColorTiempo.Click += new System.EventHandler(this.btnColorTiempo_Click);
            // 
            // btnFontActividad
            // 
            this.btnFontActividad.Location = new System.Drawing.Point(186, 19);
            this.btnFontActividad.Name = "btnFontActividad";
            this.btnFontActividad.Size = new System.Drawing.Size(108, 23);
            this.btnFontActividad.TabIndex = 0;
            this.btnFontActividad.Text = "Fuente Actividad";
            this.btnFontActividad.UseVisualStyleBackColor = true;
            this.btnFontActividad.Click += new System.EventHandler(this.btnFontActividad_Click);
            // 
            // btnFontTiempo
            // 
            this.btnFontTiempo.Location = new System.Drawing.Point(90, 19);
            this.btnFontTiempo.Name = "btnFontTiempo";
            this.btnFontTiempo.Size = new System.Drawing.Size(90, 23);
            this.btnFontTiempo.TabIndex = 0;
            this.btnFontTiempo.Text = "Fuente Tiempo";
            this.btnFontTiempo.UseVisualStyleBackColor = true;
            this.btnFontTiempo.Click += new System.EventHandler(this.btnFontTiempo_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(426, 285);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(169, 23);
            this.btnAbout.TabIndex = 13;
            this.btnAbout.Text = "Acerca de Dual Screen Timer";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = global::TPView.Properties.Resources.clock164;
            this.picBoxLogo.Location = new System.Drawing.Point(426, 101);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(168, 168);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 14;
            this.picBoxLogo.TabStop = false;
            // 
            // FrmControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 320);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.gbxTiming);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtActivity);
            this.Controls.Add(this.lblActivity);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmControlPanel";
            this.Text = "Dual Screen Timer - ControlPanel";
            ((System.ComponentModel.ISupportInitialize)(this.nudDurationHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurationMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDurationSeconds)).EndInit();
            this.gbxTiming.ResumeLayout(false);
            this.gbxTiming.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grpPantalla.ResumeLayout(false);
            this.grpPantalla.PerformLayout();
            this.grpFondo.ResumeLayout(false);
            this.grpFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCriticalTime)).EndInit();
            this.grpTiempo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.TextBox txtActivity;
        private System.Windows.Forms.Label lblDurationHours;
        private System.Windows.Forms.NumericUpDown nudDurationHours;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.NumericUpDown nudDurationMinutes;
        private System.Windows.Forms.Label lblDurationMinutes;
        private System.Windows.Forms.NumericUpDown nudDurationSeconds;
        private System.Windows.Forms.Label lblDurationSeconds;
        private System.Windows.Forms.GroupBox gbxTiming;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCriticalTimeSecs;
        private System.Windows.Forms.NumericUpDown nudCriticalTime;
        private System.Windows.Forms.Label lblCriticalTime;
        private System.Windows.Forms.Button btnBackgroundColor;
        private System.Windows.Forms.GroupBox grpTiempo;
        private System.Windows.Forms.Button btnColorTiempo;
        private System.Windows.Forms.Button btnFontTiempo;
        private System.Windows.Forms.Button btnFontActividad;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.GroupBox grpFondo;
        private System.Windows.Forms.GroupBox grpPantalla;
        private System.Windows.Forms.Label lblSeleccionar;
        private System.Windows.Forms.ComboBox cbxPantalla;
        private System.Windows.Forms.PictureBox picBoxLogo;
    }
}