using App.Domain.Core.BaseData.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.BaseData.Contacts.Service
{
    public interface IStatusService
    {
        Task Add(StatusDto StatusDto);
        Task<List<StatusDto>> GetAll();
        Task<StatusDto> Get(int Id);
        Task Update(StatusDto StatusDto);
        Task Delete(int Id);
    }
}
