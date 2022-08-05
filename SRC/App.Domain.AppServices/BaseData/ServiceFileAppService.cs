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
    public class ServiceFileAppService : IServiceFileAppService
    {
        private readonly IServiceFileService _serviceFileService;

        public ServiceFileAppService(IServiceFileService serviceFileService)
        {
            _serviceFileService = serviceFileService;
        }
        public async Task Add(ServiceFileDto ServiceFileDto)
        {
            await _serviceFileService.Add(ServiceFileDto);
        }

        public async Task Delete(int Id)
        {
            await _serviceFileService.Delete(Id);
        }

        public async Task<ServiceFileDto> Get(int Id)
        {
            return await _serviceFileService.Get(Id);
        }

        public async Task<List<ServiceFileDto>> GetAll()
        {
            return await _serviceFileService.GetAll();
        }

        public async Task Update(ServiceFileDto ServiceFileDto)
        {
            await _serviceFileService.Update(ServiceFileDto);
        }
    }
}
