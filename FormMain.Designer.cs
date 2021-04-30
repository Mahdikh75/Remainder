namespace Remainder
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewTime = new System.Windows.Forms.Label();
            this.ValueTime = new System.Windows.Forms.TrackBar();
            this.BtnClaer = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.LabelTime = new System.Windows.Forms.Label();
            this.BtnHide = new System.Windows.Forms.Button();
            this.PicAni = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValueTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAni)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ViewTime);
            this.groupBox1.Controls.Add(this.ValueTime);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alarm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "0 \'";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "180 \'";
            // 
            // ViewTime
            // 
            this.ViewTime.AutoSize = true;
            this.ViewTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewTime.ForeColor = System.Drawing.Color.SteelBlue;
            this.ViewTime.Location = new System.Drawing.Point(18, 137);
            this.ViewTime.Name = "ViewTime";
            this.ViewTime.Size = new System.Drawing.Size(74, 29);
            this.ViewTime.TabIndex = 1;
            this.ViewTime.Text = "Clock";
            // 
            // ValueTime
            // 
            this.ValueTime.LargeChange = 1;
            this.ValueTime.Location = new System.Drawing.Point(6, 54);
            this.ValueTime.Maximum = 180;
            this.ValueTime.Name = "ValueTime";
            this.ValueTime.Size = new System.Drawing.Size(406, 56);
            this.ValueTime.TabIndex = 0;
            this.ValueTime.ValueChanged += new System.EventHandler(this.ValueTime_ValueChanged);
            // 
            // BtnClaer
            // 
            this.BtnClaer.BackColor = System.Drawing.Color.Olive;
            this.BtnClaer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClaer.ForeColor = System.Drawing.Color.White;
            this.BtnClaer.Location = new System.Drawing.Point(236, 300);
            this.BtnClaer.Name = "BtnClaer";
            this.BtnClaer.Size = new System.Drawing.Size(100, 43);
            this.BtnClaer.TabIndex = 1;
            this.BtnClaer.Text = "Claer";
            this.BtnClaer.UseVisualStyleBackColor = false;
            this.BtnClaer.Click += new System.EventHandler(this.BtnClaer_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStop.ForeColor = System.Drawing.Color.White;
            this.BtnStop.Location = new System.Drawing.Point(130, 300);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(100, 43);
            this.BtnStop.TabIndex = 2;
            this.BtnStop.Text = "Stop ";
            this.BtnStop.UseVisualStyleBackColor = false;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.ForeColor = System.Drawing.Color.White;
            this.BtnStart.Location = new System.Drawing.Point(24, 300);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(100, 43);
            this.BtnStart.TabIndex = 3;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTime.ForeColor = System.Drawing.Color.Maroon;
            this.LabelTime.Location = new System.Drawing.Point(19, 32);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(56, 25);
            this.LabelTime.TabIndex = 4;
            this.LabelTime.Text = "Time";
            // 
            // BtnHide
            // 
            this.BtnHide.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BtnHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHide.ForeColor = System.Drawing.Color.White;
            this.BtnHide.Location = new System.Drawing.Point(342, 300);
            this.BtnHide.Name = "BtnHide";
            this.BtnHide.Size = new System.Drawing.Size(100, 43);
            this.BtnHide.TabIndex = 5;
            this.BtnHide.Text = "Hide";
            this.BtnHide.UseVisualStyleBackColor = false;
            this.BtnHide.Click += new System.EventHandler(this.BtnHide_Click);
            // 
            // PicAni
            // 
            this.PicAni.Image = global::Remainder.Properties.Resources.Untitled_6;
            this.PicAni.Location = new System.Drawing.Point(360, 12);
            this.PicAni.Name = "PicAni";
            this.PicAni.Size = new System.Drawing.Size(82, 57);
            this.PicAni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicAni.TabIndex = 4;
            this.PicAni.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(463, 361);
            this.Controls.Add(this.PicAni);
            this.Controls.Add(this.BtnHide);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnClaer);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remainder";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValueTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnClaer;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Label ViewTime;
        private System.Windows.Forms.TrackBar ValueTime;
        private System.Windows.Forms.Button BtnHide;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicAni;
    }
}

