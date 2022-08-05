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
    public class ServiceCommentService : IServiceCommentService
    {
        private readonly IServiceCommentRepository _serviceCommentRepository;

        public ServiceCommentService(IServiceCommentRepository serviceCommentRepository)
        {
            _serviceCommentRepository = serviceCommentRepository;
        }
        public async Task Add(ServiceCommentDto ServiceCommentDto)
        {
            await _serviceCommentRepository.Add(ServiceCommentDto);
        }

        public async Task Delete(int Id)
        {
            await _serviceCommentRepository.Delete(Id);
        }

        public async Task<ServiceCommentDto> Get(int id)
        {
            return await _serviceCommentRepository.Get(id);
        }

        public async Task<List<ServiceCommentDto>> GetAll()
        {
            return await _serviceCommentRepository.GetAll();
        }

        public async Task Update(ServiceCommentDto ServiceCommentDto)
        {
            await _serviceCommentRepository.Update(ServiceCommentDto);
        }
    }
}
