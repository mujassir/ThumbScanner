using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ThumbScanner.Entities;
using ThumbScanner.Repositories;

namespace ThumbScanner.WinUI
{
    public static class ImpressionVerifier
    {
        private static DPFP.Verification.Verification Verificator;
        private static IEnumerable<fmf> DataCollection { get; set; }
        static ImpressionVerifier()
        {
            Verificator = new DPFP.Verification.Verification();
        }
        public static fmf Verify(DPFP.Sample Sample)
        {
            DPFP.FeatureSet features = ExtractFeatures(Sample, DPFP.Processing.DataPurpose.Verification);
            var template = new DPFP.Template();
            var result = new DPFP.Verification.Verification.Result();
            fmf fm = null;
            if (features != null)
            {
                if (DataCollection == null)
                {
                    DataCollection = new fmfRepository().Get();
                }
                foreach (var item in DataCollection)
                {
                    if (item.template1 != null)
                    {
                        template.DeSerialize(item.template1);
                        Verificator.Verify(features, template, ref result);
                    }
                    if (item.template2 != null && !result.Verified)
                    {
                        template.DeSerialize(item.template2);
                        Verificator.Verify(features, template, ref result);
                    }
                    if (item.template3 != null && !result.Verified)
                    {
                        template.DeSerialize(item.template3);
                        Verificator.Verify(features, template, ref result);
                    }
                    if (result.Verified)
                    {
                        fm = item;
                        break;
                    }
                }
            }
            return fm;
        }
        public static DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
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
    }
}
