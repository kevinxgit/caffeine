namespace Caffeine
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbEnabled = new System.Windows.Forms.CheckBox();
            this.cmdToTray = new System.Windows.Forms.Button();
            this.txtFreq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.freqTimer = new System.Windows.Forms.Timer(this.components);
            this.nifMin = new System.Windows.Forms.NotifyIcon(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimeOut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTimeOutEnable = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbEnabled
            // 
            this.cbEnabled.AutoSize = true;
            this.cbEnabled.Location = new System.Drawing.Point(47, 99);
            this.cbEnabled.Name = "cbEnabled";
            this.cbEnabled.Size = new System.Drawing.Size(65, 17);
            this.cbEnabled.TabIndex = 0;
            this.cbEnabled.Text = "Enabled";
            this.cbEnabled.UseVisualStyleBackColor = true;
            this.cbEnabled.CheckedChanged += new System.EventHandler(this.cbEnabled_CheckedChanged);
            // 
            // cmdToTray
            // 
            this.cmdToTray.Image = ((System.Drawing.Image)(resources.GetObject("cmdToTray.Image")));
            this.cmdToTray.Location = new System.Drawing.Point(124, 109);
            this.cmdToTray.Name = "cmdToTray";
            this.cmdToTray.Size = new System.Drawing.Size(38, 23);
            this.cmdToTray.TabIndex = 1;
            this.cmdToTray.UseVisualStyleBackColor = true;
            this.cmdToTray.Click += new System.EventHandler(this.cmdToTray_Click);
            // 
            // txtFreq
            // 
            this.txtFreq.Location = new System.Drawing.Point(47, 73);
            this.txtFreq.MaxLength = 6;
            this.txtFreq.Name = "txtFreq";
            this.txtFreq.Size = new System.Drawing.Size(56, 20);
            this.txtFreq.TabIndex = 2;
            this.txtFreq.Text = "60000";
            this.txtFreq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFeq_KeyPress);
            this.txtFreq.Leave += new System.EventHandler(this.txtFeq_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Freq:";
            // 
            // freqTimer
            // 
            this.freqTimer.Interval = 1000;
            this.freqTimer.Tick += new System.EventHandler(this.freqTimer_Tick);
            // 
            // nifMin
            // 
            this.nifMin.Icon = ((System.Drawing.Icon)(resources.GetObject("nifMin.Icon")));
            this.nifMin.Text = "Caffeine";
            this.nifMin.Visible = true;
            this.nifMin.DoubleClick += new System.EventHandler(this.nifMin_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "(ms)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "T/O:";
            // 
            // txtTimeOut
            // 
            this.txtTimeOut.Location = new System.Drawing.Point(47, 12);
            this.txtTimeOut.MaxLength = 6;
            this.txtTimeOut.Name = "txtTimeOut";
            this.txtTimeOut.Size = new System.Drawing.Size(56, 20);
            this.txtTimeOut.TabIndex = 5;
            this.txtTimeOut.Text = "5";
            this.txtTimeOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimeOut_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "(mn)";
            // 
            // cbTimeOutEnable
            // 
            this.cbTimeOutEnable.AutoSize = true;
            this.cbTimeOutEnable.Location = new System.Drawing.Point(47, 38);
            this.cbTimeOutEnable.Name = "cbTimeOutEnable";
            this.cbTimeOutEnable.Size = new System.Drawing.Size(65, 17);
            this.cbTimeOutEnable.TabIndex = 8;
            this.cbTimeOutEnable.Text = "Enabled";
            this.cbTimeOutEnable.UseVisualStyleBackColor = true;
            this.cbTimeOutEnable.CheckedChanged += new System.EventHandler(this.cbTimeOutEnable_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 144);
            this.Controls.Add(this.cbTimeOutEnable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTimeOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFreq);
            this.Controls.Add(this.cmdToTray);
            this.Controls.Add(this.cbEnabled);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caffeine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbEnabled;
        private System.Windows.Forms.Button cmdToTray;
        private System.Windows.Forms.TextBox txtFreq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer freqTimer;
        private System.Windows.Forms.NotifyIcon nifMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimeOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbTimeOutEnable;
    }
}

