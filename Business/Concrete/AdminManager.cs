using Business.Abstrack;
using DataAccess.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;
        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public void Add(IAdminDal entity)
        {
           //_adminDal.Add(entity);
        }

        public List<Admin> GetAll()
        {
            return _adminDal.GetAll();
        }

        public List<Admin> GetAllId(int id)
        {
            return _adminDal.GetAll(p => p.Id == id);
        }
    }
}
