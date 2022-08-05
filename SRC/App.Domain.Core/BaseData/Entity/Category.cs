using App.Domain.Core.Expert.Entity;
using System;
using System.Collections.Generic;

namespace App.Domain.Core.BaseData.Entity
{
    public partial class Category
    {
        public Category()
        {
            ExpertFavoriteCategories = new HashSet<ExpertFavoriteCategory>();
            Services = new HashSet<Service>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public virtual ICollection<ExpertFavoriteCategory> ExpertFavoriteCategories { get; set; }
        public virtual ICollection<Service> Services { get; set; }
    }
}
