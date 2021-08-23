using _102190064_NguyenIchHoa.DTO;
using _102190064_NguyenIchHoa.MODEL;
using System.Linq;

namespace _102190064_NguyenIchHoa.DAL
{
    class MonAn_NguyenLieu_DAL
    {
        private static MonAn_NguyenLieu_DAL _Instance;

        public static MonAn_NguyenLieu_DAL Instance
        {
            get { return _Instance ?? new MonAn_NguyenLieu_DAL(); }
            private set { }
        }

        private MonAn_NguyenLieu_DAL() { }

        public void AddMonAnNguyenLieu(MonAn_NguyenLieu monAn_NguyenLieu)
        {
            var db = new DbHelper();

            db.MonAn_NguyenLieus.Add(monAn_NguyenLieu);
            db.SaveChanges();
        }

        public void UpdateOne(UpSertNguyenLieu upSertNguyenLieu)
        {
            var db = new DbHelper();

            var result = db.MonAn_NguyenLieus.SingleOrDefault(n => n.Ma == upSertNguyenLieu.Ma);

            result.DonViTinh = upSertNguyenLieu.DonViTinh;
            result.SoLuong= upSertNguyenLieu.SoLuong;

            db.SaveChanges();
        }

        public void DeleteOne(string ma)
        {
            var db = new DbHelper();

            MonAn_NguyenLieu monAn_NguyenLieu = db.MonAn_NguyenLieus.Find(ma);

            db.MonAn_NguyenLieus.Remove(monAn_NguyenLieu);

            db.SaveChanges();
        }

    }
}
