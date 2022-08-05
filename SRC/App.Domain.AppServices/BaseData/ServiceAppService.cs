using App.Domain.Core.BaseData.Contacts.AppService;
using App.Domain.Core.BaseData.Contacts.Service;
using App.Domain.Core.BaseData.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.BaseData
{
    public class ServiceAppService : IServiceAppService
    {
        private readonly IServiceService _serviceService;

        public ServiceAppService(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }
        public async Task Add(ServiceDto ServiceDto)
        {
            await _serviceService.Add(ServiceDto);
        }

        public async Task Delete(int Id)
        {
            await _serviceService.Delete(Id);
        }

        public async Task<ServiceDto> Get(int Id)
        {
            return await _serviceService.Get(Id);
        }

        public async Task<List<ServiceDto>> GetAll(CancellationToken cancellationToken)
        {
            return await _serviceService.GetAll(cancellationToken);
        }

        public async Task Update(ServiceDto ServiceDto)
        {
            await _serviceService.Update(ServiceDto);
        }
    }
}
