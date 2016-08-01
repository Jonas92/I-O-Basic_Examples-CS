namespace I_O_with_files.Forms
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
            this.TextoTxt = new System.Windows.Forms.TextBox();
            this.salvaTextoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextoTxt
            // 
            this.TextoTxt.Location = new System.Drawing.Point(13, 13);
            this.TextoTxt.Multiline = true;
            this.TextoTxt.Name = "TextoTxt";
            this.TextoTxt.Size = new System.Drawing.Size(259, 182);
            this.TextoTxt.TabIndex = 0;
            // 
            // salvaTextoBtn
            // 
            this.salvaTextoBtn.Location = new System.Drawing.Point(98, 201);
            this.salvaTextoBtn.Name = "salvaTextoBtn";
            this.salvaTextoBtn.Size = new System.Drawing.Size(75, 23);
            this.salvaTextoBtn.TabIndex = 1;
            this.salvaTextoBtn.Text = "Salvar";
            this.salvaTextoBtn.UseVisualStyleBackColor = true;
            this.salvaTextoBtn.Click += new System.EventHandler(this.salvaTextoBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.salvaTextoBtn);
            this.Controls.Add(this.TextoTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextoTxt;
        private System.Windows.Forms.Button salvaTextoBtn;
    }
}

