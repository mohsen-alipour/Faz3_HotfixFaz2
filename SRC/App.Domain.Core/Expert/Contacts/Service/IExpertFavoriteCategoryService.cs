using App.Domain.Core.Expert.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.Contacts.Service
{
    public interface IExpertFavoriteCategoryService
    {
        Task Add(ExpertFavoriteCategoryDto ExpertFavoriteCategoryDto);
        Task<List<ExpertFavoriteCategoryDto>> GetAll();
        Task<ExpertFavoriteCategoryDto> Get(int id);
        Task Update(ExpertFavoriteCategoryDto ExpertFavoriteCategoryDto);
        Task Delete(int Id);
    }
}
