namespace PlayLotto
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
            this.tabLotto = new System.Windows.Forms.TabControl();
            this.tabQuickPick = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.listNumbers = new System.Windows.Forms.ListBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.cmbNumbers = new System.Windows.Forms.ComboBox();
            this.lblNumLines = new System.Windows.Forms.Label();
            this.tabSelectOwnNum = new System.Windows.Forms.TabPage();
            this.btnClearTicket = new System.Windows.Forms.Button();
            this.listNumbers2 = new System.Windows.Forms.ListBox();
            this.btnAddLine = new System.Windows.Forms.Button();
            this.btnClearLine = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAddToLine = new System.Windows.Forms.Button();
            this.cmbNumber2 = new System.Windows.Forms.ComboBox();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.myMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.subMnuQuickPick = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClearTicket = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuSelectionTicket = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClearLine = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClearTickets = new System.Windows.Forms.ToolStripMenuItem();
            this.tabLotto.SuspendLayout();
            this.tabQuickPick.SuspendLayout();
            this.tabSelectOwnNum.SuspendLayout();
            this.myMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLotto
            // 
            this.tabLotto.Controls.Add(this.tabQuickPick);
            this.tabLotto.Controls.Add(this.tabSelectOwnNum);
            this.tabLotto.Location = new System.Drawing.Point(0, 29);
            this.tabLotto.Name = "tabLotto";
            this.tabLotto.SelectedIndex = 0;
            this.tabLotto.Size = new System.Drawing.Size(331, 317);
            this.tabLotto.TabIndex = 0;
            // 
            // tabQuickPick
            // 
            this.tabQuickPick.Controls.Add(this.btnClear);
            this.tabQuickPick.Controls.Add(this.listNumbers);
            this.tabQuickPick.Controls.Add(this.btnPlay);
            this.tabQuickPick.Controls.Add(this.cmbNumbers);
            this.tabQuickPick.Controls.Add(this.lblNumLines);
            this.tabQuickPick.Location = new System.Drawing.Point(4, 22);
            this.tabQuickPick.Name = "tabQuickPick";
            this.tabQuickPick.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuickPick.Size = new System.Drawing.Size(323, 291);
            this.tabQuickPick.TabIndex = 0;
            this.tabQuickPick.Text = "Quick Pick";
            this.tabQuickPick.UseVisualStyleBackColor = true;
            this.tabQuickPick.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(238, 219);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear Ticket";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // listNumbers
            // 
            this.listNumbers.FormattingEnabled = true;
            this.listNumbers.Location = new System.Drawing.Point(13, 34);
            this.listNumbers.Name = "listNumbers";
            this.listNumbers.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listNumbers.Size = new System.Drawing.Size(300, 173);
            this.listNumbers.TabIndex = 3;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(160, 5);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(136, 23);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play Lotto Quick Pick";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // cmbNumbers
            // 
            this.cmbNumbers.FormattingEnabled = true;
            this.cmbNumbers.Location = new System.Drawing.Point(99, 7);
            this.cmbNumbers.Name = "cmbNumbers";
            this.cmbNumbers.Size = new System.Drawing.Size(40, 21);
            this.cmbNumbers.TabIndex = 1;
            this.cmbNumbers.SelectedIndexChanged += new System.EventHandler(this.cmbNumbers_SelectedIndexChanged);
            // 
            // lblNumLines
            // 
            this.lblNumLines.AutoSize = true;
            this.lblNumLines.Location = new System.Drawing.Point(6, 10);
            this.lblNumLines.Name = "lblNumLines";
            this.lblNumLines.Size = new System.Drawing.Size(86, 13);
            this.lblNumLines.TabIndex = 0;
            this.lblNumLines.Text = "Number Of Lines";
            this.lblNumLines.Click += new System.EventHandler(this.label2_Click);
            // 
            // tabSelectOwnNum
            // 
            this.tabSelectOwnNum.Controls.Add(this.btnClearTicket);
            this.tabSelectOwnNum.Controls.Add(this.listNumbers2);
            this.tabSelectOwnNum.Controls.Add(this.btnAddLine);
            this.tabSelectOwnNum.Controls.Add(this.btnClearLine);
            this.tabSelectOwnNum.Controls.Add(this.textBox6);
            this.tabSelectOwnNum.Controls.Add(this.textBox5);
            this.tabSelectOwnNum.Controls.Add(this.textBox4);
            this.tabSelectOwnNum.Controls.Add(this.textBox3);
            this.tabSelectOwnNum.Controls.Add(this.textBox2);
            this.tabSelectOwnNum.Controls.Add(this.textBox1);
            this.tabSelectOwnNum.Controls.Add(this.btnAddToLine);
            this.tabSelectOwnNum.Controls.Add(this.cmbNumber2);
            this.tabSelectOwnNum.Controls.Add(this.lblLine);
            this.tabSelectOwnNum.Controls.Add(this.lblNumber);
            this.tabSelectOwnNum.Location = new System.Drawing.Point(4, 22);
            this.tabSelectOwnNum.Name = "tabSelectOwnNum";
            this.tabSelectOwnNum.Padding = new System.Windows.Forms.Padding(3);
            this.tabSelectOwnNum.Size = new System.Drawing.Size(323, 291);
            this.tabSelectOwnNum.TabIndex = 1;
            this.tabSelectOwnNum.Text = "Select Own Numbers";
            this.tabSelectOwnNum.UseVisualStyleBackColor = true;
            this.tabSelectOwnNum.Click += new System.EventHandler(this.tabSelectOwnNum_Click);
            // 
            // btnClearTicket
            // 
            this.btnClearTicket.Location = new System.Drawing.Point(232, 261);
            this.btnClearTicket.Name = "btnClearTicket";
            this.btnClearTicket.Size = new System.Drawing.Size(75, 24);
            this.btnClearTicket.TabIndex = 13;
            this.btnClearTicket.Text = "Clear Ticket";
            this.btnClearTicket.UseVisualStyleBackColor = true;
            // 
            // listNumbers2
            // 
            this.listNumbers2.FormattingEnabled = true;
            this.listNumbers2.Location = new System.Drawing.Point(9, 117);
            this.listNumbers2.Name = "listNumbers2";
            this.listNumbers2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listNumbers2.Size = new System.Drawing.Size(298, 134);
            this.listNumbers2.TabIndex = 12;
            // 
            // btnAddLine
            // 
            this.btnAddLine.Location = new System.Drawing.Point(232, 82);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(75, 23);
            this.btnAddLine.TabIndex = 11;
            this.btnAddLine.Text = "Add Line";
            this.btnAddLine.UseVisualStyleBackColor = true;
            // 
            // btnClearLine
            // 
            this.btnClearLine.Location = new System.Drawing.Point(232, 53);
            this.btnClearLine.Name = "btnClearLine";
            this.btnClearLine.Size = new System.Drawing.Size(75, 23);
            this.btnClearLine.TabIndex = 10;
            this.btnClearLine.Text = "Clear Line";
            this.btnClearLine.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(193, 55);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(23, 20);
            this.textBox6.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(156, 55);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(23, 20);
            this.textBox5.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(119, 55);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(23, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(82, 55);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(23, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(46, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(23, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(23, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAddToLine
            // 
            this.btnAddToLine.Location = new System.Drawing.Point(182, 5);
            this.btnAddToLine.Name = "btnAddToLine";
            this.btnAddToLine.Size = new System.Drawing.Size(75, 23);
            this.btnAddToLine.TabIndex = 3;
            this.btnAddToLine.Text = "Add to Line";
            this.btnAddToLine.UseVisualStyleBackColor = true;
            this.btnAddToLine.Click += new System.EventHandler(this.btnAddToLine_Click);
            // 
            // cmbNumber2
            // 
            this.cmbNumber2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumber2.FormattingEnabled = true;
            this.cmbNumber2.Location = new System.Drawing.Point(59, 7);
            this.cmbNumber2.Name = "cmbNumber2";
            this.cmbNumber2.Size = new System.Drawing.Size(116, 21);
            this.cmbNumber2.TabIndex = 2;
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Location = new System.Drawing.Point(6, 37);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(30, 13);
            this.lblLine.TabIndex = 1;
            this.lblLine.Text = "Line:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(6, 10);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(47, 13);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Number:";
            this.lblNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // myMenuStrip
            // 
            this.myMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClear});
            this.myMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.myMenuStrip.Name = "myMenuStrip";
            this.myMenuStrip.Size = new System.Drawing.Size(331, 24);
            this.myMenuStrip.TabIndex = 1;
            this.myMenuStrip.Text = "menuStrip1";
            // 
            // mnuClear
            // 
            this.mnuClear.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMnuQuickPick,
            this.subMenuSelectionTicket});
            this.mnuClear.Name = "mnuClear";
            this.mnuClear.Size = new System.Drawing.Size(46, 20);
            this.mnuClear.Text = "Clear";
            this.mnuClear.Click += new System.EventHandler(this.mnuClear_Click);
            // 
            // subMnuQuickPick
            // 
            this.subMnuQuickPick.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClearTicket});
            this.subMnuQuickPick.Name = "subMnuQuickPick";
            this.subMnuQuickPick.Size = new System.Drawing.Size(185, 22);
            this.subMnuQuickPick.Text = "QuickPick Ticket";
            // 
            // mnuClearTicket
            // 
            this.mnuClearTicket.Name = "mnuClearTicket";
            this.mnuClearTicket.Size = new System.Drawing.Size(152, 22);
            this.mnuClearTicket.Text = "Clear Ticket";
            this.mnuClearTicket.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // subMenuSelectionTicket
            // 
            this.subMenuSelectionTicket.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClearLine,
            this.mnuClearTickets});
            this.subMenuSelectionTicket.Name = "subMenuSelectionTicket";
            this.subMenuSelectionTicket.Size = new System.Drawing.Size(185, 22);
            this.subMenuSelectionTicket.Text = "Own Selection Ticket";
            // 
            // mnuClearLine
            // 
            this.mnuClearLine.Name = "mnuClearLine";
            this.mnuClearLine.Size = new System.Drawing.Size(141, 22);
            this.mnuClearLine.Text = "Clear Line";
            // 
            // mnuClearTickets
            // 
            this.mnuClearTickets.Name = "mnuClearTickets";
            this.mnuClearTickets.Size = new System.Drawing.Size(141, 22);
            this.mnuClearTickets.Text = "Clear Tickets";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 347);
            this.Controls.Add(this.tabLotto);
            this.Controls.Add(this.myMenuStrip);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play Lotto Online";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabLotto.ResumeLayout(false);
            this.tabQuickPick.ResumeLayout(false);
            this.tabQuickPick.PerformLayout();
            this.tabSelectOwnNum.ResumeLayout(false);
            this.tabSelectOwnNum.PerformLayout();
            this.myMenuStrip.ResumeLayout(false);
            this.myMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabLotto;
        private System.Windows.Forms.TabPage tabQuickPick;
        private System.Windows.Forms.TabPage tabSelectOwnNum;
        private System.Windows.Forms.MenuStrip myMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuClear;
        private System.Windows.Forms.ToolStripMenuItem subMnuQuickPick;
        private System.Windows.Forms.ToolStripMenuItem mnuClearTicket;
        private System.Windows.Forms.ToolStripMenuItem subMenuSelectionTicket;
        private System.Windows.Forms.ToolStripMenuItem mnuClearLine;
        private System.Windows.Forms.ToolStripMenuItem mnuClearTickets;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblNumLines;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ComboBox cmbNumbers;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox listNumbers;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.ComboBox cmbNumber2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAddToLine;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnAddLine;
        private System.Windows.Forms.Button btnClearLine;
        private System.Windows.Forms.ListBox listNumbers2;
        private System.Windows.Forms.Button btnClearTicket;
    }
}

