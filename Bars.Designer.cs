
namespace Scroll_Bars
{
    partial class Bars
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
            this.BarraHorizTeste = new System.Windows.Forms.HScrollBar();
            this.LblTeste = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraHorizTeste
            // 
            this.BarraHorizTeste.Location = new System.Drawing.Point(111, 43);
            this.BarraHorizTeste.Maximum = 59;
            this.BarraHorizTeste.Name = "BarraHorizTeste";
            this.BarraHorizTeste.Size = new System.Drawing.Size(234, 32);
            this.BarraHorizTeste.TabIndex = 0;
            this.BarraHorizTeste.Scroll += new System.Windows.Forms.ScrollEventHandler(this.BarraHorizTeste_Scroll);
            // 
            // LblTeste
            // 
            this.LblTeste.AutoSize = true;
            this.LblTeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTeste.Location = new System.Drawing.Point(208, 85);
            this.LblTeste.Name = "LblTeste";
            this.LblTeste.Size = new System.Drawing.Size(66, 46);
            this.LblTeste.TabIndex = 1;
            this.LblTeste.Text = "00";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(216, 240);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(42, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Bars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 484);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.LblTeste);
            this.Controls.Add(this.BarraHorizTeste);
            this.Name = "Bars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scroll Bars";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar BarraHorizTeste;
        private System.Windows.Forms.Label LblTeste;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
    }
}

