using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }
        public int ServiceBasePrice { get; set; }
        public int FainalExpertUserid { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CustomerUserId { get; set; }

        #region مشاهده سفارش
        public string Servicetitle { get; set; }
        public string CustomerUserName { get; set; }
        public string FainalExpertUserName { get; set; }
        // public int BasePrice { get; set; }
        public int TotalPrice { get; set; }
        //public DateTime OrderDate { get; set; }
        public string Statustitle { get; set; }
        #endregion مشاهده سفارش

        #region ثبت سفارش
    
        public byte StatusId { get; set; }
      
        public int Serviceid { get; set; }
      
        #endregion ثبت سفارش


    }
}
