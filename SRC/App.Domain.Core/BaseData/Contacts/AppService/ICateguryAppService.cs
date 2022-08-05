using App.Domain.Core.BaseData.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.BaseData.Contacts.AppService
{
    public interface ICateguryAppService
    {
        Task Add(CategoryDto CategoryDto);
        Task<List<CategoryDto>> GetAll();
        Task<CategoryDto> Get(int id);
        Task Update(CategoryDto CategoryDto);
        Task Delete(int Id);
    }
}
