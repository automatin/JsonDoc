using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocJSON
{
    public class JsonObject
    {
        public Menu menu { get; set; }

        public class Menu
        {
            public string id { get; set; }
            public string value { get; set; }
            public Popup popup { get; set; }
        }

        public class Popup
        {
            public Menuitem[] menuitemArray { get; set; }
        }

        public class Menuitem
        {
            public string value { get; set; }
            public string onclick { get; set; }
        }
    }
}
