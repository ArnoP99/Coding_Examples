namespace TowersOfHanoi
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
            this.trackBarNumDisks = new System.Windows.Forms.TrackBar();
            this.labelNumDisks = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxSteps = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNumDisks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarNumDisks
            // 
            this.trackBarNumDisks.Location = new System.Drawing.Point(138, 13);
            this.trackBarNumDisks.Minimum = 1;
            this.trackBarNumDisks.Name = "trackBarNumDisks";
            this.trackBarNumDisks.Size = new System.Drawing.Size(104, 45);
            this.trackBarNumDisks.TabIndex = 0;
            this.trackBarNumDisks.Value = 1;
            this.trackBarNumDisks.Scroll += new System.EventHandler(this.trackBarNumDisks_Scroll);
            // 
            // labelNumDisks
            // 
            this.labelNumDisks.AutoSize = true;
            this.labelNumDisks.Location = new System.Drawing.Point(22, 23);
            this.labelNumDisks.Name = "labelNumDisks";
            this.labelNumDisks.Size = new System.Drawing.Size(97, 13);
            this.labelNumDisks.TabIndex = 1;
            this.labelNumDisks.Text = "Number of Disks: 1";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(248, 13);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(893, 304);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // textBoxSteps
            // 
            this.textBoxSteps.Location = new System.Drawing.Point(25, 353);
            this.textBoxSteps.Multiline = true;
            this.textBoxSteps.Name = "textBoxSteps";
            this.textBoxSteps.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSteps.Size = new System.Drawing.Size(893, 167);
            this.textBoxSteps.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 532);
            this.Controls.Add(this.textBoxSteps);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.labelNumDisks);
            this.Controls.Add(this.trackBarNumDisks);
            this.Name = "Form1";
            this.Text = "Hanoi";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNumDisks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarNumDisks;
        private System.Windows.Forms.Label labelNumDisks;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxSteps;
        private System.Windows.Forms.Timer timer1;
    }
}

