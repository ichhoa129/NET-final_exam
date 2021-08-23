using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _102190064_NguyenIchHoa.MODEL
{
    public class NguyenLieu
    {
        public NguyenLieu() {
            MonAn_NguyenLieus = new HashSet<MonAn_NguyenLieu>();
        }
        [Key]
        public int MaNguyenLieu { get; set; }

        public string TenNguyenLieu { get; set; }

        public bool Status { get; set; }

        public virtual ICollection<MonAn_NguyenLieu> MonAn_NguyenLieus { get; set; }
    }
}
