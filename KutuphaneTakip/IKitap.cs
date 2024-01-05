using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneTakip
{
    public interface IKitap
    {
        public void Ekle(string a,string b, int c, string d,int e, int q);
        public void Goster();
    }


}
