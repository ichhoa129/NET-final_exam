using _102190064_NguyenIchHoa.MODEL;
using System.Data.Entity;

namespace _102190064_NguyenIchHoa.DAL
{
    class DbHelper :DbContext
    {

        public DbSet<NguyenLieu> NguyenLieus { get; set; }
        public DbSet<MonAn> MonAns { get; set; }
        public DbSet<MonAn_NguyenLieu> MonAn_NguyenLieus { get; set; }

        public DbHelper()
            :base("ThucDonDb")
        {

        }
    }
}
