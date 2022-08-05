using App.Domain.Core.Customer.Contacts.Repositories;
using App.Domain.Core.Customer.Contacts.Service;
using App.Domain.Core.Customer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.Customer
{
    public class OrderFileService : IOrderFileService
    {
        private readonly IOrderFileRepository _orderFileRepository;

        public OrderFileService(IOrderFileRepository orderFileRepository)
        {
            _orderFileRepository = orderFileRepository;
        }
        public async Task Add(OrderFileDto OrderFileDto)
        {
            await _orderFileRepository.Add(OrderFileDto);
        }

        public async Task Delete(int Id)
        {
            await _orderFileRepository.Delete(Id);
        }

        public async Task<OrderFileDto> Get(int id)
        {
            return await _orderFileRepository.Get(id);
        }

        public async Task<List<OrderFileDto>> GetAll()
        {
            return await _orderFileRepository.GetAll();
        }

        public async Task Update(OrderFileDto OrderFileDto)
        {
            await _orderFileRepository.Update(OrderFileDto);
        }
    }
}
