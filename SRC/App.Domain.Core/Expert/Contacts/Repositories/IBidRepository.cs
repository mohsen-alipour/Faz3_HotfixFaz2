using App.Domain.Core.Expert.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Expert.Contacts.Repositories
{
    public interface IBidRepository
    {
        Task Add(BidDto BidDto);
        Task<List<BidDto>> GetAll();
        Task<BidDto> Get(int Id);
        Task Update(BidDto BidDto);
        Task Delete(int Id);
    }
}
