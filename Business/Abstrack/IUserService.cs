using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstrack
{
    public interface IUserService
    {
        List<User> GetAll();
        List<User> GetAllId(int id);//Bundan kurtulacağım gibi ama emin ol
        void Add(User entity);
        void Update(User entity);
    }
}
