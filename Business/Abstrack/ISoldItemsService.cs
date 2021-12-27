using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstrack
{
    public interface ISoldItemsService
    {
        List<SoldItems> GetAll();
        void Add(SoldItems entity);
        void Update(SoldItems entity);
        void Delete(SoldItems entity);
    }
}
