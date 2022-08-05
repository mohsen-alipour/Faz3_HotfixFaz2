using App.Domain.Core.Customer.Entity;
using System;
using System.Collections.Generic;

namespace App.Domain.Core.BaseData.Entity
{
    public partial class Service
    {
        public Service()
        {
            Orders = new HashSet<Order>();
            ServiceComments = new HashSet<ServiceComment>();
            ServiceFiles = new HashSet<ServiceFile>();
        }

        public int Id { get; set; }
        public int Categoryid { get; set; }
        public string Title { get; set; } = null!;
        public string? ShortDescription { get; set; }
        public int Price { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<ServiceComment> ServiceComments { get; set; }
        public virtual ICollection<ServiceFile> ServiceFiles { get; set; }
    }
}
