
namespace Casa_schimb_Valutar_2
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
            this.titlu = new System.Windows.Forms.TextBox();
            this.utilizator = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.ComboBox();
            this.administrator = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // titlu
            // 
            this.titlu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.titlu.Font = new System.Drawing.Font("Microsoft Uighur", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlu.Location = new System.Drawing.Point(68, 12);
            this.titlu.Multiline = true;
            this.titlu.Name = "titlu";
            this.titlu.ReadOnly = true;
            this.titlu.Size = new System.Drawing.Size(631, 97);
            this.titlu.TabIndex = 0;
            this.titlu.Text = "BUN VENIT LA CASA DE SCHIMB VALUTAR!\r\nAlegeti din urmatoarele optiuni:\r\n";
            this.titlu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.titlu.TextChanged += new System.EventHandler(this.titlu_TextChanged);
            // 
            // utilizator
            // 
            this.utilizator.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.utilizator.FormattingEnabled = true;
            this.utilizator.Items.AddRange(new object[] {
            "Verifica curs valutar",
            "Schimba bani ",
            "Transfera bani"});
            this.utilizator.Location = new System.Drawing.Point(68, 206);
            this.utilizator.Name = "utilizator";
            this.utilizator.Size = new System.Drawing.Size(209, 28);
            this.utilizator.TabIndex = 1;
            this.utilizator.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(562, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 66);
            this.button1.TabIndex = 3;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.user.FormattingEnabled = true;
            this.user.Items.AddRange(new object[] {
            "Administrator",
            "Utilizator"});
            this.user.Location = new System.Drawing.Point(68, 149);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(209, 28);
            this.user.TabIndex = 4;
            this.user.SelectionChangeCommitted += new System.EventHandler(this.user_SelectionChangeCommitted);
            // 
            // administrator
            // 
            this.administrator.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.administrator.FormattingEnabled = true;
            this.administrator.Items.AddRange(new object[] {
            "curs valutar",
            "tranzactii",
            "adauga valute"});
            this.administrator.Location = new System.Drawing.Point(68, 206);
            this.administrator.Name = "administrator";
            this.administrator.Size = new System.Drawing.Size(209, 28);
            this.administrator.TabIndex = 5;
            this.administrator.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.administrator);
            this.Controls.Add(this.user);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.utilizator);
            this.Controls.Add(this.titlu);
            this.Name = "Form1";
            this.Text = "Meniu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titlu;
        private System.Windows.Forms.ComboBox utilizator;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox user;
        private System.Windows.Forms.ComboBox administrator;
    }
}

