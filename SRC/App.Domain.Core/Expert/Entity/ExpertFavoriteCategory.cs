using App.Domain.Core.BaseData.Entity;
using System;
using System.Collections.Generic;

namespace App.Domain.Core.Expert.Entity
{
    public partial class ExpertFavoriteCategory
    {
        public int Id { get; set; }
        public int ExpertUserId { get; set; }
        public int Categoryid { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Category Category { get; set; } = null!;
    }
}
