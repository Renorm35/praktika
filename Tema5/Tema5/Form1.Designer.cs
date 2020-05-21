namespace Tema5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.film = new System.Windows.Forms.TextBox();
            this.zhanr = new System.Windows.Forms.TextBox();
            this.Cena = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1313, 1145);
            this.dataGridView1.TabIndex = 0;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(1439, 776);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(553, 55);
            this.Update.TabIndex = 1;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(1439, 849);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(553, 55);
            this.Insert.TabIndex = 2;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(1439, 923);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(553, 55);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // film
            // 
            this.film.Location = new System.Drawing.Point(1439, 230);
            this.film.Name = "film";
            this.film.Size = new System.Drawing.Size(553, 31);
            this.film.TabIndex = 4;
            // 
            // zhanr
            // 
            this.zhanr.Location = new System.Drawing.Point(1439, 295);
            this.zhanr.Name = "zhanr";
            this.zhanr.Size = new System.Drawing.Size(553, 31);
            this.zhanr.TabIndex = 5;
            // 
            // Cena
            // 
            this.Cena.Location = new System.Drawing.Point(1439, 357);
            this.Cena.Name = "Cena";
            this.Cena.Size = new System.Drawing.Size(553, 31);
            this.Cena.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2128, 1169);
            this.Controls.Add(this.Cena);
            this.Controls.Add(this.zhanr);
            this.Controls.Add(this.film);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox film;
        private System.Windows.Forms.TextBox zhanr;
        private System.Windows.Forms.TextBox Cena;
    }
}

