namespace Tema2
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
            this.BTN_delete = new System.Windows.Forms.Button();
            this.BTN_add = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.ListBox();
            this.input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN_delete
            // 
            this.BTN_delete.Location = new System.Drawing.Point(227, 300);
            this.BTN_delete.Name = "BTN_delete";
            this.BTN_delete.Size = new System.Drawing.Size(75, 23);
            this.BTN_delete.TabIndex = 0;
            this.BTN_delete.Text = "Видалити";
            this.BTN_delete.UseVisualStyleBackColor = true;
            this.BTN_delete.Click += new System.EventHandler(this.BTN_delete_Click);
            // 
            // BTN_add
            // 
            this.BTN_add.Location = new System.Drawing.Point(146, 300);
            this.BTN_add.Name = "BTN_add";
            this.BTN_add.Size = new System.Drawing.Size(75, 23);
            this.BTN_add.TabIndex = 1;
            this.BTN_add.Text = "Додати";
            this.BTN_add.UseVisualStyleBackColor = true;
            this.BTN_add.Click += new System.EventHandler(this.BTN_add_Click);
            // 
            // output
            // 
            this.output.FormattingEnabled = true;
            this.output.Location = new System.Drawing.Point(13, 13);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(289, 277);
            this.output.TabIndex = 3;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(13, 300);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(127, 20);
            this.input.TabIndex = 5;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 335);
            this.Controls.Add(this.input);
            this.Controls.Add(this.output);
            this.Controls.Add(this.BTN_add);
            this.Controls.Add(this.BTN_delete);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_delete;
        private System.Windows.Forms.Button BTN_add;
        private System.Windows.Forms.ListBox output;
        private System.Windows.Forms.TextBox input;
    }
}

