using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ThumbScanner.Entities;
using ThumbScanner.Repositories;
using WebCam_Capture;

namespace ThumbScanner.WinUI
{
    public partial class EnrollmentForm : ThumbScanner.WinUI.CaptureForm
    {
        private DPFP.Processing.Enrollment Enroller;
        private int SampleNo = 1;
        public fmf fmRecord = null;
        private byte[] template1;
        private byte[] template2;
        private byte[] template3;
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
                    ClearAll();
                    Stop();
                }
                else
                {
                    SetData(fm);
                    Start();
                }
                Cursor = Cursors.Default;
            }
        }
        public void SetData(fmf fm)
        {
            txtMemberCode.ReadOnly = true;
            txtDesignation.Text = fm.desg;
            txtFatherName.Text = fm.f_name;
            txtMemberName.Text = fm.name;
            if(fm.picture != null )
            imgPicture.Image = ImageUtitlity.BinaryToImage(fm.picture);
            else
                imgPicture.Image = ThumbScanner.WinUI.Properties.Resources.no_image_blog_one;
            chk1.Checked = fm.finger1.HasValue && fm.finger1.Value == 1 ? true : false;
            chk2.Checked = fm.finger2.HasValue && fm.finger2.Value == 1 ? true : false;
            chk3.Checked = fm.finger3.HasValue && fm.finger3.Value == 1 ? true : false;
            chk4.Checked = fm.finger4.HasValue && fm.finger4.Value == 1 ? true : false;
            chk5.Checked = fm.finger5.HasValue && fm.finger5.Value == 1 ? true : false;
            chk6.Checked = fm.finger6.HasValue && fm.finger6.Value == 1 ? true : false;
            chk7.Checked = fm.finger7.HasValue && fm.finger7.Value == 1 ? true : false;
            chk8.Checked = fm.finger8.HasValue && fm.finger8.Value == 1 ? true : false;
            chk9.Checked = fm.finger9.HasValue && fm.finger9.Value == 1 ? true : false;
            chk10.Checked = fm.finger10.HasValue && fm.finger10.Value == 1 ? true : false;
            fmRecord = fm;
        }

        private void EnrollmentForm_Load(object sender, EventArgs e)
        {
            Enroller.Clear();
            Start();
            webcam = new WebCam();
            webcam.InitializeWebCam(ref imgPicture);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (fmRecord == null)
            {
                MessageBox.Show("Please select a record first");
            }
            else
            {
                fmRecord.acc_cd = txtMemberCode.Text;
                fmRecord.template1 = template1;
                fmRecord.template2 = template2;
                fmRecord.template3 = template3;
                fmRecord.finger1 = chk1.Checked ? 1 : 0;
                fmRecord.finger2 = chk1.Checked ? 1 : 0;
                fmRecord.finger3 = chk1.Checked ? 1 : 0;
                fmRecord.finger4 = chk1.Checked ? 1 : 0;
                fmRecord.finger5= chk1.Checked ? 1 : 0;
                fmRecord.finger6 = chk1.Checked ? 1 : 0;
                fmRecord.finger7 = chk1.Checked ? 1 : 0;
                fmRecord.finger8 = chk1.Checked ? 1 : 0;
                fmRecord.finger9 = chk1.Checked ? 1 : 0;
                fmRecord.finger10 = chk1.Checked ? 1 : 0;
                fmRecord.picture = ImageUtitlity.ImageToBinary(imgPicture.Image);
                new fmfRepository().Save(fmRecord);
                Enroller.Clear();
                MakeReport("Record saved");
                ClearAll();
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        public void ClearAll()
        {
            txtMemberCode.Text = txtFatherName.Text = txtDesignation.Text = txtMemberName.Text = "";
            txtMemberCode.ReadOnly = false;
            lblCodeMessage.Text = "";
            imgPicture.Image = ThumbScanner.WinUI.Properties.Resources.no_image_blog_one;
            chk1.Checked =
            chk2.Checked =
            chk3.Checked =
            chk4.Checked =
            chk5.Checked =
            chk6.Checked =
            chk7.Checked =
            chk8.Checked =
            chk9.Checked =
            chk10.Checked = false;
            pbImpression1.Image =
            pbImpression2.Image =
            pbImpression3.Image = null;
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
                            SetTemplate();
                            break;

                        case DPFP.Processing.Enrollment.Status.Failed:	// report failure and restart capturing
                            Enroller.Clear();
                            //Stop();
                            //UpdateStatus();
                            //Start();
                            break;
                    }
                }
        }
        private void SetTemplate()
        {
            var template = new byte[4000];
            Enroller.Template.Serialize(ref template);
            switch (SampleNo)
            {
                case 1:
                    template1 = template;
                    MakeReport("Sample 1 enrolled");
                    SampleNo++;
                    break;
                case 2:
                    MakeReport("Sample 2 enrolled");
                    template2 = template;
                    SampleNo++;
                    break;
                case 3:
                    MakeReport("Sample 3 enrolled");
                    MakeReport("Sample enrollment completed");
                    template3 = template;
                    Stop();
                    break;
            }
            Enroller.Clear();

        }
        public void ShowThumbImpressionStatus(bool status)
        {

        }

        private void DrawPicture(Bitmap bitmap)
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                switch (SampleNo)
                {
                    case 1:
                        pbImpression1.Image = new Bitmap(bitmap, pbImpression1.Size);	// fit the image into the picture box
                        break;
                    case 2:
                        pbImpression2.Image = new Bitmap(bitmap, pbImpression2.Size);	// fit the image into the picture box
                        break;
                    case 3:
                        pbImpression3.Image = new Bitmap(bitmap, pbImpression3.Size);	// fit the image into the picture box
                        break;
                }
            }));
        }

        WebCam webcam;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            webcam.Start();
            btnCapture.Visible = true;

        }


        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            webcam.Stop();
            btnCapture.Visible = false;
            MakeReport("Picture captured");
        }

        protected override void MakeReport(string message)
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                StatusText.AppendText(message + "\r\n");
            }));
        }



    }

    public class WebCam
    {
        private WebCamCapture webcam;
        private System.Windows.Forms.PictureBox _FrameImage;
        private int FrameNumber = 30;
        public void InitializeWebCam(ref System.Windows.Forms.PictureBox ImageControl)
        {
            webcam = new WebCamCapture();
            webcam.FrameNumber = ((ulong)(0ul));
            webcam.TimeToCapture_milliseconds = FrameNumber;
            webcam.ImageCaptured += new WebCamCapture.WebCamEventHandler(webcam_ImageCaptured);
            _FrameImage = ImageControl;
        }

        void webcam_ImageCaptured(object source, WebcamEventArgs e)
        {
            _FrameImage.Image = e.WebCamImage;
        }

        public void Start()
        {
            webcam.TimeToCapture_milliseconds = FrameNumber;
            webcam.Start(0);
        }

        public void Stop()
        {
            webcam.Stop();
        }

        public void Continue()
        {
            // change the capture time frame
            webcam.TimeToCapture_milliseconds = FrameNumber;

            // resume the video capture from the stop
            webcam.Start(this.webcam.FrameNumber);
        }

        public void ResolutionSetting()
        {
            webcam.Config();
        }

        public void AdvanceSetting()
        {
            webcam.Config2();
        }

    }
}
