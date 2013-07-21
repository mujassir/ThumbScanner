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

        public void Save(fmf entity)
        {
            var fm = FirstOrDefault(p => p.acc_cd == entity.acc_cd );
            if (fm != null)
            {
                fm.template1 = entity.template1;
                fm.template2 = entity.template2;
                fm.template3 = entity.template3;
                fm.picture = entity.picture;
                SaveChanges();
            }
        }

    }
}
