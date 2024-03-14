using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTI_Testing__Mobile_.Models
{
    public class Tool
    {
        private int id = i;
        private string name = n;
        private string description = d;
        private string icon = icon;
        private int amount = a;


        public Tool(int i, string n, string d, string icon, int a)
        {
            this.id = i;
            this.name = n;
            this.description = d;
            this.icon = icon;
            this.amount = a;
        }

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
        public string Desc
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
