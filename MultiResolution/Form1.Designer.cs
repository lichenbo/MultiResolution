namespace MultiResolution
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
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.dialog = new System.Windows.Forms.OpenFileDialog();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.txtZoom = new System.Windows.Forms.Label();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar
            // 
            this.trackBar.Enabled = false;
            this.trackBar.Location = new System.Drawing.Point(57, 363);
            this.trackBar.Maximum = 2;
            this.trackBar.Minimum = -2;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(363, 45);
            this.trackBar.TabIndex = 1;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // dialog
            // 
            this.dialog.FileName = "openFileDialog1";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(58, 15);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(321, 21);
            this.txtPath.TabIndex = 2;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(386, 13);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(34, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(426, 13);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.picBox);
            this.panel1.Location = new System.Drawing.Point(58, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 260);
            this.panel1.TabIndex = 5;
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(3, 0);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(116, 63);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // txtZoom
            // 
            this.txtZoom.AutoSize = true;
            this.txtZoom.Font = new System.Drawing.Font("SimSun", 19F);
            this.txtZoom.Location = new System.Drawing.Point(427, 363);
            this.txtZoom.Name = "txtZoom";
            this.txtZoom.Size = new System.Drawing.Size(77, 26);
            this.txtZoom.TabIndex = 6;
            this.txtZoom.Text = "1.00X";
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Checked = true;
            this.radio1.Location = new System.Drawing.Point(3, 10);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(113, 16);
            this.radio1.TabIndex = 7;
            this.radio1.TabStop = true;
            this.radio1.Text = "NearestNeighbor";
            this.radio1.UseVisualStyleBackColor = true;
            this.radio1.CheckedChanged += new System.EventHandler(this.radio1_CheckedChanged);
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Location = new System.Drawing.Point(126, 10);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(71, 16);
            this.radio2.TabIndex = 8;
            this.radio2.Text = "Bilinear";
            this.radio2.UseVisualStyleBackColor = true;
            this.radio2.CheckedChanged += new System.EventHandler(this.radio2_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radio1);
            this.panel2.Controls.Add(this.radio2);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(79, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 37);
            this.panel2.TabIndex = 9;
            // 
            // txtTime
            // 
            this.txtTime.AutoSize = true;
            this.txtTime.Location = new System.Drawing.Point(386, 330);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(29, 12);
            this.txtTime.TabIndex = 10;
            this.txtTime.Text = "0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 420);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtZoom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.trackBar);
            this.Name = "Form1";
            this.Text = "MultiResolution -- 何炜，李琛博，黄欣，季振亚";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.OpenFileDialog dialog;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label txtZoom;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtTime;
    }
}

