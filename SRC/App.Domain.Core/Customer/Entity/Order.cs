using App.Domain.Core.BaseData.Entity;
using App.Domain.Core.Expert.Entity;
using System;
using System.Collections.Generic;

namespace App.Domain.Core.Customer.Entity
{
    public partial class Order
    {
        public Order()
        {
            Bids = new HashSet<Bid>();
            OrderFiles = new HashSet<OrderFile>();
        }

        public int Id { get; set; }
        public byte StatusId { get; set; }
        public int Serviceid { get; set; }
        public int ServiceBasePrice { get; set; }
        public int CustomerUserId { get; set; }
        public int FainalExpertUserid { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Service Service { get; set; } = null!;
        public virtual Status Status { get; set; } = null!;
        public virtual ICollection<Bid> Bids { get; set; }
        public virtual ICollection<OrderFile> OrderFiles { get; set; }
    }
}
