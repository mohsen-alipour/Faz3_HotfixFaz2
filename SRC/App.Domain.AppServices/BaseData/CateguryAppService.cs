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
    public class CateguryAppService : ICateguryAppService
    {
        private readonly ICateguryService _categuryService;

        public CateguryAppService(ICateguryService categuryService)
        {
            _categuryService = categuryService;
        }
        public async Task Add(CategoryDto CategoryDto)
        {
            await _categuryService.Add(CategoryDto);
        }

        public async Task Delete(int Id)
        {
            await _categuryService.Delete(Id);
        }

        public async Task<CategoryDto> Get(int Id)
        {
            return await _categuryService.Get(Id);
        }

        public async Task<List<CategoryDto>> GetAll()
        {
            return await _categuryService.GetAll();
        }

        public async Task Update(CategoryDto CategoryDto)
        {
            await _categuryService.Update(CategoryDto);
        }
    }
}
