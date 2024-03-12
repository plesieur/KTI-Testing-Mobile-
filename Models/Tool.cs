using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTI_Testing__Mobile_.Models
{
    class Tool(int i, string n, string d, string icon, int a)
    {
        private int id = i;
        private string name = n;
        private string description = d;
        private string icon = icon;
        private int amount = a;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Icon
        {
            get { return icon; }
            set { icon = value; }
        }

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }



    }
}
