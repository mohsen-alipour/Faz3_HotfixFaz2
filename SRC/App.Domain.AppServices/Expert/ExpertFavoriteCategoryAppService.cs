using App.Domain.Core.Expert.Contacts.AppService;
using App.Domain.Core.Expert.Contacts.Service;
using App.Domain.Core.Expert.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Expert
{
    public class ExpertFavoriteCategoryAppService : IExpertFavoriteCategoryAppService
    {
        private readonly IExpertFavoriteCategoryService _ExpertFavoriteCategoryService;

        public ExpertFavoriteCategoryAppService(IExpertFavoriteCategoryService ExpertFavoriteCategoryService)
        {
           _ExpertFavoriteCategoryService = ExpertFavoriteCategoryService;
        }
        public async Task Add(ExpertFavoriteCategoryDto ExpertFavoriteCategoryDto)
        {
            await _ExpertFavoriteCategoryService.Add(ExpertFavoriteCategoryDto);
        }

        public async Task Delete(int Id)
        {
            await _ExpertFavoriteCategoryService.Delete(Id);
        }

        public async Task<ExpertFavoriteCategoryDto> Get(int Id)
        {
            return await _ExpertFavoriteCategoryService.Get(Id);
        }

        public async Task<List<ExpertFavoriteCategoryDto>> GetAll()
        {
            return await _ExpertFavoriteCategoryService.GetAll();
        }

        public async Task Update(ExpertFavoriteCategoryDto ExpertFavoriteCategoryDto)
        {
            await _ExpertFavoriteCategoryService.Update(ExpertFavoriteCategoryDto);
        }
    }
}
