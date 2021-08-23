using _102190064_NguyenIchHoa.DTO;
using _102190064_NguyenIchHoa.MODEL;
using System.Collections.Generic;
using System.Linq;

namespace _102190064_NguyenIchHoa.DAL
{
    class NguyenLieu_DAL
    {
        private static NguyenLieu_DAL _Instance;

        public static NguyenLieu_DAL Instance
        {
            get { return _Instance ?? new NguyenLieu_DAL(); }
            private set { }
        }

        private NguyenLieu_DAL() { }

        public List<NguyenLieuView> FindByMonAnAndSearch(int monAnId, string searchText)
        {
            var db = new DbHelper();

            var query = from c in db.NguyenLieus
                        join t in db.MonAn_NguyenLieus on c.MaNguyenLieu equals t.MaNguyenLieu
                        join e in db.MonAns on t.MaMonAn equals e.MaMonAn
                        where e.MaMonAn == monAnId
                        select new
                        {
                            t.Ma,
                            c.MaNguyenLieu,
                            c.TenNguyenLieu,
                            t.SoLuong,
                            t.DonViTinh,
                            c.Status
                        };

            List<NguyenLieuView> nguyenLieus = new List<NguyenLieuView>();
            int stt = 1;
            foreach (var data in query)
            {
                nguyenLieus.Add(new NguyenLieuView()
                {
                    STT = stt++,
                    MaLienKet = data.Ma,
                    MaNguyenLieu = data.MaNguyenLieu,
                    TenNguyenLieu = data.TenNguyenLieu,
                    SoLuong = data.SoLuong,
                    DonViTinh = data.DonViTinh,
                    TinhTrang = data.Status
                });
            }
            return nguyenLieus;
        }

        public int AddNguyenLieu(NguyenLieu newNguyenLieu)
        {
            var db = new DbHelper();

            db.NguyenLieus.Add(newNguyenLieu);
            db.SaveChanges();
            return newNguyenLieu.MaNguyenLieu;
        }

        public NguyenLieu FindById(int id)
        {
            var db = new DbHelper();
            return db.NguyenLieus.Where(_ => _.MaNguyenLieu == id).FirstOrDefault();
        }

        public void UpdateOne(int id, string tenNguyenLieu, bool TinhTrang)
        {
            var db = new DbHelper();

            var result = db.NguyenLieus.SingleOrDefault(n => n.MaNguyenLieu== id);

            result.TenNguyenLieu = tenNguyenLieu;
            result.Status = TinhTrang;

            db.SaveChanges();
        }

    }
}
