namespace Tema2._2
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
            this.KolStr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.KolStolb = new System.Windows.Forms.TextBox();
            this.resultGen = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.stroka = new System.Windows.Forms.RadioButton();
            this.stolbec = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sort = new System.Windows.Forms.Button();
            this.raschet = new System.Windows.Forms.Button();
            this.formirov = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сколько строк?";
            // 
            // KolStr
            // 
            this.KolStr.Location = new System.Drawing.Point(133, 27);
            this.KolStr.Name = "KolStr";
            this.KolStr.Size = new System.Drawing.Size(52, 20);
            this.KolStr.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сколько столбцов?";
            // 
            // KolStolb
            // 
            this.KolStolb.Location = new System.Drawing.Point(430, 24);
            this.KolStolb.Name = "KolStolb";
            this.KolStolb.Size = new System.Drawing.Size(52, 20);
            this.KolStolb.TabIndex = 3;
            // 
            // resultGen
            // 
            this.resultGen.Location = new System.Drawing.Point(72, 348);
            this.resultGen.Name = "resultGen";
            this.resultGen.ReadOnly = true;
            this.resultGen.Size = new System.Drawing.Size(377, 20);
            this.resultGen.TabIndex = 4;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(72, 374);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(377, 20);
            this.result.TabIndex = 5;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(359, 410);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(90, 30);
            this.exit.TabIndex = 6;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // stroka
            // 
            this.stroka.AutoSize = true;
            this.stroka.Location = new System.Drawing.Point(72, 325);
            this.stroka.Name = "stroka";
            this.stroka.Size = new System.Drawing.Size(102, 17);
            this.stroka.TabIndex = 7;
            this.stroka.TabStop = true;
            this.stroka.Text = "Каждой строки";
            this.stroka.UseVisualStyleBackColor = true;
            // 
            // stolbec
            // 
            this.stolbec.AutoSize = true;
            this.stolbec.Location = new System.Drawing.Point(180, 325);
            this.stolbec.Name = "stolbec";
            this.stolbec.Size = new System.Drawing.Size(113, 17);
            this.stolbec.TabIndex = 8;
            this.stolbec.TabStop = true;
            this.stolbec.Text = "Каждого столбца";
            this.stolbec.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Создать двомерный массив сумм негативных элементов";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(474, 233);
            this.dataGridView1.TabIndex = 10;
            // 
            // sort
            // 
            this.sort.Location = new System.Drawing.Point(263, 410);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(90, 30);
            this.sort.TabIndex = 11;
            this.sort.Text = "Сортировка";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // raschet
            // 
            this.raschet.Location = new System.Drawing.Point(167, 410);
            this.raschet.Name = "raschet";
            this.raschet.Size = new System.Drawing.Size(90, 30);
            this.raschet.TabIndex = 12;
            this.raschet.Text = "Расчёт";
            this.raschet.UseVisualStyleBackColor = true;
            this.raschet.Click += new System.EventHandler(this.raschet_Click);
            // 
            // formirov
            // 
            this.formirov.Location = new System.Drawing.Point(56, 410);
            this.formirov.Name = "formirov";
            this.formirov.Size = new System.Drawing.Size(105, 30);
            this.formirov.TabIndex = 13;
            this.formirov.Text = "Формирование";
            this.formirov.UseVisualStyleBackColor = true;
            this.formirov.Click += new System.EventHandler(this.formirov_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 447);
            this.Controls.Add(this.formirov);
            this.Controls.Add(this.raschet);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stolbec);
            this.Controls.Add(this.stroka);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.result);
            this.Controls.Add(this.resultGen);
            this.Controls.Add(this.KolStolb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KolStr);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KolStr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KolStolb;
        private System.Windows.Forms.TextBox resultGen;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.RadioButton stroka;
        private System.Windows.Forms.RadioButton stolbec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button sort;
        private System.Windows.Forms.Button raschet;
        private System.Windows.Forms.Button formirov;
    }
}

