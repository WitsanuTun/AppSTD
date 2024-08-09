namespace AppSTD
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tEffective = new System.Windows.Forms.TextBox();
            this.tCollect = new System.Windows.Forms.TextBox();
            this.tTest = new System.Windows.Forms.TextBox();
            this.tTotle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6show = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppSTD.Properties.Resources.images__4_;
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 173);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "โปรแกรมคำนวณผลการเรียน";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "จิตรพิสัย  :";
            // 
            // tEffective
            // 
            this.tEffective.Location = new System.Drawing.Point(100, 202);
            this.tEffective.Name = "tEffective";
            this.tEffective.Size = new System.Drawing.Size(50, 20);
            this.tEffective.TabIndex = 3;
            this.tEffective.TextChanged += new System.EventHandler(this.tEffective_TextChanged);
            this.tEffective.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tEffective_KeyDown);
            this.tEffective.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tEffective_KeyUp);
            // 
            // tCollect
            // 
            this.tCollect.Location = new System.Drawing.Point(100, 228);
            this.tCollect.Name = "tCollect";
            this.tCollect.Size = new System.Drawing.Size(50, 20);
            this.tCollect.TabIndex = 4;
            this.tCollect.TextChanged += new System.EventHandler(this.tCollect_TextChanged);
            this.tCollect.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tCollect_KeyDown);
            // 
            // tTest
            // 
            this.tTest.Location = new System.Drawing.Point(100, 254);
            this.tTest.Name = "tTest";
            this.tTest.Size = new System.Drawing.Size(50, 20);
            this.tTest.TabIndex = 5;
            this.tTest.TextChanged += new System.EventHandler(this.tTest_TextChanged);
            this.tTest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tTest_KeyDown);
            // 
            // tTotle
            // 
            this.tTotle.Location = new System.Drawing.Point(100, 280);
            this.tTotle.Name = "tTotle";
            this.tTotle.Size = new System.Drawing.Size(50, 20);
            this.tTotle.TabIndex = 6;
            this.tTotle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tTotle_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "คะแนนเก็บ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "สอบปลายภาค:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "รวม:";
            // 
            // label6show
            // 
            this.label6show.AutoSize = true;
            this.label6show.Location = new System.Drawing.Point(38, 325);
            this.label6show.Name = "label6show";
            this.label6show.Size = new System.Drawing.Size(99, 13);
            this.label6show.TabIndex = 10;
            this.label6show.Text = "ผลการเรียนรวม คือ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "ไม่เกิน 20";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "ไม่เกิน 40";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(172, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "ไม่เกิน 40";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6show);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tTotle);
            this.Controls.Add(this.tTest);
            this.Controls.Add(this.tCollect);
            this.Controls.Add(this.tEffective);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tEffective;
        private System.Windows.Forms.TextBox tCollect;
        private System.Windows.Forms.TextBox tTest;
        private System.Windows.Forms.TextBox tTotle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6show;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

