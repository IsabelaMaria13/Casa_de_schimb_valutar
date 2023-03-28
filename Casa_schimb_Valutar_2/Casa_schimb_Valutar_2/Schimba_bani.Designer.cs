
namespace Casa_schimb_Valutar_2
{
    partial class Schimba_bani
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbSuma = new System.Windows.Forms.TextBox();
            this.labelSuma = new System.Windows.Forms.Label();
            this.labelDAT = new System.Windows.Forms.Label();
            this.cbDAT = new System.Windows.Forms.ComboBox();
            this.labelPRIMIT = new System.Windows.Forms.Label();
            this.tbCumparare = new System.Windows.Forms.TextBox();
            this.labelCumparare = new System.Windows.Forms.Label();
            this.labelVanzare = new System.Windows.Forms.Label();
            this.tbVanzare = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ConfirmareCumparare = new System.Windows.Forms.Button();
            this.ConfirmareVanzare = new System.Windows.Forms.Button();
            this.exchangeRateTextBox = new System.Windows.Forms.TextBox();
            this.cbPRIMIT = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.exchangeRateTextBox2 = new System.Windows.Forms.TextBox();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.tbEURO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cumparaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vindeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(42, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(697, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pentru a efectua schimbul valutar, va rugam alegeti una dintre variante:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(577, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 108);
            this.button1.TabIndex = 2;
            this.button1.Text = "VANZARE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 108);
            this.button2.TabIndex = 3;
            this.button2.Text = "CUMPARARE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbSuma
            // 
            this.tbSuma.BackColor = System.Drawing.Color.LightGray;
            this.tbSuma.Location = new System.Drawing.Point(120, 104);
            this.tbSuma.Name = "tbSuma";
            this.tbSuma.Size = new System.Drawing.Size(100, 26);
            this.tbSuma.TabIndex = 4;
            this.tbSuma.Visible = false;
            // 
            // labelSuma
            // 
            this.labelSuma.AutoSize = true;
            this.labelSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuma.Location = new System.Drawing.Point(47, 109);
            this.labelSuma.Name = "labelSuma";
            this.labelSuma.Size = new System.Drawing.Size(60, 20);
            this.labelSuma.TabIndex = 5;
            this.labelSuma.Text = "Suma:";
            this.labelSuma.Visible = false;
            // 
            // labelDAT
            // 
            this.labelDAT.AutoSize = true;
            this.labelDAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDAT.Location = new System.Drawing.Point(55, 154);
            this.labelDAT.Name = "labelDAT";
            this.labelDAT.Size = new System.Drawing.Size(41, 20);
            this.labelDAT.TabIndex = 6;
            this.labelDAT.Text = "Din:";
            this.labelDAT.Visible = false;
            // 
            // cbDAT
            // 
            this.cbDAT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbDAT.FormattingEnabled = true;
            this.cbDAT.Items.AddRange(new object[] {
            "RON",
            "USD",
            "EUR",
            "GBP",
            "CHF",
            "AUD",
            "BGN",
            "JPY",
            "CZK",
            "RUB"});
            this.cbDAT.Location = new System.Drawing.Point(120, 151);
            this.cbDAT.Name = "cbDAT";
            this.cbDAT.Size = new System.Drawing.Size(121, 28);
            this.cbDAT.TabIndex = 7;
            this.cbDAT.Visible = false;
            this.cbDAT.SelectedIndexChanged += new System.EventHandler(this.cbDAT_SelectedIndexChanged);
            // 
            // labelPRIMIT
            // 
            this.labelPRIMIT.AutoSize = true;
            this.labelPRIMIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPRIMIT.Location = new System.Drawing.Point(66, 204);
            this.labelPRIMIT.Name = "labelPRIMIT";
            this.labelPRIMIT.Size = new System.Drawing.Size(30, 20);
            this.labelPRIMIT.TabIndex = 8;
            this.labelPRIMIT.Text = "In:";
            this.labelPRIMIT.Visible = false;
            // 
            // tbCumparare
            // 
            this.tbCumparare.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbCumparare.Location = new System.Drawing.Point(544, 148);
            this.tbCumparare.Name = "tbCumparare";
            this.tbCumparare.ReadOnly = true;
            this.tbCumparare.Size = new System.Drawing.Size(100, 26);
            this.tbCumparare.TabIndex = 10;
            this.tbCumparare.Visible = false;
            // 
            // labelCumparare
            // 
            this.labelCumparare.AutoSize = true;
            this.labelCumparare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCumparare.Location = new System.Drawing.Point(412, 151);
            this.labelCumparare.Name = "labelCumparare";
            this.labelCumparare.Size = new System.Drawing.Size(126, 20);
            this.labelCumparare.TabIndex = 11;
            this.labelCumparare.Text = "Cumparare cu:";
            this.labelCumparare.Visible = false;
            // 
            // labelVanzare
            // 
            this.labelVanzare.AutoSize = true;
            this.labelVanzare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVanzare.Location = new System.Drawing.Point(433, 201);
            this.labelVanzare.Name = "labelVanzare";
            this.labelVanzare.Size = new System.Drawing.Size(105, 20);
            this.labelVanzare.TabIndex = 12;
            this.labelVanzare.Text = "Vanzare cu:";
            this.labelVanzare.Visible = false;
            // 
            // tbVanzare
            // 
            this.tbVanzare.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbVanzare.Location = new System.Drawing.Point(545, 201);
            this.tbVanzare.Name = "tbVanzare";
            this.tbVanzare.Size = new System.Drawing.Size(100, 26);
            this.tbVanzare.TabIndex = 13;
            this.tbVanzare.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ConfirmareCumparare
            // 
            this.ConfirmareCumparare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ConfirmareCumparare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmareCumparare.Location = new System.Drawing.Point(577, 233);
            this.ConfirmareCumparare.Name = "ConfirmareCumparare";
            this.ConfirmareCumparare.Size = new System.Drawing.Size(141, 41);
            this.ConfirmareCumparare.TabIndex = 14;
            this.ConfirmareCumparare.Text = "CONFIRMA";
            this.ConfirmareCumparare.UseVisualStyleBackColor = false;
            this.ConfirmareCumparare.Visible = false;
            this.ConfirmareCumparare.Click += new System.EventHandler(this.ConfirmareCumparare_Click);
            // 
            // ConfirmareVanzare
            // 
            this.ConfirmareVanzare.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConfirmareVanzare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmareVanzare.Location = new System.Drawing.Point(577, 280);
            this.ConfirmareVanzare.Name = "ConfirmareVanzare";
            this.ConfirmareVanzare.Size = new System.Drawing.Size(141, 41);
            this.ConfirmareVanzare.TabIndex = 15;
            this.ConfirmareVanzare.Text = "CONFIRMA";
            this.ConfirmareVanzare.UseVisualStyleBackColor = false;
            this.ConfirmareVanzare.Visible = false;
            this.ConfirmareVanzare.Click += new System.EventHandler(this.ConfirmareVanzare_Click);
            // 
            // exchangeRateTextBox
            // 
            this.exchangeRateTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.exchangeRateTextBox.Location = new System.Drawing.Point(247, 203);
            this.exchangeRateTextBox.Name = "exchangeRateTextBox";
            this.exchangeRateTextBox.Size = new System.Drawing.Size(100, 26);
            this.exchangeRateTextBox.TabIndex = 16;
            this.exchangeRateTextBox.Visible = false;
            // 
            // cbPRIMIT
            // 
            this.cbPRIMIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cbPRIMIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPRIMIT.Location = new System.Drawing.Point(120, 204);
            this.cbPRIMIT.Name = "cbPRIMIT";
            this.cbPRIMIT.ReadOnly = true;
            this.cbPRIMIT.Size = new System.Drawing.Size(100, 26);
            this.cbPRIMIT.TabIndex = 17;
            this.cbPRIMIT.Text = "EUR";
            this.cbPRIMIT.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(650, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 30);
            this.button3.TabIndex = 18;
            this.button3.Text = "click";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(651, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 29);
            this.button4.TabIndex = 19;
            this.button4.Text = "click";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // exchangeRateTextBox2
            // 
            this.exchangeRateTextBox2.Location = new System.Drawing.Point(248, 204);
            this.exchangeRateTextBox2.Name = "exchangeRateTextBox2";
            this.exchangeRateTextBox2.Size = new System.Drawing.Size(100, 26);
            this.exchangeRateTextBox2.TabIndex = 20;
            this.exchangeRateTextBox2.Visible = false;
            // 
            // cb2
            // 
            this.cb2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cb2.FormattingEnabled = true;
            this.cb2.Items.AddRange(new object[] {
            "RON",
            "USD",
            "EUR",
            "GBP",
            "CHF",
            "AUD",
            "BGN",
            "JPY",
            "CZK",
            "RUB"});
            this.cb2.Location = new System.Drawing.Point(120, 206);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(121, 28);
            this.cb2.TabIndex = 21;
            this.cb2.Visible = false;
            this.cb2.SelectedIndexChanged += new System.EventHandler(this.cb2_SelectedIndexChanged);
            // 
            // tbEURO
            // 
            this.tbEURO.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbEURO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEURO.Location = new System.Drawing.Point(120, 154);
            this.tbEURO.Name = "tbEURO";
            this.tbEURO.Size = new System.Drawing.Size(100, 26);
            this.tbEURO.TabIndex = 22;
            this.tbEURO.Text = "EUR";
            this.tbEURO.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "*";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "*cursul valutar al tranzactiei dvs.";
            this.label3.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cumparaToolStripMenuItem,
            this.vindeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(215, 68);
            // 
            // cumparaToolStripMenuItem
            // 
            this.cumparaToolStripMenuItem.Name = "cumparaToolStripMenuItem";
            this.cumparaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.cumparaToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.cumparaToolStripMenuItem.Text = "cumpara";
            this.cumparaToolStripMenuItem.Click += new System.EventHandler(this.cumparaToolStripMenuItem_Click);
            // 
            // vindeToolStripMenuItem
            // 
            this.vindeToolStripMenuItem.Name = "vindeToolStripMenuItem";
            this.vindeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.vindeToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.vindeToolStripMenuItem.Text = "vinde";
            this.vindeToolStripMenuItem.Click += new System.EventHandler(this.vindeToolStripMenuItem_Click);
            // 
            // Schimba_bani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEURO);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.exchangeRateTextBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cbPRIMIT);
            this.Controls.Add(this.exchangeRateTextBox);
            this.Controls.Add(this.ConfirmareVanzare);
            this.Controls.Add(this.ConfirmareCumparare);
            this.Controls.Add(this.tbVanzare);
            this.Controls.Add(this.labelVanzare);
            this.Controls.Add(this.labelCumparare);
            this.Controls.Add(this.tbCumparare);
            this.Controls.Add(this.labelPRIMIT);
            this.Controls.Add(this.cbDAT);
            this.Controls.Add(this.labelDAT);
            this.Controls.Add(this.labelSuma);
            this.Controls.Add(this.tbSuma);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Schimba_bani";
            this.Text = "Schimba_bani";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbSuma;
        private System.Windows.Forms.Label labelSuma;
        private System.Windows.Forms.Label labelDAT;
        private System.Windows.Forms.ComboBox cbDAT;
        private System.Windows.Forms.Label labelPRIMIT;
        private System.Windows.Forms.TextBox tbCumparare;
        private System.Windows.Forms.Label labelCumparare;
        private System.Windows.Forms.Label labelVanzare;
        private System.Windows.Forms.TextBox tbVanzare;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button ConfirmareCumparare;
        private System.Windows.Forms.Button ConfirmareVanzare;
        private System.Windows.Forms.TextBox exchangeRateTextBox;
        private System.Windows.Forms.TextBox cbPRIMIT;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbEURO;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.TextBox exchangeRateTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cumparaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vindeToolStripMenuItem;
    }
}