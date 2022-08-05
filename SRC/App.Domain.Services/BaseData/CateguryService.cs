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
    public class CateguryService : ICateguryService
    {
        private readonly ICateguryRepository _categuryRepository;

        public CateguryService(ICateguryRepository categuryRepository)
        {
           _categuryRepository = categuryRepository;
        }
        public async Task Add(CategoryDto CategoryDto)
        {
            await _categuryRepository.Add(CategoryDto);
        }

        public async Task Delete(int Id)
        {
            await _categuryRepository.Delete(Id);
        }

        public async Task<CategoryDto> Get(int id)
        {
            return await _categuryRepository.Get(id);
        }

        public async Task<List<CategoryDto>> GetAll()
        {
            return await _categuryRepository.GetAll();
        }

        public async Task Update(CategoryDto CategoryDto)
        {
            await _categuryRepository.Update(CategoryDto);
        }
    }
}
