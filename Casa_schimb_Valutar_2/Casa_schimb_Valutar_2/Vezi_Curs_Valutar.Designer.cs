
namespace Casa_schimb_Valutar_2
{
    partial class Vezi_Curs_Valutar
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxValuta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(625, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "cod                                  nume                                  simbol" +
    "                         rata_fata_de_euro";
            // 
            // textBoxValuta
            // 
            this.textBoxValuta.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxValuta.Location = new System.Drawing.Point(13, 95);
            this.textBoxValuta.Multiline = true;
            this.textBoxValuta.Name = "textBoxValuta";
            this.textBoxValuta.ReadOnly = true;
            this.textBoxValuta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxValuta.Size = new System.Drawing.Size(759, 343);
            this.textBoxValuta.TabIndex = 5;
            this.textBoxValuta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(135, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(479, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cursul Valutar fata de euro";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Vezi_Curs_Valutar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxValuta);
            this.Controls.Add(this.label2);
            this.Name = "Vezi_Curs_Valutar";
            this.Text = "Adauga_valute";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxValuta;
        private System.Windows.Forms.Button button1;
    }
}