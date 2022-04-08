
namespace Calculator_C1201041
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bntplus = new System.Windows.Forms.Button();
            this.bntequal = new System.Windows.Forms.Button();
            this.bntpoint = new System.Windows.Forms.Button();
            this.bnt0 = new System.Windows.Forms.Button();
            this.bntsub = new System.Windows.Forms.Button();
            this.bnt3 = new System.Windows.Forms.Button();
            this.bnt2 = new System.Windows.Forms.Button();
            this.bnt1 = new System.Windows.Forms.Button();
            this.bntmult = new System.Windows.Forms.Button();
            this.bnt6 = new System.Windows.Forms.Button();
            this.bnt5 = new System.Windows.Forms.Button();
            this.bnt4 = new System.Windows.Forms.Button();
            this.bntdivided = new System.Windows.Forms.Button();
            this.bnt9 = new System.Windows.Forms.Button();
            this.bnt8 = new System.Windows.Forms.Button();
            this.bnt7 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bntclear = new System.Windows.Forms.Button();
            this.bntback = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bntplus);
            this.groupBox1.Controls.Add(this.bntequal);
            this.groupBox1.Controls.Add(this.bntpoint);
            this.groupBox1.Controls.Add(this.bnt0);
            this.groupBox1.Controls.Add(this.bntsub);
            this.groupBox1.Controls.Add(this.bnt3);
            this.groupBox1.Controls.Add(this.bnt2);
            this.groupBox1.Controls.Add(this.bnt1);
            this.groupBox1.Controls.Add(this.bntmult);
            this.groupBox1.Controls.Add(this.bnt6);
            this.groupBox1.Controls.Add(this.bnt5);
            this.groupBox1.Controls.Add(this.bnt4);
            this.groupBox1.Controls.Add(this.bntdivided);
            this.groupBox1.Controls.Add(this.bnt9);
            this.groupBox1.Controls.Add(this.bnt8);
            this.groupBox1.Controls.Add(this.bnt7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 261);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bntplus
            // 
            this.bntplus.Location = new System.Drawing.Point(206, 196);
            this.bntplus.Name = "bntplus";
            this.bntplus.Size = new System.Drawing.Size(55, 55);
            this.bntplus.TabIndex = 15;
            this.bntplus.Text = "+";
            this.bntplus.UseVisualStyleBackColor = true;
            this.bntplus.Click += new System.EventHandler(this.bntplus_Click);
            // 
            // bntequal
            // 
            this.bntequal.Location = new System.Drawing.Point(145, 196);
            this.bntequal.Name = "bntequal";
            this.bntequal.Size = new System.Drawing.Size(55, 55);
            this.bntequal.TabIndex = 14;
            this.bntequal.Text = "=";
            this.bntequal.UseVisualStyleBackColor = true;
            this.bntequal.Click += new System.EventHandler(this.bntequal_Click);
            // 
            // bntpoint
            // 
            this.bntpoint.Location = new System.Drawing.Point(79, 196);
            this.bntpoint.Name = "bntpoint";
            this.bntpoint.Size = new System.Drawing.Size(60, 55);
            this.bntpoint.TabIndex = 13;
            this.bntpoint.Text = ".";
            this.bntpoint.UseVisualStyleBackColor = true;
            this.bntpoint.Click += new System.EventHandler(this.bntpoint_Click);
            // 
            // bnt0
            // 
            this.bnt0.Location = new System.Drawing.Point(18, 196);
            this.bnt0.Name = "bnt0";
            this.bnt0.Size = new System.Drawing.Size(55, 55);
            this.bnt0.TabIndex = 12;
            this.bnt0.Text = "0";
            this.bnt0.UseVisualStyleBackColor = true;
            this.bnt0.Click += new System.EventHandler(this.bnt0_Click);
            // 
            // bntsub
            // 
            this.bntsub.Location = new System.Drawing.Point(206, 135);
            this.bntsub.Name = "bntsub";
            this.bntsub.Size = new System.Drawing.Size(55, 55);
            this.bntsub.TabIndex = 11;
            this.bntsub.Text = "-";
            this.bntsub.UseVisualStyleBackColor = true;
            this.bntsub.Click += new System.EventHandler(this.bntsub_Click);
            // 
            // bnt3
            // 
            this.bnt3.Location = new System.Drawing.Point(145, 135);
            this.bnt3.Name = "bnt3";
            this.bnt3.Size = new System.Drawing.Size(55, 55);
            this.bnt3.TabIndex = 10;
            this.bnt3.Text = "3";
            this.bnt3.UseVisualStyleBackColor = true;
            this.bnt3.Click += new System.EventHandler(this.bnt3_Click);
            // 
            // bnt2
            // 
            this.bnt2.Location = new System.Drawing.Point(79, 135);
            this.bnt2.Name = "bnt2";
            this.bnt2.Size = new System.Drawing.Size(60, 55);
            this.bnt2.TabIndex = 9;
            this.bnt2.Text = "2";
            this.bnt2.UseVisualStyleBackColor = true;
            this.bnt2.Click += new System.EventHandler(this.bnt2_Click);
            // 
            // bnt1
            // 
            this.bnt1.Location = new System.Drawing.Point(18, 135);
            this.bnt1.Name = "bnt1";
            this.bnt1.Size = new System.Drawing.Size(55, 55);
            this.bnt1.TabIndex = 8;
            this.bnt1.Text = "1";
            this.bnt1.UseVisualStyleBackColor = true;
            this.bnt1.Click += new System.EventHandler(this.bnt1_Click);
            // 
            // bntmult
            // 
            this.bntmult.Location = new System.Drawing.Point(206, 74);
            this.bntmult.Name = "bntmult";
            this.bntmult.Size = new System.Drawing.Size(55, 55);
            this.bntmult.TabIndex = 7;
            this.bntmult.Text = "x";
            this.bntmult.UseVisualStyleBackColor = true;
            this.bntmult.Click += new System.EventHandler(this.bntmult_Click);
            // 
            // bnt6
            // 
            this.bnt6.Location = new System.Drawing.Point(145, 74);
            this.bnt6.Name = "bnt6";
            this.bnt6.Size = new System.Drawing.Size(55, 55);
            this.bnt6.TabIndex = 6;
            this.bnt6.Text = "6";
            this.bnt6.UseVisualStyleBackColor = true;
            this.bnt6.Click += new System.EventHandler(this.bnt6_Click);
            // 
            // bnt5
            // 
            this.bnt5.Location = new System.Drawing.Point(79, 74);
            this.bnt5.Name = "bnt5";
            this.bnt5.Size = new System.Drawing.Size(60, 55);
            this.bnt5.TabIndex = 5;
            this.bnt5.Text = "5";
            this.bnt5.UseVisualStyleBackColor = true;
            this.bnt5.Click += new System.EventHandler(this.bnt5_Click);
            // 
            // bnt4
            // 
            this.bnt4.Location = new System.Drawing.Point(18, 74);
            this.bnt4.Name = "bnt4";
            this.bnt4.Size = new System.Drawing.Size(55, 55);
            this.bnt4.TabIndex = 4;
            this.bnt4.Text = "4";
            this.bnt4.UseVisualStyleBackColor = true;
            this.bnt4.Click += new System.EventHandler(this.bnt4_Click);
            // 
            // bntdivided
            // 
            this.bntdivided.Location = new System.Drawing.Point(206, 13);
            this.bntdivided.Name = "bntdivided";
            this.bntdivided.Size = new System.Drawing.Size(55, 55);
            this.bntdivided.TabIndex = 3;
            this.bntdivided.Text = "/";
            this.bntdivided.UseVisualStyleBackColor = true;
            this.bntdivided.Click += new System.EventHandler(this.bntdivided_Click);
            // 
            // bnt9
            // 
            this.bnt9.Location = new System.Drawing.Point(145, 13);
            this.bnt9.Name = "bnt9";
            this.bnt9.Size = new System.Drawing.Size(55, 55);
            this.bnt9.TabIndex = 2;
            this.bnt9.Text = "9";
            this.bnt9.UseVisualStyleBackColor = true;
            this.bnt9.Click += new System.EventHandler(this.bnt9_Click);
            // 
            // bnt8
            // 
            this.bnt8.Location = new System.Drawing.Point(79, 13);
            this.bnt8.Name = "bnt8";
            this.bnt8.Size = new System.Drawing.Size(60, 55);
            this.bnt8.TabIndex = 1;
            this.bnt8.Text = "8";
            this.bnt8.UseVisualStyleBackColor = true;
            this.bnt8.Click += new System.EventHandler(this.bnt8_Click);
            // 
            // bnt7
            // 
            this.bnt7.Location = new System.Drawing.Point(18, 13);
            this.bnt7.Name = "bnt7";
            this.bnt7.Size = new System.Drawing.Size(55, 55);
            this.bnt7.TabIndex = 0;
            this.bnt7.Text = "7";
            this.bnt7.UseVisualStyleBackColor = true;
            this.bnt7.Click += new System.EventHandler(this.bnt7_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bntclear);
            this.groupBox2.Controls.Add(this.bntback);
            this.groupBox2.Location = new System.Drawing.Point(12, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 63);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // bntclear
            // 
            this.bntclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntclear.Location = new System.Drawing.Point(154, 19);
            this.bntclear.Name = "bntclear";
            this.bntclear.Size = new System.Drawing.Size(107, 37);
            this.bntclear.TabIndex = 3;
            this.bntclear.Text = "Clear";
            this.bntclear.UseVisualStyleBackColor = true;
            this.bntclear.Click += new System.EventHandler(this.bntclear_Click);
            // 
            // bntback
            // 
            this.bntback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntback.Location = new System.Drawing.Point(18, 19);
            this.bntback.Name = "bntback";
            this.bntback.Size = new System.Drawing.Size(92, 37);
            this.bntback.TabIndex = 2;
            this.bntback.Text = "←";
            this.bntback.UseVisualStyleBackColor = true;
            this.bntback.Click += new System.EventHandler(this.bntback_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(18, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 46);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.ClientSize = new System.Drawing.Size(308, 407);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Calculator-C1201041";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bntdivided;
        private System.Windows.Forms.Button bnt9;
        private System.Windows.Forms.Button bnt8;
        private System.Windows.Forms.Button bnt7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button bntplus;
        private System.Windows.Forms.Button bntequal;
        private System.Windows.Forms.Button bntpoint;
        private System.Windows.Forms.Button bnt0;
        private System.Windows.Forms.Button bntsub;
        private System.Windows.Forms.Button bnt3;
        private System.Windows.Forms.Button bnt2;
        private System.Windows.Forms.Button bnt1;
        private System.Windows.Forms.Button bntmult;
        private System.Windows.Forms.Button bnt6;
        private System.Windows.Forms.Button bnt5;
        private System.Windows.Forms.Button bnt4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bntclear;
        private System.Windows.Forms.Button bntback;
        private System.Windows.Forms.TextBox textBox1;
    }
}

