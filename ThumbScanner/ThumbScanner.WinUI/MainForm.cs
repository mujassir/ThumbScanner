using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ThumbScanner.Entities;
using ThumbScanner.Repositories;

namespace ThumbScanner.WinUI
{
    public partial class MainForm : ThumbScanner.WinUI.CaptureForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void enrollmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnrollmentForm f = new EnrollmentForm();
            f.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Start();
        }
        protected override void Init()
        {
            base.Init();
            base.Text = "Fingerprint Verification";
            Verificator = new DPFP.Verification.Verification();		// Create a fingerprint template verificator
        }
        private DPFP.Verification.Verification Verificator;
        protected override void Process(DPFP.Sample Sample)
        {
            this.Invoke(new MethodInvoker(delegate()
              {
                  Cursor = Cursors.WaitCursor;
                  base.Process(Sample);
                  var result = false;
                  var fm = new fmf();
                  var fms = new fmfRepository().Get();
                  foreach (var item in fms)
                  {
                      result = VerifyImpression(item, Sample);
                      fm = item;
                      if (result) break;
                  }
                  if (result)
                  {
                      txtDesignation.Text = fm.desg;
                      txtFatherName.Text = fm.f_name;
                      txtMemberCode.Text = fm.acc_cd;
                      txtMemberName.Text = fm.name;
                      lblCodeMessage.Text = "";
                  }
                  else
                  {
                      lblCodeMessage.Text = "Account not found";

                  }
                  Cursor = Cursors.Default;
              }));

        }
        public bool VerifyImpression(fmf fm, DPFP.Sample Sample)
        {
            if (fm.template1 == null) return false;
            // Process the sample and create a feature set for the enrollment purpose.
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);

            // Check quality of the sample and start verification if it's good
            // TODO: move to a separate task
            if (features != null)
            {
                DPFP.Template template = new DPFP.Template();
                template.DeSerialize(fm.template1);
                if (template.Size == 0) return false;
                // Compare the feature set with our template
                DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();
                Verificator.Verify(features, template, ref result);
                return result.Verified;
            }
            return false;
        }

    }
}
