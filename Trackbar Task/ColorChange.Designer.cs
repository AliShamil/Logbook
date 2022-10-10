namespace Trackbar_Task
{
    partial class ColorChange
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_red = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_red = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_green = new System.Windows.Forms.TrackBar();
            this.lbl_green = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tb_blue = new System.Windows.Forms.TrackBar();
            this.lbl_blue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_red)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_green)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_blue)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_red
            // 
            this.tb_red.Dock = System.Windows.Forms.DockStyle.Left;
            this.tb_red.Location = new System.Drawing.Point(0, 0);
            this.tb_red.Maximum = 255;
            this.tb_red.Name = "tb_red";
            this.tb_red.Size = new System.Drawing.Size(419, 43);
            this.tb_red.TabIndex = 2;
            this.tb_red.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(183, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 236);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(368, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Colors";
            // 
            // lbl_red
            // 
            this.lbl_red.AutoSize = true;
            this.lbl_red.Location = new System.Drawing.Point(440, 11);
            this.lbl_red.Name = "lbl_red";
            this.lbl_red.Size = new System.Drawing.Size(27, 15);
            this.lbl_red.TabIndex = 4;
            this.lbl_red.Text = "Red";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tb_red);
            this.panel2.Controls.Add(this.lbl_red);
            this.panel2.Location = new System.Drawing.Point(183, 282);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 43);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tb_green);
            this.panel3.Controls.Add(this.lbl_green);
            this.panel3.Location = new System.Drawing.Point(183, 331);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(492, 43);
            this.panel3.TabIndex = 5;
            // 
            // tb_green
            // 
            this.tb_green.Dock = System.Windows.Forms.DockStyle.Left;
            this.tb_green.Location = new System.Drawing.Point(0, 0);
            this.tb_green.Maximum = 255;
            this.tb_green.Name = "tb_green";
            this.tb_green.Size = new System.Drawing.Size(419, 43);
            this.tb_green.TabIndex = 2;
            this.tb_green.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // lbl_green
            // 
            this.lbl_green.AutoSize = true;
            this.lbl_green.Location = new System.Drawing.Point(440, 11);
            this.lbl_green.Name = "lbl_green";
            this.lbl_green.Size = new System.Drawing.Size(38, 15);
            this.lbl_green.TabIndex = 4;
            this.lbl_green.Text = "Green";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tb_blue);
            this.panel4.Controls.Add(this.lbl_blue);
            this.panel4.Location = new System.Drawing.Point(183, 380);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(492, 43);
            this.panel4.TabIndex = 5;
            // 
            // tb_blue
            // 
            this.tb_blue.Dock = System.Windows.Forms.DockStyle.Left;
            this.tb_blue.Location = new System.Drawing.Point(0, 0);
            this.tb_blue.Maximum = 255;
            this.tb_blue.Name = "tb_blue";
            this.tb_blue.Size = new System.Drawing.Size(419, 43);
            this.tb_blue.TabIndex = 2;
            this.tb_blue.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // lbl_blue
            // 
            this.lbl_blue.AutoSize = true;
            this.lbl_blue.Location = new System.Drawing.Point(440, 11);
            this.lbl_blue.Name = "lbl_blue";
            this.lbl_blue.Size = new System.Drawing.Size(30, 15);
            this.lbl_blue.TabIndex = 4;
            this.lbl_blue.Text = "Blue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tb_red)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_green)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TrackBar tb_red;
        private Panel panel1;
        private Label label1;
        private Label lbl_red;
        private Panel panel2;
        private Panel panel3;
        private TrackBar tb_green;
        private Label lbl_green;
        private Panel panel4;
        private TrackBar tb_blue;
        private Label lbl_blue;
    }
}