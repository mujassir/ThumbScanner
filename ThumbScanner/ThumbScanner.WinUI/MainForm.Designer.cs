namespace ThumbScanner.WinUI
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enrollmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtMemberCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodeMessage = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(743, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enrollmentToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // enrollmentToolStripMenuItem
            // 
            this.enrollmentToolStripMenuItem.Name = "enrollmentToolStripMenuItem";
            this.enrollmentToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.enrollmentToolStripMenuItem.Text = "Enrollment";
            this.enrollmentToolStripMenuItem.Click += new System.EventHandler(this.enrollmentToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(173, 173);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(276, 20);
            this.txtDesignation.TabIndex = 10;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(173, 139);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(276, 20);
            this.txtFatherName.TabIndex = 8;
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(173, 105);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(276, 20);
            this.txtMemberName.TabIndex = 6;
            // 
            // txtMemberCode
            // 
            this.txtMemberCode.Location = new System.Drawing.Point(173, 71);
            this.txtMemberCode.Name = "txtMemberCode";
            this.txtMemberCode.Size = new System.Drawing.Size(100, 20);
            this.txtMemberCode.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(70, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Member Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(78, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Father Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(83, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Designation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(73, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Member Code";
            // 
            // lblCodeMessage
            // 
            this.lblCodeMessage.AutoSize = true;
            this.lblCodeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeMessage.ForeColor = System.Drawing.Color.Red;
            this.lblCodeMessage.Location = new System.Drawing.Point(279, 73);
            this.lblCodeMessage.Name = "lblCodeMessage";
            this.lblCodeMessage.Size = new System.Drawing.Size(0, 16);
            this.lblCodeMessage.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(743, 422);
            this.Controls.Add(this.lblCodeMessage);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.txtMemberCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Thumb Verifier";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enrollmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtMemberCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodeMessage;

    }
}
