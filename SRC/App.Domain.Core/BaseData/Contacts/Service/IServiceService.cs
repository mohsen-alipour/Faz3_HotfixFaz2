using App.Domain.Core.BaseData.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.BaseData.Contacts.Service
{
    public interface IServiceService
    {
        Task Add(ServiceDto ServiceDto);
        Task<List<ServiceDto>> GetAll(CancellationToken cancellationToken);
        Task<ServiceDto> Get(int Id);
        Task Update(ServiceDto ServiceDto);
        Task Delete(int Id);
    }
}
