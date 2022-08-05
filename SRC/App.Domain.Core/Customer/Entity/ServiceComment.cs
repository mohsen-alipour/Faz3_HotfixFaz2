using App.Domain.Core.BaseData.Entity;
using System;
using System.Collections.Generic;

namespace App.Domain.Core.Customer.Entity
{
    public partial class ServiceComment
    {
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public string? CommentText { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Service Service { get; set; } = null!;
    }
}
