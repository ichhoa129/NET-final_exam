using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _102190064_NguyenIchHoa.MODEL
{
    public class MonAn
    {
        public MonAn()
        {
            MonAn_NguyenLieus = new HashSet<MonAn_NguyenLieu>();
        }
        [Key]
        public int MaMonAn { get; set; }

        public string TenMonAn { get; set; }

        public virtual ICollection<MonAn_NguyenLieu> MonAn_NguyenLieus { get; set; }
    }
}
