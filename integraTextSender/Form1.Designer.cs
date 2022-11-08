namespace integraTextSender
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
            this.numChan = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxAutoSend = new System.Windows.Forms.CheckBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.cmbMididev = new System.Windows.Forms.ComboBox();
            this.llblSysEx = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numChan)).BeginInit();
            this.SuspendLayout();
            // 
            // numChan
            // 
            this.numChan.Enabled = false;
            this.numChan.Location = new System.Drawing.Point(27, 29);
            this.numChan.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numChan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numChan.Name = "numChan";
            this.numChan.Size = new System.Drawing.Size(51, 20);
            this.numChan.TabIndex = 0;
            this.numChan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Channel";
            // 
            // tbxText
            // 
            this.tbxText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxText.Enabled = false;
            this.tbxText.Location = new System.Drawing.Point(104, 29);
            this.tbxText.Name = "tbxText";
            this.tbxText.Size = new System.Drawing.Size(438, 20);
            this.tbxText.TabIndex = 2;
            this.tbxText.TextChanged += new System.EventHandler(this.tbxText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Text";
            // 
            // cbxAutoSend
            // 
            this.cbxAutoSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxAutoSend.AutoSize = true;
            this.cbxAutoSend.Enabled = false;
            this.cbxAutoSend.Location = new System.Drawing.Point(387, 88);
            this.cbxAutoSend.Name = "cbxAutoSend";
            this.cbxAutoSend.Size = new System.Drawing.Size(74, 17);
            this.cbxAutoSend.TabIndex = 4;
            this.cbxAutoSend.Text = "Auto send";
            this.cbxAutoSend.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(467, 84);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // cmbMididev
            // 
            this.cmbMididev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMididev.FormattingEnabled = true;
            this.cmbMididev.Location = new System.Drawing.Point(27, 84);
            this.cmbMididev.Name = "cmbMididev";
            this.cmbMididev.Size = new System.Drawing.Size(251, 21);
            this.cmbMididev.TabIndex = 6;
            this.cmbMididev.SelectedIndexChanged += new System.EventHandler(this.cmbMididev_SelectedIndexChanged);
            // 
            // llblSysEx
            // 
            this.llblSysEx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llblSysEx.Location = new System.Drawing.Point(27, 56);
            this.llblSysEx.Name = "llblSysEx";
            this.llblSysEx.Size = new System.Drawing.Size(515, 21);
            this.llblSysEx.TabIndex = 7;
            this.llblSysEx.TabStop = true;
            this.llblSysEx.Text = "llblSysEx";
            this.llblSysEx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.llblSysEx.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSysEx_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 122);
            this.Controls.Add(this.llblSysEx);
            this.Controls.Add(this.cmbMididev);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.cbxAutoSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numChan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numChan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numChan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbxAutoSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox cmbMididev;
        private System.Windows.Forms.LinkLabel llblSysEx;
    }
}

