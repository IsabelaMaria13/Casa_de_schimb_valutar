
namespace Casa_schimb_Valutar_2
{
    partial class transferuri
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.labelTip = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelSuma = new System.Windows.Forms.Label();
            this.tbSuma = new System.Windows.Forms.TextBox();
            this.labelContSursa = new System.Windows.Forms.Label();
            this.labelContDestinatie = new System.Windows.Forms.Label();
            this.tbContSursa = new System.Windows.Forms.TextBox();
            this.tbContDestinatie = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelTitlu = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonBinar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.transferaCriptatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbID.Location = new System.Drawing.Point(195, 164);
            this.tbID.Multiline = true;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(165, 26);
            this.tbID.TabIndex = 1;
            // 
            // cbTip
            // 
            this.cbTip.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbTip.Location = new System.Drawing.Point(195, 254);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(121, 28);
            this.cbTip.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cbTip, "\r\nRON=0\r\nUSD=1\r\nEUR=2\r\nGBP=3\r\nCHF=4\r\nAUD=5\r\nBGN=6\r\nJPY=7\r\nCSZ=8\r\nRUB=9\r\n");
            // 
            // labelTip
            // 
            this.labelTip.AutoSize = true;
            this.labelTip.BackColor = System.Drawing.Color.Transparent;
            this.labelTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTip.Location = new System.Drawing.Point(66, 257);
            this.labelTip.Name = "labelTip";
            this.labelTip.Size = new System.Drawing.Size(123, 20);
            this.labelTip.TabIndex = 3;
            this.labelTip.Text = "Tip tranzactie:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(71, 170);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(118, 20);
            this.labelID.TabIndex = 4;
            this.labelID.Text = "ID tranzacite:";
            // 
            // labelSuma
            // 
            this.labelSuma.AutoSize = true;
            this.labelSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuma.Location = new System.Drawing.Point(40, 214);
            this.labelSuma.Name = "labelSuma";
            this.labelSuma.Size = new System.Drawing.Size(149, 20);
            this.labelSuma.TabIndex = 5;
            this.labelSuma.Text = "Suma tranzactiei:";
            // 
            // tbSuma
            // 
            this.tbSuma.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbSuma.Location = new System.Drawing.Point(195, 207);
            this.tbSuma.Name = "tbSuma";
            this.tbSuma.Size = new System.Drawing.Size(165, 26);
            this.tbSuma.TabIndex = 6;
            // 
            // labelContSursa
            // 
            this.labelContSursa.AutoSize = true;
            this.labelContSursa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContSursa.Location = new System.Drawing.Point(442, 164);
            this.labelContSursa.Name = "labelContSursa";
            this.labelContSursa.Size = new System.Drawing.Size(101, 20);
            this.labelContSursa.TabIndex = 7;
            this.labelContSursa.Text = "Cont sursa:";
            // 
            // labelContDestinatie
            // 
            this.labelContDestinatie.AutoSize = true;
            this.labelContDestinatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContDestinatie.Location = new System.Drawing.Point(407, 207);
            this.labelContDestinatie.Name = "labelContDestinatie";
            this.labelContDestinatie.Size = new System.Drawing.Size(136, 20);
            this.labelContDestinatie.TabIndex = 8;
            this.labelContDestinatie.Text = "Cont destinatie:";
            // 
            // tbContSursa
            // 
            this.tbContSursa.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbContSursa.Location = new System.Drawing.Point(560, 164);
            this.tbContSursa.Multiline = true;
            this.tbContSursa.Name = "tbContSursa";
            this.tbContSursa.Size = new System.Drawing.Size(212, 26);
            this.tbContSursa.TabIndex = 9;
            // 
            // tbContDestinatie
            // 
            this.tbContDestinatie.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbContDestinatie.Location = new System.Drawing.Point(560, 207);
            this.tbContDestinatie.Multiline = true;
            this.tbContDestinatie.Name = "tbContDestinatie";
            this.tbContDestinatie.Size = new System.Drawing.Size(212, 26);
            this.tbContDestinatie.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labelTitlu
            // 
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelTitlu.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTitlu.Location = new System.Drawing.Point(20, 67);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(752, 31);
            this.labelTitlu.TabIndex = 12;
            this.labelTitlu.Text = "Completeaza spatiile de mai jos pentru a efectua un transfer:\r\n";
            this.labelTitlu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBinar
            // 
            this.buttonBinar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonBinar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBinar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBinar.Location = new System.Drawing.Point(519, 351);
            this.buttonBinar.Name = "buttonBinar";
            this.buttonBinar.Size = new System.Drawing.Size(222, 84);
            this.buttonBinar.TabIndex = 13;
            this.buttonBinar.Text = "Serializeaza si transfera";
            this.buttonBinar.UseVisualStyleBackColor = false;
            this.buttonBinar.Click += new System.EventHandler(this.buttonBinar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "*va rugam alegeti moneda in care doriti sa efectuati tranzactia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "*";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transferaCriptatToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(270, 36);
            // 
            // transferaCriptatToolStripMenuItem
            // 
            this.transferaCriptatToolStripMenuItem.Name = "transferaCriptatToolStripMenuItem";
            this.transferaCriptatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.transferaCriptatToolStripMenuItem.Size = new System.Drawing.Size(269, 32);
            this.transferaCriptatToolStripMenuItem.Text = "transfera criptat";
            this.transferaCriptatToolStripMenuItem.Click += new System.EventHandler(this.transferaCriptatToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 465);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 32);
            this.statusStrip1.TabIndex = 16;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(739, 25);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // transferuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBinar);
            this.Controls.Add(this.labelTitlu);
            this.Controls.Add(this.tbContDestinatie);
            this.Controls.Add(this.tbContSursa);
            this.Controls.Add(this.labelContDestinatie);
            this.Controls.Add(this.labelContSursa);
            this.Controls.Add(this.tbSuma);
            this.Controls.Add(this.labelSuma);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelTip);
            this.Controls.Add(this.cbTip);
            this.Controls.Add(this.tbID);
            this.Name = "transferuri";
            this.Text = "Transfera_bani";
            this.Load += new System.EventHandler(this.Transfera_bani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.Label labelTip;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelSuma;
        private System.Windows.Forms.TextBox tbSuma;
        private System.Windows.Forms.Label labelContSursa;
        private System.Windows.Forms.Label labelContDestinatie;
        private System.Windows.Forms.TextBox tbContSursa;
        private System.Windows.Forms.TextBox tbContDestinatie;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonBinar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem transferaCriptatToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}