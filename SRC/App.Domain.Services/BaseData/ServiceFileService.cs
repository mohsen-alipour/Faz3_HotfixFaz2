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
    public class ServiceFileService : IServiceFileService
    {
        private readonly IServiceFileRepository _serviceFileRepository;

        public ServiceFileService(IServiceFileRepository serviceFileRepository)
        {
            _serviceFileRepository = serviceFileRepository;
        }
        public async Task Add(ServiceFileDto ServiceFileDtocs)
        {
           await _serviceFileRepository.Add(ServiceFileDtocs);
        }

        public async Task Delete(int Id)
        {
            await _serviceFileRepository.Delete(Id);
        }

        public async Task<ServiceFileDto> Get(int Id)
        {
            return await _serviceFileRepository.Get(Id);
        }

        public async Task<List<ServiceFileDto>> GetAll()
        {
            return await _serviceFileRepository.GetAll();
        }

        public async Task Update(ServiceFileDto ServiceFileDtocs)
        {
            await _serviceFileRepository.Update(ServiceFileDtocs);
        }
    }
}
