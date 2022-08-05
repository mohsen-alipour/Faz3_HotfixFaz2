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
    public class AppFileService : IAppFileService
    {
        private readonly IAppFileRepository _AppFileRepository;

        public AppFileService(IAppFileRepository AppFileRepository)
        {
            _AppFileRepository = AppFileRepository;
        }
        public async Task Add(AppFileDto AppFileDto)
        {
            await _AppFileRepository.Add(AppFileDto);
        }

        public async Task Delete(int Id)
        {
            await _AppFileRepository.Delete(Id);
        }

        public async Task<AppFileDto> Get(int id)
        {
            return await _AppFileRepository.Get(id);
        }

        public async Task<List<AppFileDto>> GetAll()
        {
            return await _AppFileRepository.GetAll();
        }

        public async Task Update(AppFileDto AppFileDto)
        {
            await _AppFileRepository.Update(AppFileDto);
        }
    }
}
