using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.BaseData.Dtos
{
    public class ServiceDto
    {
        public int Id { get; set; }
        public string CategoryTitle { get; set; }
        public string Title { get; set; }
        public string? ShortDescription { get; set; }
        public int Price { get; set;}
        public int Categoryid { get; set; }
    }
}
