using App.Domain.Core.BaseData.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.BaseData.Contacts.Repositories
{
    public interface IServiceRepository
    {
        Task Add(ServiceDto ServiceDto);
        Task<List<ServiceDto>> GetAll(CancellationToken cancellationToken);
        Task<ServiceDto> Get(int id);
        Task Update(ServiceDto ServiceDto);
        Task Delete(int Id);
    }
}
