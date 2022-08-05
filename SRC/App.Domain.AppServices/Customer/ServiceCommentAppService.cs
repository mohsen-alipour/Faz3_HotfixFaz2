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
    public class ServiceCommentAppService : IServiceCommentAppService
    {
        private readonly IServiceCommentService _serviceCommentService;

        public ServiceCommentAppService(IServiceCommentService serviceCommentService)
        {
            _serviceCommentService = serviceCommentService;
        }
        public async Task Add(ServiceCommentDto ServiceCommentDto)
        {
            await _serviceCommentService.Add(ServiceCommentDto);
        }

        public async Task Delete(int Id)
        {
            await _serviceCommentService.Delete(Id);
        }

        public async Task<ServiceCommentDto> Get(int id)
        {
           return await _serviceCommentService.Get(id);
        }

        public async Task<List<ServiceCommentDto>> GetAll()
        {
            return await _serviceCommentService.GetAll();
        }

        public async Task Update(ServiceCommentDto ServiceCommentDto)
        {
            await _serviceCommentService.Update(ServiceCommentDto);
        }
    }
}
