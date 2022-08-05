using App.Domain.Core.Customer.Entity;
using System;
using System.Collections.Generic;

namespace App.Domain.Core.BaseData.Entity
{
    public partial class Status
    {
        public Status()
        {
            Orders = new HashSet<Order>();
        }

        public byte Id { get; set; }
        public string Title { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; }
    }

   
}
