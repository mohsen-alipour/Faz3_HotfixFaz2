using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.BaseData.Dtos
{
    public class AppFileDto
    {
        public int Id { get; set; }
        public string FileNme { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
