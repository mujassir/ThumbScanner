namespace ThumbScanner.WinUI
{
    partial class EnrollmentForm
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
            System.Windows.Forms.Label StatusLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMemberCode = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.lblCodeMessage = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.StatusText = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnCapture = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk5 = new System.Windows.Forms.CheckBox();
            this.chk9 = new System.Windows.Forms.CheckBox();
            this.chk10 = new System.Windows.Forms.CheckBox();
            this.chk4 = new System.Windows.Forms.CheckBox();
            this.chk7 = new System.Windows.Forms.CheckBox();
            this.chk8 = new System.Windows.Forms.CheckBox();
            this.chk6 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.imgPicture = new System.Windows.Forms.PictureBox();
            this.pbImpression1 = new System.Windows.Forms.PictureBox();
            this.pbImpression2 = new System.Windows.Forms.PictureBox();
            this.pbImpression3 = new System.Windows.Forms.PictureBox();
            StatusLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImpression1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImpression2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImpression3)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new System.Drawing.Point(441, 225);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new System.Drawing.Size(40, 13);
            StatusLabel.TabIndex = 10;
            StatusLabel.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(41, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Designation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(36, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Father Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(28, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Member Name";
            // 
            // txtMemberCode
            // 
            this.txtMemberCode.Location = new System.Drawing.Point(131, 20);
            this.txtMemberCode.Name = "txtMemberCode";
            this.txtMemberCode.Size = new System.Drawing.Size(100, 20);
            this.txtMemberCode.TabIndex = 0;
            this.txtMemberCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMemberCode_KeyDown);
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(131, 54);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(276, 20);
            this.txtMemberName.TabIndex = 1;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(131, 88);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(276, 20);
            this.txtFatherName.TabIndex = 2;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(131, 122);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(276, 20);
            this.txtDesignation.TabIndex = 3;
            // 
            // lblCodeMessage
            // 
            this.lblCodeMessage.AutoSize = true;
            this.lblCodeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeMessage.ForeColor = System.Drawing.Color.Red;
            this.lblCodeMessage.Location = new System.Drawing.Point(249, 53);
            this.lblCodeMessage.Name = "lblCodeMessage";
            this.lblCodeMessage.Size = new System.Drawing.Size(0, 16);
            this.lblCodeMessage.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(556, 453);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 27);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StatusText
            // 
            this.StatusText.BackColor = System.Drawing.SystemColors.Window;
            this.StatusText.Location = new System.Drawing.Point(444, 241);
            this.StatusText.Multiline = true;
            this.StatusText.Name = "StatusText";
            this.StatusText.ReadOnly = true;
            this.StatusText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.StatusText.Size = new System.Drawing.Size(200, 187);
            this.StatusText.TabIndex = 11;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(441, 6);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(68, 13);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Start Camera";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnCapture
            // 
            this.btnCapture.AutoSize = true;
            this.btnCapture.Location = new System.Drawing.Point(600, 6);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(44, 13);
            this.btnCapture.TabIndex = 15;
            this.btnCapture.TabStop = true;
            this.btnCapture.Text = "Capture";
            this.btnCapture.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ThumbScanner.WinUI.Properties.Resources.hands;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.chk3);
            this.panel1.Controls.Add(this.chk5);
            this.panel1.Controls.Add(this.chk9);
            this.panel1.Controls.Add(this.chk10);
            this.panel1.Controls.Add(this.chk4);
            this.panel1.Controls.Add(this.chk7);
            this.panel1.Controls.Add(this.chk8);
            this.panel1.Controls.Add(this.chk6);
            this.panel1.Controls.Add(this.chk2);
            this.panel1.Controls.Add(this.chk1);
            this.panel1.Location = new System.Drawing.Point(44, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 210);
            this.panel1.TabIndex = 16;
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Location = new System.Drawing.Point(83, 7);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(15, 14);
            this.chk3.TabIndex = 6;
            this.chk3.UseVisualStyleBackColor = true;
            // 
            // chk5
            // 
            this.chk5.AutoSize = true;
            this.chk5.Location = new System.Drawing.Point(159, 82);
            this.chk5.Name = "chk5";
            this.chk5.Size = new System.Drawing.Size(15, 14);
            this.chk5.TabIndex = 8;
            this.chk5.UseVisualStyleBackColor = true;
            // 
            // chk9
            // 
            this.chk9.AutoSize = true;
            this.chk9.Location = new System.Drawing.Point(328, 2);
            this.chk9.Name = "chk9";
            this.chk9.Size = new System.Drawing.Size(15, 14);
            this.chk9.TabIndex = 7;
            this.chk9.UseVisualStyleBackColor = true;
            // 
            // chk10
            // 
            this.chk10.AutoSize = true;
            this.chk10.Location = new System.Drawing.Point(349, 30);
            this.chk10.Name = "chk10";
            this.chk10.Size = new System.Drawing.Size(15, 14);
            this.chk10.TabIndex = 6;
            this.chk10.UseVisualStyleBackColor = true;
            // 
            // chk4
            // 
            this.chk4.AutoSize = true;
            this.chk4.Location = new System.Drawing.Point(131, 3);
            this.chk4.Name = "chk4";
            this.chk4.Size = new System.Drawing.Size(15, 14);
            this.chk4.TabIndex = 5;
            this.chk4.UseVisualStyleBackColor = true;
            // 
            // chk7
            // 
            this.chk7.AutoSize = true;
            this.chk7.Location = new System.Drawing.Point(213, 7);
            this.chk7.Name = "chk7";
            this.chk7.Size = new System.Drawing.Size(15, 14);
            this.chk7.TabIndex = 4;
            this.chk7.UseVisualStyleBackColor = true;
            // 
            // chk8
            // 
            this.chk8.AutoSize = true;
            this.chk8.Location = new System.Drawing.Point(272, 7);
            this.chk8.Name = "chk8";
            this.chk8.Size = new System.Drawing.Size(15, 14);
            this.chk8.TabIndex = 3;
            this.chk8.UseVisualStyleBackColor = true;
            // 
            // chk6
            // 
            this.chk6.AutoSize = true;
            this.chk6.Location = new System.Drawing.Point(191, 82);
            this.chk6.Name = "chk6";
            this.chk6.Size = new System.Drawing.Size(15, 14);
            this.chk6.TabIndex = 2;
            this.chk6.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Location = new System.Drawing.Point(30, 2);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(15, 14);
            this.chk2.TabIndex = 1;
            this.chk2.UseVisualStyleBackColor = true;
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Location = new System.Drawing.Point(5, 28);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(15, 14);
            this.chk1.TabIndex = 0;
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // imgPicture
            // 
            this.imgPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgPicture.Image = global::ThumbScanner.WinUI.Properties.Resources.no_image_blog_one;
            this.imgPicture.Location = new System.Drawing.Point(444, 22);
            this.imgPicture.Name = "imgPicture";
            this.imgPicture.Size = new System.Drawing.Size(200, 200);
            this.imgPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPicture.TabIndex = 12;
            this.imgPicture.TabStop = false;
            // 
            // pbImpression1
            // 
            this.pbImpression1.BackColor = System.Drawing.SystemColors.Window;
            this.pbImpression1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImpression1.Location = new System.Drawing.Point(44, 375);
            this.pbImpression1.Name = "pbImpression1";
            this.pbImpression1.Size = new System.Drawing.Size(116, 119);
            this.pbImpression1.TabIndex = 6;
            this.pbImpression1.TabStop = false;
            // 
            // pbImpression2
            // 
            this.pbImpression2.BackColor = System.Drawing.SystemColors.Window;
            this.pbImpression2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImpression2.Location = new System.Drawing.Point(169, 375);
            this.pbImpression2.Name = "pbImpression2";
            this.pbImpression2.Size = new System.Drawing.Size(116, 119);
            this.pbImpression2.TabIndex = 6;
            this.pbImpression2.TabStop = false;
            // 
            // pbImpression3
            // 
            this.pbImpression3.BackColor = System.Drawing.SystemColors.Window;
            this.pbImpression3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImpression3.Location = new System.Drawing.Point(296, 375);
            this.pbImpression3.Name = "pbImpression3";
            this.pbImpression3.Size = new System.Drawing.Size(116, 119);
            this.pbImpression3.TabIndex = 6;
            this.pbImpression3.TabStop = false;
            // 
            // EnrollmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(657, 501);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.imgPicture);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(StatusLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pbImpression3);
            this.Controls.Add(this.pbImpression2);
            this.Controls.Add(this.pbImpression1);
            this.Controls.Add(this.lblCodeMessage);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.txtMemberCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EnrollmentForm";
            this.Text = "Enrollment Form";
            this.Load += new System.EventHandler(this.EnrollmentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImpression1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImpression2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImpression3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMemberCode;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label lblCodeMessage;
        private System.Windows.Forms.PictureBox pbImpression1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox StatusText;
        private System.Windows.Forms.PictureBox imgPicture;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel btnCapture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.CheckBox chk5;
        private System.Windows.Forms.CheckBox chk9;
        private System.Windows.Forms.CheckBox chk10;
        private System.Windows.Forms.CheckBox chk4;
        private System.Windows.Forms.CheckBox chk7;
        private System.Windows.Forms.CheckBox chk8;
        private System.Windows.Forms.CheckBox chk6;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.PictureBox pbImpression2;
        private System.Windows.Forms.PictureBox pbImpression3;
    }
}
