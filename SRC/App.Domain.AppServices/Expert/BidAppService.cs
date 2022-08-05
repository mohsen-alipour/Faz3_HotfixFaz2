using App.Domain.Core.Expert.Contacts.AppService;
using App.Domain.Core.Expert.Contacts.Service;
using App.Domain.Core.Expert.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Expert
{
   
    public class BidAppService : IBidAppService
    {
        private readonly IBidService _BidService;

        public BidAppService(IBidService BidService)
        {
            _BidService = BidService;
        }
        public async Task Add(BidDto BidDto)
        {
            await _BidService.Add(BidDto);
        }

        public async Task Delete(int Id)
        {
            await _BidService.Delete(Id);
        }

        public async Task<BidDto> Get(int Id)
        {
            return await _BidService.Get(Id);
        }

        public async Task<List<BidDto>> GetAll()
        {
            return await _BidService.GetAll();
        }

        public async Task Update(BidDto BidDto)
        {
            await _BidService.Update(BidDto);
        }
    }
}
