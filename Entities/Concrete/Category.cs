using Entities.Abstrack;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        [Key]
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public List<SellingItems> SellingItemss { get; set; }
        public List<SoldItems> SoldItemss { get; set; }
    }
}
