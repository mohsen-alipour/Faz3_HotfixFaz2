using App.Domain.Core.BaseData.Entity;
using System;
using System.Collections.Generic;

namespace App.Domain.Core.Customer.Entity
{
    public partial class OrderFile
    {
        public int Id { get; set; }
        public int FileId { get; set; }
        public int OrderId { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual AppFile File { get; set; } 
        public virtual Order Order { get; set; } 
    }
}
