using Entities.Abstrack;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class User:IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Pasword { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public List<SellingItems> SellingItemss { get; set; }
        public List<SoldItems> SoldItemss { get; set; }
    }
}
