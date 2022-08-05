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
    public class StatusAppService : IStatusAppService
    {
        private readonly IStatusService _statusService;

        public StatusAppService(IStatusService statusService)
        {
            _statusService = statusService;
        }
        public async Task Add(StatusDto StatusDto)
        {
            await _statusService.Add(StatusDto);
        }

        public async Task Delete(int Id)
        {
            await _statusService.Delete(Id);
        }

        public async Task<StatusDto> Get(int Id)
        {
            return await _statusService.Get(Id);
        }

        public async Task<List<StatusDto>> GetAll()
        {
            return await _statusService.GetAll();
        }

        public async Task Update(StatusDto StatusDto)
        {
            await _statusService.Update(StatusDto);
        }
    }
}
