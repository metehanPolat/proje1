using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstrack
{
    public interface ISellingItemsService
    {
        List<SellingItems> GetAllCategoryId(int id);
        List<SellingItems> GetAll();
        List<SellingItems> GetAll(string ara);
        void Add(SellingItems entity);
        void Update(SellingItems entity);
        void Delete(SellingItems entity);
    }
}
