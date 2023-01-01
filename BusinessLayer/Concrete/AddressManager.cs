using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AddressManager : IAddressService
    {
        private readonly IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        public void Delete(Adress t)
        {
            _addressDal.Delete(t);
        }

        public Adress GetById(int id)
        {
            return _addressDal.GetById(id);
        }

        public List<Adress> GetListAll()
        {
            return _addressDal.GetListAll();
        }

        public void Insert(Adress t)
        {
            _addressDal.Insert(t);
        }

        public void Update(Adress t)
        {
            _addressDal.Update(t);
        }
    }
}
