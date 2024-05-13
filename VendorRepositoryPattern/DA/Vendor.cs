using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorRepositoryPattern.Data_Access_Layer
{
    public class Vendor
    {
        public int ID;
        public string Name;
        public string Address;
        public Vendor()
        {
        }
        public Vendor(int id, string name, string address)
        {
            this.ID = id;
            this.Name = name;
            this.Address = address;
        }

    }
}
