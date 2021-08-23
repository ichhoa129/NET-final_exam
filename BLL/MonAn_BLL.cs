using _102190064_NguyenIchHoa.DAL;
using _102190064_NguyenIchHoa.MODEL;
using System.Collections.Generic;

namespace _102190064_NguyenIchHoa.BLL
{
    class MonAn_BLL
    {
        private static MonAn_BLL _Instance;

        public static MonAn_BLL Instance
        {
            get { return _Instance ?? new MonAn_BLL(); }
            private set { }
        }

        private MonAn_BLL() { }


        public List<MonAn> FindAll()
        {
            return MonAn_DAL.Instance.FindAll();
        } 
    }
}
