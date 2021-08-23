using _102190064_NguyenIchHoa.BLL;
using _102190064_NguyenIchHoa.DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace _102190064_NguyenIchHoa.GUI
{
    public partial class NguyenIchHoa_DF : Form
    {
        public delegate void LoadDataDelegate();

        public LoadDataDelegate loadData { get; set; }

        public int FoodId { get; set; }

        public int NguyenLieuId { get; set; }
        public NguyenIchHoa_DF(int NguyenLieuId = 0, int foodId = 0)
        {
            InitializeComponent();
            this.FoodId = foodId;
            this.NguyenLieuId = NguyenLieuId;
            LoadEditData();
        }

        public void LoadEditData()
        {
            if(NguyenLieuId != 0)
            {
                maTxt.Enabled = false;
                var nguyenLieu = NguyenLieu_BLL.Instance.FindById(this.NguyenLieuId);

                tenNguyenLieuTxt.Text = nguyenLieu.TenNguyenLieu;
                var data = nguyenLieu.MonAn_NguyenLieus.Where(p => p.MaMonAn == this.FoodId).FirstOrDefault();

                quantityTxt.Text = data.SoLuong.ToString();
                unitTxt.Text = data.DonViTinh;
                maTxt.Text = data.Ma;

                statusCbb.SelectedIndex = nguyenLieu.Status ? 0 : 1;
            }
            else statusCbb.SelectedIndex = 0;
        }

        

        private void cancelBtn_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }

        private void okBtn_Click(object sender, System.EventArgs e)
        {
            string ma = maTxt.Text;
            string tenNguyenLieu = tenNguyenLieuTxt.Text;
            string donVi = unitTxt.Text;
            int soLuong = Convert.ToInt32(quantityTxt.Text);

            int statusIndex = statusCbb.SelectedIndex;

            bool tinhTrang = statusIndex == 0 ? true : false;

            UpSertNguyenLieu obj = new UpSertNguyenLieu()
            {
                Ma = ma,
                TenNguyenLieu = tenNguyenLieu,
                DonViTinh = donVi,
                SoLuong = soLuong,
                TinhTrang = tinhTrang,
                MaMonAn = this.FoodId
            };

            try
            {
                if(this.NguyenLieuId != 0) // edit
                {
                    NguyenLieu_BLL.Instance.EditOne(obj, NguyenLieuId);
                } else 
                NguyenLieu_BLL.Instance.AddNguyenLieu(obj); // add
            } catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            loadData();
            this.Dispose();
        }
    }
}
