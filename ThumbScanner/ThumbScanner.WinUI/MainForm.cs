using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThumbScanner.Entities;
using ThumbScanner.Repositories;

namespace ThumbScanner.WinUI
{
    public partial class MainForm : ThumbScanner.WinUI.ParentForm, DPFP.Capture.EventHandler
    {
        private DPFP.Capture.Capture Capturer;
        private DPFP.Verification.Verification Verificator;
        private IEnumerable<fmf> DataCollection;
        public MainForm()
        {
            InitializeComponent();
        }

        protected virtual void Init()
        {
            try
            {
                Verificator = new DPFP.Verification.Verification();
                Capturer = new DPFP.Capture.Capture();				// Create a capture operation.

                if (null != Capturer)
                    Capturer.EventHandler = this;					// Subscribe for capturing events.
                else
                    SetPrompt("Can't initiate capture operation!");
            }
            catch
            {
                MessageBox.Show("Can't initiate capture operation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected virtual void Process(DPFP.Sample Sample)
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                Cursor = Cursors.WaitCursor;
                DrawPicture(ConvertSampleToBitmap(Sample));

                var fm = ImpressionVerifier.Verify(Sample);
                if (fm != null)
                {
                    SetFormData(fm);
                }
                else
                {
                    ClearFormData();
                    MakeReport("Account not found");
                }
                Cursor = Cursors.Default;
            }));

        }

        public void SetFormData(fmf fm)
        {
            txtDesignation.Text = fm.desg;
            txtFatherName.Text = fm.f_name;
            txtMemberCode.Text = fm.acc_cd;
            txtMemberName.Text = fm.name;
            if (fm.picture != null)
                imgPicture.Image = ImageUtitlity.BinaryToImage(fm.picture);
            else
                imgPicture.Image = ThumbScanner.WinUI.Properties.Resources.no_image_blog_one;
        }
        public void ClearFormData()
        {
            txtDesignation.Text =
            txtFatherName.Text =
            txtMemberCode.Text =
            txtMemberName.Text = "";
        }




        protected void StartCapturing()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StartCapture();
                    SetPrompt("Using the fingerprint reader, scan your fingerprint.");
                }
                catch
                {
                    SetPrompt("Can't initiate capture!");
                }
            }
        }

        protected void StopCapturing()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StopCapture();
                }
                catch
                {
                    SetPrompt("Can't terminate capture!");
                }
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            Init();
            StartCapturing();
        }

        #region EventHandler Members:

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            MakeReport("The fingerprint sample was captured.");
            SetPrompt("Scan the same fingerprint again.");
            Process(Sample);
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The finger was removed from the fingerprint reader.");
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was touched.");
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was connected.");
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was disconnected.");
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
                MakeReport("The quality of the fingerprint sample is good.");
            else
                MakeReport("The quality of the fingerprint sample is poor.");
        }
        #endregion

        protected Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();	// Create a sample convertor.
            Bitmap bitmap = null;												            // TODO: the size doesn't matter
            Convertor.ConvertToPicture(Sample, ref bitmap);									// TODO: return bitmap as a result
            return bitmap;
        }

        protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();	// Create a feature extractor
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);			// TODO: return features as a result?
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;
        }

        protected void SetStatus(string status)
        {
        }

        protected void SetPrompt(string prompt)
        {
        }
        protected void MakeReport(string message)
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                StatusText.AppendText(message + "\r\n");
            }));
        }

        private void DrawPicture(Bitmap bitmap)
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                Picture.Image = new Bitmap(bitmap, Picture.Size);	// fit the image into the picture box
            }));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void enrollmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnrollmentForm f = new EnrollmentForm();
            StopCapturing();
            f.FormClosed += f_FormClosed;
            f.ShowDialog();
        }

        void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            StartCapturing();
        }

    }
}
