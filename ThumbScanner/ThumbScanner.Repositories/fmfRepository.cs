using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ThumbScanner.Entities;

namespace ThumbScanner.Repositories
{
    public class fmfRepository : GenericRepository<fmf>
    {
        public fmf GetById(int id)
        {
            return FirstOrDefault(p => p.Id == id);
        }
    }
}
