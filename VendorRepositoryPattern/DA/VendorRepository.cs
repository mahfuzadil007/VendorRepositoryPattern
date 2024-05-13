using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorRepositoryPattern.Data_Access_Layer
{
    public class VendorRepository : IVendorRepository
    {
        List<Vendor> listVendor = new List<Vendor>()
        {
            new Vendor(1, "UNIMART", "Gulshan,Dhaka,Bangladesh "),
            new Vendor(2, "Samata Traders", "Babubazar, Dhaka"),
            new Vendor(3, "ACI Salt Ltd", "Tejgaon Industrial Area, Dhaka 1208, Bangladesh"),
            new Vendor(4, "Aarong Dairy", "Mohakhali,Dhaka,Bangladesh "),
            new Vendor(5, "Rangs Electronics","Rabindra Sarani, Dhaka 1212")
        };
        public List<Vendor> Get()
        {
            return listVendor.OrderBy(x => x.Name).ToList();
        }

        public Vendor Get(int id)
        {
            Vendor v = listVendor.Where(x => x.ID == id).FirstOrDefault();
            return v;
        }

        public bool Add(Vendor Type)
        {
            listVendor.Add(Type);
            return true;
        }

        public bool Update(Vendor Type)
        {
            bool isExecuted = false;
            Vendor v = listVendor.Where(x => x.ID == Type.ID).FirstOrDefault();
            if (v != null)
            {
                listVendor.Remove(v);
                listVendor.Add(Type);
                isExecuted = true;
            }
            return isExecuted;
        }

        public bool Delete(int ID)
        {
            bool isExecuted = false;
            Vendor v = listVendor.Where(x => x.ID == ID).FirstOrDefault();
            if (v != null)
            {
                listVendor.Remove(v);
                isExecuted = true;
            }
            return isExecuted;
        }

    }
}
