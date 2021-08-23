using _102190064_NguyenIchHoa.BLL;
using _102190064_NguyenIchHoa.DTO;
using _102190064_NguyenIchHoa.GUI;
using _102190064_NguyenIchHoa.MODEL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _102190064_NguyenIchHoa
{
    public partial class NguyenIchHoa_MF : Form
    {
        public object DetailForm { get; private set; }

        public NguyenIchHoa_MF()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            LoadMonAnCbb();
            LoadSortCbb();
        }

        public void LoadDataGridViewData()
        {
            string searchText = searchTxt.Text;
            CbbItem selectedItem = (CbbItem)foodCbb.SelectedItem;
            if (selectedItem != null)
            {
                mainDgv.DataSource = NguyenLieu_BLL.Instance.FindNguyenLieuByMonAnAndSearch(selectedItem.Value, searchText);
            }
            mainDgv.Columns["MaNguyenLieu"].Visible = false;
            mainDgv.Columns["MaLienKet"].Visible = false;
        }



        private void LoadMonAnCbb()
        {
            List<MonAn> listMonAn = MonAn_BLL.Instance.FindAll();

            foreach (MonAn monAn in listMonAn)
            {
                foodCbb.Items.Add(new CbbItem
                {
                    Value = monAn.MaMonAn,
                    Text = monAn.TenMonAn
                });
            }
        }

        private void LoadSortCbb()
        {

        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            LoadDataGridViewData();
        }

        private void foodCbb_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadDataGridViewData();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (foodCbb.SelectedIndex >= 0)
            {
                int selectedFoodId = ((CbbItem)foodCbb.SelectedItem).Value;
                NguyenIchHoa_DF detailForm = new NguyenIchHoa_DF();
                detailForm.loadData += LoadDataGridViewData;
                detailForm.FoodId = selectedFoodId;
                detailForm.ShowDialog();
                detailForm.Dispose();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            
            if (foodCbb.SelectedIndex >= 0)
            {
                int selectedrowindex = mainDgv.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = mainDgv.Rows[selectedrowindex];
                int maNguyenLieu = Convert.ToInt32(selectedRow.Cells["MaNguyenLieu"].Value);

                int selectedFoodId = ((CbbItem)foodCbb.SelectedItem).Value;
                NguyenIchHoa_DF detailForm = new NguyenIchHoa_DF(maNguyenLieu, selectedFoodId);

                detailForm.loadData += LoadDataGridViewData;

                detailForm.ShowDialog();
                detailForm.Dispose();
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            List<string> listMaNguyenLieu = new List<string>();

            foreach(DataGridViewRow row in mainDgv.SelectedRows)
            {
                if(Convert.ToBoolean(row.Cells["TinhTrang"].Value) == false)
                    listMaNguyenLieu.Add((row.Cells["MaLienKet"].Value).ToString());
            }

            NguyenLieu_BLL.Instance.DeleteMany(listMaNguyenLieu);

            LoadDataGridViewData();
        }
    }
}
