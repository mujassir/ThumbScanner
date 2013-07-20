using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ThumbScanner.Repositories;

namespace ThumbScanner.WinUI
{
    public partial class EnrollmentForm : ThumbScanner.WinUI.CaptureForm
    {
        private DPFP.Processing.Enrollment Enroller;

        public EnrollmentForm()
        {
            InitializeComponent();

        }

        #region Form Event Handlers
        private void txtMemberCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cursor = Cursors.WaitCursor;
                var code = txtMemberCode.Text;
                var fm = new fmfRepository().GetByCode(code);
                if (fm == null)
                {
                    lblCodeMessage.Text = "Account not found";
                    Stop();
                    pnlThumbPicture.Visible = false;
                }
                else
                {
                    txtMemberCode.ReadOnly = true;
                    txtDesignation.Text = fm.desg;
                    txtFatherName.Text = fm.f_name;
                    txtMemberName.Text = fm.name;
                    Start();
                    pnlThumbPicture.Visible = true;
                }
                Cursor = Cursors.Default;
            }
        }

        private void EnrollmentForm_Load(object sender, EventArgs e)
        {
            Enroller.Clear();
            Start();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            byte[] tempalte = new byte[4000];
            Enroller.Template.Serialize(ref tempalte);
            new fmfRepository().SaveTemplate(txtMemberCode.Text, tempalte);
            Enroller.Clear();
            MessageBox.Show("Thumb impression saved");
            ClearAll();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        public void ClearAll()
        {
            pnlThumbPicture.Visible = lblTISuccess.Visible = lblTIError.Visible = false;
            txtMemberCode.Text = txtFatherName.Text = txtDesignation.Text = txtMemberName.Text = "";
            txtMemberCode.ReadOnly = false;
            lblCodeMessage.Text = "";
        }

        #endregion


        private void UpdateStatus()
        {
            // Show number of samples needed.
            SetStatus(String.Format("Fingerprint samples needed: {0}", Enroller.FeaturesNeeded));
        }
        protected override void Init()
        {
            base.Init();
            base.Text = "Fingerprint Enrollment";
            Enroller = new DPFP.Processing.Enrollment();			// Create an enrollment.
            UpdateStatus();
        }

        protected override void Process(DPFP.Sample Sample)
        {
            // Draw fingerprint sample image.
            DrawPicture(ConvertSampleToBitmap(Sample));

            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Enrollment);

            // Check quality of the sample and add to enroller if it's good
            if (features != null) try
                {
                    MakeReport("The fingerprint feature set was created.");

                    Enroller.AddFeatures(features);		// Add feature set to template.
                    Enroller.AddFeatures(features);		// Add feature set to template.
                    Enroller.AddFeatures(features);		// Add feature set to template.
                    Enroller.AddFeatures(features);		// Add feature set to template.
                }
                finally
                {
                    UpdateStatus();

                    // Check if template has been created.
                    switch (Enroller.TemplateStatus)
                    {
                        case DPFP.Processing.Enrollment.Status.Ready:	// report success and stop capturing
                            ShowThumbImpressionStatus(true);
                            this.Invoke(new MethodInvoker(delegate()
                              {
                                  btnSave.Enabled = true;
                              }));
                            Stop();
                            break;

                        case DPFP.Processing.Enrollment.Status.Failed:	// report failure and restart capturing
                            Enroller.Clear();
                            Stop();
                            UpdateStatus();
                            ShowThumbImpressionStatus(false);
                            Start();
                            break;
                    }
                }
        }

        public void ShowThumbImpressionStatus(bool status)
        {
            if (status)
            {

                this.Invoke(new MethodInvoker(delegate()
                {
                    lblTIError.Visible = false;
                    lblTISuccess.Visible = true;
                }));
            }
            else
            {
                this.Invoke(new MethodInvoker(delegate()
                {
                    lblTIError.Visible = true;
                    lblTISuccess.Visible = false;
                }));
            }
        }

        private void DrawPicture(Bitmap bitmap)
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                Picture.Image = new Bitmap(bitmap, Picture.Size);	// fit the image into the picture box
            }));
        }




    }
}
