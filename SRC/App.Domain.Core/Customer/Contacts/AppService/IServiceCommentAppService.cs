using App.Domain.Core.Customer.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.Contacts.AppService
{
    public interface IServiceCommentAppService
    {
        Task Add(ServiceCommentDto ServiceCommentDto);
        Task<List<ServiceCommentDto>> GetAll();
        Task<ServiceCommentDto> Get(int id);
        Task Update(ServiceCommentDto ServiceCommentDto);
        Task Delete(int Id);
    }
}
