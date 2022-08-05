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
    public class AppFileAppService : IAppFileAppService
    {
        private readonly IAppFileService _AppFileService;

        public AppFileAppService(IAppFileService AppFileService)
        {
            _AppFileService = AppFileService;
        }

        public async Task Add(AppFileDto AppFileDto)
        {
           await _AppFileService.Add(AppFileDto);
        }

        public async Task Delete(int Id)
        {
            await _AppFileService.Delete(Id);
        }

        public async Task<AppFileDto> Get(int Id)
        {
           return await _AppFileService.Get(Id);
        }

        public async Task<List<AppFileDto>> GetAll()
        {
            return await _AppFileService.GetAll();
        }

        public async Task Update(AppFileDto AppFileDto)
        {
           await _AppFileService.Update(AppFileDto);
        }
    }
}
