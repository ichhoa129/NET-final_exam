using _102190064_NguyenIchHoa.MODEL;
using System.Collections.Generic;
using System.Linq;

namespace _102190064_NguyenIchHoa.DAL
{
    class MonAn_DAL
    {
        private static MonAn_DAL _Instance;

        public static MonAn_DAL Instance
        {
            get { return _Instance ?? new MonAn_DAL(); }
            private set { }
        }

        private MonAn_DAL() { }

        public List<MonAn> FindAll()
        {
            var db = new DbHelper();

            var query = from c in db.MonAns select c;

            return query.ToList();
        }
    }
}
