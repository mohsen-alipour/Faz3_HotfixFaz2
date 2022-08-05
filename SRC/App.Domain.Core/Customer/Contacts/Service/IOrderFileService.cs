using App.Domain.Core.Customer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.Contacts.Service
{
    public interface IOrderFileService
    {
        Task Add(OrderFileDto OrderFileDto);
        Task<List<OrderFileDto>> GetAll();
        Task<OrderFileDto> Get(int id);
        Task Update(OrderFileDto OrderFileDto);
        Task Delete(int Id);
    }
}
