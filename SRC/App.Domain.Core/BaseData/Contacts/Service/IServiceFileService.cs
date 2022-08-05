using App.Domain.Core.BaseData.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.BaseData.Contacts.Service
{
    public interface IServiceFileService
    {
        Task Add(ServiceFileDto ServiceFileDtocs);
        Task<List<ServiceFileDto>> GetAll();
        Task<ServiceFileDto> Get(int Id);
        Task Update(ServiceFileDto ServiceFileDtocs);
        Task Delete(int Id);
    }
}
