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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMemberCode = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.lblCodeMessage = new System.Windows.Forms.Label();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.pnlThumbPicture = new System.Windows.Forms.Panel();
            this.lblTIError = new System.Windows.Forms.Label();
            this.lblTISuccess = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.pnlThumbPicture.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(18, 23);
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
            this.label2.Location = new System.Drawing.Point(28, 125);
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
            this.label3.Location = new System.Drawing.Point(23, 91);
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
            this.label4.Location = new System.Drawing.Point(15, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Member Name";
            // 
            // txtMemberCode
            // 
            this.txtMemberCode.Location = new System.Drawing.Point(118, 21);
            this.txtMemberCode.Name = "txtMemberCode";
            this.txtMemberCode.Size = new System.Drawing.Size(100, 20);
            this.txtMemberCode.TabIndex = 0;
            this.txtMemberCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMemberCode_KeyDown);
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(118, 55);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(276, 20);
            this.txtMemberName.TabIndex = 1;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(118, 89);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(276, 20);
            this.txtFatherName.TabIndex = 2;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(118, 123);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(276, 20);
            this.txtDesignation.TabIndex = 3;
            // 
            // lblCodeMessage
            // 
            this.lblCodeMessage.AutoSize = true;
            this.lblCodeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeMessage.ForeColor = System.Drawing.Color.Red;
            this.lblCodeMessage.Location = new System.Drawing.Point(224, 23);
            this.lblCodeMessage.Name = "lblCodeMessage";
            this.lblCodeMessage.Size = new System.Drawing.Size(0, 16);
            this.lblCodeMessage.TabIndex = 5;
            // 
            // Picture
            // 
            this.Picture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Picture.BackColor = System.Drawing.SystemColors.Window;
            this.Picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Picture.Location = new System.Drawing.Point(28, 51);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(248, 250);
            this.Picture.TabIndex = 6;
            this.Picture.TabStop = false;
            // 
            // pnlThumbPicture
            // 
            this.pnlThumbPicture.Controls.Add(this.lblTIError);
            this.pnlThumbPicture.Controls.Add(this.lblTISuccess);
            this.pnlThumbPicture.Controls.Add(this.label5);
            this.pnlThumbPicture.Controls.Add(this.Picture);
            this.pnlThumbPicture.Location = new System.Drawing.Point(422, 21);
            this.pnlThumbPicture.Name = "pnlThumbPicture";
            this.pnlThumbPicture.Size = new System.Drawing.Size(319, 451);
            this.pnlThumbPicture.TabIndex = 7;
            this.pnlThumbPicture.Visible = false;
            // 
            // lblTIError
            // 
            this.lblTIError.AutoSize = true;
            this.lblTIError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTIError.ForeColor = System.Drawing.Color.Red;
            this.lblTIError.Location = new System.Drawing.Point(16, 304);
            this.lblTIError.Name = "lblTIError";
            this.lblTIError.Size = new System.Drawing.Size(294, 16);
            this.lblTIError.TabIndex = 9;
            this.lblTIError.Text = "Thumb Impression not scanned please try again";
            this.lblTIError.Visible = false;
            // 
            // lblTISuccess
            // 
            this.lblTISuccess.AutoSize = true;
            this.lblTISuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTISuccess.ForeColor = System.Drawing.Color.Green;
            this.lblTISuccess.Location = new System.Drawing.Point(16, 304);
            this.lblTISuccess.Name = "lblTISuccess";
            this.lblTISuccess.Size = new System.Drawing.Size(250, 16);
            this.lblTISuccess.TabIndex = 8;
            this.lblTISuccess.Text = "Thumb Impression scanned successfully";
            this.lblTISuccess.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(36, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Enter Thumb Impression";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(214, 161);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EnrollmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(760, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlThumbPicture);
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
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.pnlThumbPicture.ResumeLayout(false);
            this.pnlThumbPicture.PerformLayout();
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
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Panel pnlThumbPicture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTIError;
        private System.Windows.Forms.Label lblTISuccess;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
    }
}
