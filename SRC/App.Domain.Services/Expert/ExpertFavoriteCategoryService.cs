using App.Domain.Core.Expert.Contacts.Repositories;
using App.Domain.Core.Expert.Contacts.Service;
using App.Domain.Core.Expert.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.Expert
{
    public class ExpertFavoriteCategoryService : IExpertFavoriteCategoryService
    {
        private readonly IExpertFavoriteCategoryRepository _expertFavoriteCategoryRepository;

        public ExpertFavoriteCategoryService(IExpertFavoriteCategoryRepository expertFavoriteCategoryRepository)
        {
            _expertFavoriteCategoryRepository = expertFavoriteCategoryRepository;
        }
        public async Task Add(ExpertFavoriteCategoryDto ExpertFavoriteCategoryDto)
        {
                await _expertFavoriteCategoryRepository.Add(ExpertFavoriteCategoryDto);
        }

        public async Task Delete(int Id)
        {
            await _expertFavoriteCategoryRepository.Delete(Id);
        }

        public async Task<ExpertFavoriteCategoryDto> Get(int id)
        {
            return await _expertFavoriteCategoryRepository.Get(id);
        }

        public async Task<List<ExpertFavoriteCategoryDto>> GetAll()
        {
            return await _expertFavoriteCategoryRepository.GetAll();
        }

        public async Task Update(ExpertFavoriteCategoryDto ExpertFavoriteCategoryDto)
        {
            await _expertFavoriteCategoryRepository.Update(ExpertFavoriteCategoryDto);
        }
    }
}
