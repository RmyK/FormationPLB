using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectiveEtAttribut
{
    [Serializable]
    public class ClasseDeTest
    {
        public int MyValue { get; set; }
        [CustomVisibility (Order = 1, IsVisible = false)]
        public string MyString { get; set; }

        [CustomVisibility (Order = 4, IsVisible = true)]
        public string MyString2 { get; set; }

        [CustomVisibility (Order = 3, IsVisible = true)]
        public string MyString3 { get; set; }

        [CustomVisibility(Order = 5, IsVisible = true)]
        public string MyString4 { get; set; }
    }
}
