using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ThumbScanner.Entities;

namespace ThumbScanner.Repositories
{
    public class fmfRepository : GenericRepository<fmf>
    {
        public fmf GetByCode(string code)
        {
            return FirstOrDefault(p => p.acc_cd == code);
        }

        public void SaveTemplate(string code, byte[] tempate)
        {
            var fm = FirstOrDefault(p => p.acc_cd == code);
            if (fm != null)
            {
                fm.template1 = tempate;
                SaveChanges();
            }
        }

    }
}
