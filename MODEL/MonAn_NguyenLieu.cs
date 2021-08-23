using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _102190064_NguyenIchHoa.MODEL
{
    public class MonAn_NguyenLieu
    {

        [Column(TypeName = "NVARCHAR")]
        [StringLength(5)]
        [Key]
        public string Ma { get; set; }

        public int SoLuong { get; set; }

        public string DonViTinh { get; set; }

        public int MaMonAn { get; set; }

        [ForeignKey("MaMonAn")]
        public virtual MonAn MonAn { get; set; }

        public int MaNguyenLieu { get; set; }

        [ForeignKey("MaNguyenLieu")]
        public virtual NguyenLieu NguyenLieu { get; set; }
    }
}
