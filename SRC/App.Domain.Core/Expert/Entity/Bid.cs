using App.Domain.Core.Customer.Entity;
using System;
using System.Collections.Generic;

namespace App.Domain.Core.Expert.Entity
{
    public partial class Bid
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ExpertUserId { get; set; }
        public int SuggestedPrice { get; set; }
        public bool IsApproved { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Order Order { get; set; } = null!;
    }
}
