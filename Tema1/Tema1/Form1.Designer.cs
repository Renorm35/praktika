namespace Tema1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DovzhKim = new System.Windows.Forms.TextBox();
            this.ShirKim = new System.Windows.Forms.TextBox();
            this.VisStel = new System.Windows.Forms.TextBox();
            this.DovzhSHP = new System.Windows.Forms.TextBox();
            this.ShirSHP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Price1rul = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.KlkstSHP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Resultprice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Довжина кімнати(м):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ширина кімнати(м):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Висота стелі(м):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Довжина шпалер(м):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ширина шпалер(м):";
            // 
            // DovzhKim
            // 
            this.DovzhKim.BackColor = System.Drawing.Color.White;
            this.DovzhKim.Location = new System.Drawing.Point(131, 29);
            this.DovzhKim.Name = "DovzhKim";
            this.DovzhKim.Size = new System.Drawing.Size(100, 20);
            this.DovzhKim.TabIndex = 5;
            this.DovzhKim.TextChanged += new System.EventHandler(this.DovzhKim_TextChanged);
            // 
            // ShirKim
            // 
            this.ShirKim.Location = new System.Drawing.Point(131, 70);
            this.ShirKim.Name = "ShirKim";
            this.ShirKim.Size = new System.Drawing.Size(100, 20);
            this.ShirKim.TabIndex = 6;
            this.ShirKim.TextChanged += new System.EventHandler(this.DovzhKim_TextChanged);
            // 
            // VisStel
            // 
            this.VisStel.Location = new System.Drawing.Point(131, 110);
            this.VisStel.Name = "VisStel";
            this.VisStel.Size = new System.Drawing.Size(100, 20);
            this.VisStel.TabIndex = 7;
            this.VisStel.TextChanged += new System.EventHandler(this.DovzhKim_TextChanged);
            // 
            // DovzhSHP
            // 
            this.DovzhSHP.Location = new System.Drawing.Point(131, 149);
            this.DovzhSHP.Name = "DovzhSHP";
            this.DovzhSHP.Size = new System.Drawing.Size(100, 20);
            this.DovzhSHP.TabIndex = 8;
            this.DovzhSHP.TextChanged += new System.EventHandler(this.DovzhKim_TextChanged);
            // 
            // ShirSHP
            // 
            this.ShirSHP.Location = new System.Drawing.Point(131, 190);
            this.ShirSHP.Name = "ShirSHP";
            this.ShirSHP.Size = new System.Drawing.Size(100, 20);
            this.ShirSHP.TabIndex = 9;
            this.ShirSHP.TextChanged += new System.EventHandler(this.DovzhKim_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Цена за 1 рулон(грн):";
            // 
            // Price1rul
            // 
            this.Price1rul.Location = new System.Drawing.Point(131, 234);
            this.Price1rul.Name = "Price1rul";
            this.Price1rul.Size = new System.Drawing.Size(100, 20);
            this.Price1rul.TabIndex = 11;
            this.Price1rul.TextChanged += new System.EventHandler(this.DovzhKim_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Результат:";
            // 
            // KlkstSHP
            // 
            this.KlkstSHP.Location = new System.Drawing.Point(80, 274);
            this.KlkstSHP.Name = "KlkstSHP";
            this.KlkstSHP.ReadOnly = true;
            this.KlkstSHP.Size = new System.Drawing.Size(47, 20);
            this.KlkstSHP.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(133, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Кількість шпалер";
            // 
            // Resultprice
            // 
            this.Resultprice.Location = new System.Drawing.Point(80, 315);
            this.Resultprice.Name = "Resultprice";
            this.Resultprice.ReadOnly = true;
            this.Resultprice.Size = new System.Drawing.Size(47, 20);
            this.Resultprice.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(133, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "грн";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 25);
            this.button1.TabIndex = 18;
            this.button1.Text = "Розрахувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 378);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Resultprice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.KlkstSHP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Price1rul);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ShirSHP);
            this.Controls.Add(this.DovzhSHP);
            this.Controls.Add(this.VisStel);
            this.Controls.Add(this.ShirKim);
            this.Controls.Add(this.DovzhKim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DovzhKim;
        private System.Windows.Forms.TextBox ShirKim;
        private System.Windows.Forms.TextBox VisStel;
        private System.Windows.Forms.TextBox DovzhSHP;
        private System.Windows.Forms.TextBox ShirSHP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Price1rul;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox KlkstSHP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Resultprice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}

