namespace Hangman
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
            this.btnGissa = new System.Windows.Forms.Button();
            this.btnNyttOrd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblSlutResultat = new System.Windows.Forms.Label();
            this.btnGissaHelaOrdet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.taOrd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGissa
            // 
            this.btnGissa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGissa.Location = new System.Drawing.Point(851, 217);
            this.btnGissa.Name = "btnGissa";
            this.btnGissa.Size = new System.Drawing.Size(89, 38);
            this.btnGissa.TabIndex = 1;
            this.btnGissa.Text = "Gissa";
            this.btnGissa.UseVisualStyleBackColor = true;
            this.btnGissa.Click += new System.EventHandler(this.btnGissa_Click);
            // 
            // btnNyttOrd
            // 
            this.btnNyttOrd.Location = new System.Drawing.Point(0, 0);
            this.btnNyttOrd.Name = "btnNyttOrd";
            this.btnNyttOrd.Size = new System.Drawing.Size(75, 23);
            this.btnNyttOrd.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(691, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bokstäver i ordet: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(789, 231);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(30, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gissa hela ordet";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(445, 190);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // lblSlutResultat
            // 
            this.lblSlutResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSlutResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlutResultat.Location = new System.Drawing.Point(451, 29);
            this.lblSlutResultat.Name = "lblSlutResultat";
            this.lblSlutResultat.Size = new System.Drawing.Size(433, 29);
            this.lblSlutResultat.TabIndex = 8;
            // 
            // btnGissaHelaOrdet
            // 
            this.btnGissaHelaOrdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGissaHelaOrdet.Location = new System.Drawing.Point(424, 231);
            this.btnGissaHelaOrdet.Name = "btnGissaHelaOrdet";
            this.btnGissaHelaOrdet.Size = new System.Drawing.Size(172, 37);
            this.btnGissaHelaOrdet.TabIndex = 9;
            this.btnGissaHelaOrdet.Text = "Gissa hela ordet";
            this.btnGissaHelaOrdet.UseVisualStyleBackColor = true;
            this.btnGissaHelaOrdet.Click += new System.EventHandler(this.btnGissaHelaOrdet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(691, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Skriv bokstav:";
            // 
            // taOrd
            // 
            this.taOrd.Location = new System.Drawing.Point(520, 330);
            this.taOrd.Name = "taOrd";
            this.taOrd.Size = new System.Drawing.Size(172, 23);
            this.taOrd.TabIndex = 12;
            this.taOrd.Text = "Hämta Ord";
            this.taOrd.UseVisualStyleBackColor = true;
            this.taOrd.Click += new System.EventHandler(this.ta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hangman.Properties.Resources.Galge;
            this.pictureBox1.InitialImage = global::Hangman.Properties.Resources.Galge;
            this.pictureBox1.Location = new System.Drawing.Point(80, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 320);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 494);
            this.Controls.Add(this.taOrd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGissaHelaOrdet);
            this.Controls.Add(this.lblSlutResultat);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnNyttOrd);
            this.Controls.Add(this.btnGissa);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGissa;
        private System.Windows.Forms.Button btnNyttOrd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblSlutResultat;
        private System.Windows.Forms.Button btnGissaHelaOrdet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button taOrd;
    }
}

