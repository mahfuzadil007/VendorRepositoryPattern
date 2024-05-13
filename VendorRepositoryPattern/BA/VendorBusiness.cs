using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendorRepositoryPattern.Data_Access_Layer;

namespace VendorRepositoryPattern.Business_Layer
{
    public class VendorBusiness
    {
        IVendorRepository _repository;

        public VendorBusiness(IVendorRepository repository)
        {
            _repository = repository;
        }

        public List<Vendor> Get()
        {
            return _repository.Get();
        }

        public Vendor Get(int id)
        {
            return _repository.Get(id);
        }

        public bool Add(Vendor Type)
        {
            return _repository.Add(Type);
        }

        public bool Update(Vendor Type)
        {
            return _repository.Update(Type);
        }

        public bool Delete(int ID)
        {
            return _repository.Delete(ID);
        }

    }
}
