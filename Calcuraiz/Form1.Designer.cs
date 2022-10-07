namespace Calcuraiz
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
            this.txtEntrarnumero = new System.Windows.Forms.TextBox();
            this.Igual = new System.Windows.Forms.Button();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtEntrarnumero
            // 
            this.txtEntrarnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrarnumero.Location = new System.Drawing.Point(21, 127);
            this.txtEntrarnumero.MaxLength = 12;
            this.txtEntrarnumero.Multiline = true;
            this.txtEntrarnumero.Name = "txtEntrarnumero";
            this.txtEntrarnumero.Size = new System.Drawing.Size(260, 52);
            this.txtEntrarnumero.TabIndex = 0;
            this.txtEntrarnumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Igual
            // 
            this.Igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Igual.Location = new System.Drawing.Point(209, 252);
            this.Igual.Name = "Igual";
            this.Igual.Size = new System.Drawing.Size(226, 81);
            this.Igual.TabIndex = 2;
            this.Igual.Text = "=";
            this.Igual.UseVisualStyleBackColor = true;
            this.Igual.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtresultado
            // 
            this.txtresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresultado.Location = new System.Drawing.Point(357, 127);
            this.txtresultado.MaxLength = 12;
            this.txtresultado.Multiline = true;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ReadOnly = true;
            this.txtresultado.Size = new System.Drawing.Size(255, 52);
            this.txtresultado.TabIndex = 3;
            this.txtresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 499);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.Igual);
            this.Controls.Add(this.txtEntrarnumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntrarnumero;
        private System.Windows.Forms.Button Igual;
        private System.Windows.Forms.TextBox txtresultado;
    }
}

