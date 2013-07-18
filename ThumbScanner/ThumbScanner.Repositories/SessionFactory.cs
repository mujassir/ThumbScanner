using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ThumbScanner.Entities;

namespace ThumbScanner.Repositories
{
    public static class SessionFactory
    {
        private static ThumbScannerDBEntities db;
        public static ThumbScannerDBEntities GetContext()
        {
            if (db == null)
                db = new ThumbScannerDBEntities();
            return db;
        }
        public static ThumbScannerDBEntities CurrentContext
        {
            get
            {
                if (db == null)
                    db = new ThumbScannerDBEntities();
                return db;
            }
        }
    }
}
