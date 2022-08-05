using App.Domain.Core.BaseData.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.BaseData.Contacts.AppService
{
    public interface IServiceFileAppService
    {
        Task Add(ServiceFileDto ServiceFileDtocs);
        Task<List<ServiceFileDto>> GetAll();
        Task<ServiceFileDto> Get(int id);
        Task Update(ServiceFileDto CategoryDto);
        Task Delete(int Id);
    }
}
