using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstrack
{
    public interface IAdminService
    {
        List<Admin> GetAll();
        List<Admin> GetAllId(int id);
    }
}
