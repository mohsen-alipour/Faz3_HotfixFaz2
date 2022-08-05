using App.Domain.Core.BaseData.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.BaseData.Contacts.AppService
{
    public interface IAppFileAppService
    {
        Task Add(AppFileDto AppFileDto);
        Task<List<AppFileDto>> GetAll();
        Task<AppFileDto> Get(int Id);
        Task Update(AppFileDto AppFileDto);
        Task Delete(int Id);
    }
}
