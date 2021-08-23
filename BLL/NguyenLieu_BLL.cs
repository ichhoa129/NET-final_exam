using _102190064_NguyenIchHoa.DAL;
using _102190064_NguyenIchHoa.DTO;
using _102190064_NguyenIchHoa.MODEL;
using System.Collections.Generic;

namespace _102190064_NguyenIchHoa.BLL
{
    class NguyenLieu_BLL
    {
        private static NguyenLieu_BLL _Instance;

        public static NguyenLieu_BLL Instance
        {
            get { return _Instance ?? new NguyenLieu_BLL(); }
            private set { }
        }

        private NguyenLieu_BLL() { }

        public List<NguyenLieuView> FindNguyenLieuByMonAnAndSearch(int monAnId, string searchText)
        {
            return NguyenLieu_DAL.Instance.FindByMonAnAndSearch(monAnId, searchText);
        }

        public void AddNguyenLieu(UpSertNguyenLieu nguyenLieu)
        {

            NguyenLieu newNguyenLieu = new NguyenLieu()
            {
                TenNguyenLieu = nguyenLieu.TenNguyenLieu,
                Status = nguyenLieu.TinhTrang
            };

            int id = NguyenLieu_DAL.Instance.AddNguyenLieu(newNguyenLieu);

            MonAn_NguyenLieu monAn_NguyenLieu = new MonAn_NguyenLieu()
            {
                Ma = nguyenLieu.Ma,
                DonViTinh = nguyenLieu.DonViTinh,
                SoLuong = nguyenLieu.SoLuong,
                MaMonAn = nguyenLieu.MaMonAn,
                MaNguyenLieu = id,
            };

            MonAn_NguyenLieu_DAL.Instance.AddMonAnNguyenLieu(monAn_NguyenLieu);
        }

        public NguyenLieu FindById(int id)
        {
           return NguyenLieu_DAL.Instance.FindById(id);
        }

        public void EditOne(UpSertNguyenLieu upSertNguyenLieuDto, int nguyenLieuId)
        {
            NguyenLieu foundNguyenLieu = NguyenLieu_DAL.Instance.FindById(nguyenLieuId);

            NguyenLieu_DAL.Instance.UpdateOne(nguyenLieuId, upSertNguyenLieuDto.TenNguyenLieu, upSertNguyenLieuDto.TinhTrang);

            MonAn_NguyenLieu_DAL.Instance.UpdateOne(upSertNguyenLieuDto);
        }

        public void DeleteMany(List<string> listMa)
        {
            foreach(var ma in listMa)
            {
                MonAn_NguyenLieu_DAL.Instance.DeleteOne(ma);
            }
        }
    }
}
