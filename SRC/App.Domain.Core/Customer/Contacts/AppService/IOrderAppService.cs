using App.Domain.Core.Customer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.Contacts.AppService
{
    public interface IOrderAppService
    {
        Task Add(OrderDto OrderDto);
        Task<List<OrderDto>> GetAll(CancellationToken cancellationToken);
        Task<OrderDto> Get(int id);
        Task Update(OrderDto OrderDto);
        Task Delete(int Id);
    }
}
