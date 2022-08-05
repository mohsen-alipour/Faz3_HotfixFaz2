using App.Domain.Core.BaseData.Contacts.Repositories;
using App.Domain.Core.BaseData.Contacts.Service;
using App.Domain.Core.BaseData.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.BaseData
{
    public class ServiceService : IServiceService
    {
        private readonly IServiceRepository _serviceRepository;

        public ServiceService(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
        public async Task Add(ServiceDto ServiceDto)
        {
           await _serviceRepository.Add(ServiceDto);
        }

        public async Task Delete(int Id)
        {
            await _serviceRepository.Delete(Id);
        }

        public async Task<ServiceDto> Get(int Id)
        {
            return await _serviceRepository.Get(Id);
        }

        public async Task<List<ServiceDto>> GetAll(CancellationToken cancellationToken)
        {
            return await _serviceRepository.GetAll(cancellationToken);
        }

        public async Task Update(ServiceDto ServiceDto)
        {
            await _serviceRepository.Update(ServiceDto);
        }
    }
}
