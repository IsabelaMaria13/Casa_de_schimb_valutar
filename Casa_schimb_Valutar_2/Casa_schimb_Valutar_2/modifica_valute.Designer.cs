
namespace Casa_schimb_Valutar_2
{
    partial class modifica_valute
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCodValuta = new System.Windows.Forms.TextBox();
            this.textBoxNumeValuta = new System.Windows.Forms.TextBox();
            this.textBoxSimbolValuta = new System.Windows.Forms.TextBox();
            this.textBoxRataEuro = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonSerializare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PowderBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introducere de valute noi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "SIMBOL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "NUME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "COD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "RATA/EURO";
            // 
            // textBoxCodValuta
            // 
            this.textBoxCodValuta.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxCodValuta.Location = new System.Drawing.Point(200, 127);
            this.textBoxCodValuta.Name = "textBoxCodValuta";
            this.textBoxCodValuta.Size = new System.Drawing.Size(100, 26);
            this.textBoxCodValuta.TabIndex = 5;
            // 
            // textBoxNumeValuta
            // 
            this.textBoxNumeValuta.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxNumeValuta.Location = new System.Drawing.Point(200, 219);
            this.textBoxNumeValuta.Name = "textBoxNumeValuta";
            this.textBoxNumeValuta.Size = new System.Drawing.Size(100, 26);
            this.textBoxNumeValuta.TabIndex = 6;
            // 
            // textBoxSimbolValuta
            // 
            this.textBoxSimbolValuta.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxSimbolValuta.Location = new System.Drawing.Point(200, 302);
            this.textBoxSimbolValuta.Name = "textBoxSimbolValuta";
            this.textBoxSimbolValuta.Size = new System.Drawing.Size(100, 26);
            this.textBoxSimbolValuta.TabIndex = 7;
            // 
            // textBoxRataEuro
            // 
            this.textBoxRataEuro.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxRataEuro.Location = new System.Drawing.Point(200, 399);
            this.textBoxRataEuro.Name = "textBoxRataEuro";
            this.textBoxRataEuro.Size = new System.Drawing.Size(100, 26);
            this.textBoxRataEuro.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buttonSerializare
            // 
            this.buttonSerializare.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonSerializare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSerializare.Location = new System.Drawing.Point(536, 454);
            this.buttonSerializare.Name = "buttonSerializare";
            this.buttonSerializare.Size = new System.Drawing.Size(222, 90);
            this.buttonSerializare.TabIndex = 11;
            this.buttonSerializare.Text = "Confirma";
            this.buttonSerializare.UseVisualStyleBackColor = false;
            this.buttonSerializare.Click += new System.EventHandler(this.buttonSerializare_Click);
            // 
            // modifica_valute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 708);
            this.Controls.Add(this.buttonSerializare);
            this.Controls.Add(this.textBoxRataEuro);
            this.Controls.Add(this.textBoxSimbolValuta);
            this.Controls.Add(this.textBoxNumeValuta);
            this.Controls.Add(this.textBoxCodValuta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "modifica_valute";
            this.Text = "Curs_valutar";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCodValuta;
        private System.Windows.Forms.TextBox textBoxNumeValuta;
        private System.Windows.Forms.TextBox textBoxSimbolValuta;
        private System.Windows.Forms.TextBox textBoxRataEuro;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button buttonSerializare;
    }
}