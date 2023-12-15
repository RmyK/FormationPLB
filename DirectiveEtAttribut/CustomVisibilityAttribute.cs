using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectiveEtAttribut
{
    public class CustomVisibilityAttribute : Attribute
    {
        public int Order { get; set; }

        public bool IsVisible { get; set; }
    }
}
