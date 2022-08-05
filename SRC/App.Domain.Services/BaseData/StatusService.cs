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
    public class StatusService : IStatusService
    {
        private readonly IStatusRepository _statusRepository;

        public StatusService(IStatusRepository statusRepository)
        {
            _statusRepository = statusRepository;
        }
        public async Task Add(StatusDto StatusDto)
        {
           await _statusRepository.Add(StatusDto);
        }

        public async Task Delete(int Id)
        {
           await _statusRepository.Delete(Id);
        }

        public async Task<StatusDto> Get(int Id)
        {
            return await _statusRepository.Get(Id);
        }

        public async Task<List<StatusDto>> GetAll()
        {
            return await _statusRepository.GetAll();
        }

        public async Task Update(StatusDto StatusDto)
        {
            await _statusRepository.Update(StatusDto);
        }
    }
}
