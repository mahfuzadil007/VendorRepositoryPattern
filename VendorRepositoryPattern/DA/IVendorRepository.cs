using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorRepositoryPattern.Data_Access_Layer
{
    public interface IVendorRepository
    {
        List<Vendor> Get();
        Vendor Get(int id);
        bool Add(Vendor Type);
        bool Update(Vendor Type);
        bool Delete(int ID);
    }
}
