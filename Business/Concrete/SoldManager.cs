using Business.Abstrack;
using DataAccess.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SoldManager : ISoldItemsService
    {
        ISoldItemsDal _soldItemsDal;
        public SoldManager(ISoldItemsDal soldItemsDal)
        {
            _soldItemsDal = soldItemsDal;
        }

        public void Add(SoldItems entity)
        {
            _soldItemsDal.Add(entity);
        }

        public void Delete(SoldItems entity)
        {
            _soldItemsDal.Delete(entity);
        }

        public List<SoldItems> GetAll()
        {
            return _soldItemsDal.GetAll();
        }
        public List<SoldItems> GetAllUserId(int id)
        {
            return _soldItemsDal.GetAll(p => p.UserId == id);
        }

        public void Update(SoldItems entity)
        {
            _soldItemsDal.Update(entity);
        }
    }
}
