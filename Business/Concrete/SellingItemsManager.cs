using Business.Abstrack;
using DataAccess.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SellingItemsManager : ISellingItemsService
    {
        ISellingItemsDal _sellingItemsDal;
        public SellingItemsManager(ISellingItemsDal sellingItemsDal)
        {
            _sellingItemsDal = sellingItemsDal;
        }

        public void Add(SellingItems entity)
        {
            _sellingItemsDal.Add(entity);
        }

        public void Delete(SellingItems entity)
        {
            _sellingItemsDal.Delete(entity);
        }

        public List<SellingItems> GetAll(string ara)
        {
            if (ara == null)
            {
                return _sellingItemsDal.GetAll();
            }
            else
            {
                return _sellingItemsDal.GetAll(p=>p.Name.Contains(ara));
            }
            
        }

        public List<SellingItems> GetAllCategoryId(int id)
        {
            return _sellingItemsDal.GetAll(p => p.CategoryId == id);
        }

        public void Update(SellingItems entity)
        {
            _sellingItemsDal.Update(entity);
        }
        public List<SellingItems> GetAllUserId(int id)
        {
            return _sellingItemsDal.GetAll(p => p.UserId == id);
        }
        public List<SellingItems> GetAllUrunId(int id)
        {
            return _sellingItemsDal.GetAll(p => p.Id == id);
        }

        public List<SellingItems> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
