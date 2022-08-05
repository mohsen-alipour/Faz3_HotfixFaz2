using App.Domain.Core.Customer.Contacts.AppService;
using App.Domain.Core.Customer.Contacts.Service;
using App.Domain.Core.Customer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Customer
{
    public class OrderFileAppService : IOrderFileAppService
    {
        private readonly IOrderFileService _orderFileService;

        public OrderFileAppService(IOrderFileService orderFileService)
        {
            _orderFileService = orderFileService;
        }
        public async Task Add(OrderFileDto OrderFileDto)
        {
            await _orderFileService.Add(OrderFileDto);
        }

        public async Task Delete(int Id)
        {
            await _orderFileService.Delete(Id);
        }

        public async Task<OrderFileDto> Get(int id)
        {
            return await _orderFileService.Get(id);
        }

        public async Task<List<OrderFileDto>> GetAll()
        {
            return await _orderFileService.GetAll();
        }

        public async Task Update(OrderFileDto OrderFileDto)
        {
            await _orderFileService.Update(OrderFileDto);
        }
    }
}
