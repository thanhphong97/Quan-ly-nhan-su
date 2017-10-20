using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsTonGiao
    {
        private string _MATG;

        public string MATG
        {
            get { return _MATG; }
            set { _MATG = value; }
        }
        private string _TENTG;

        public string TENTG
        {
            get { return _TENTG; }
            set { _TENTG = value; }
        }
    }
}
