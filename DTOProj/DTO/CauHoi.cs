using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOProj
{
    [Serializable]
    public class Question
    {
        public string Content { get; set; }
        public List<string>DanhSachCauTraLoi { get; set; }
        public string Answer { get; set; }

        public Question()
        {
            DanhSachCauTraLoi = new List<string>();
        }
    }
    
}
