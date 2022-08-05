using App.Domain.Core.Expert.Contacts.Repositories;
using App.Domain.Core.Expert.Contacts.Service;
using App.Domain.Core.Expert.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Services.Expert
{
    public class BidService : IBidService
    {
        private readonly IBidRepository _bidRepository;

        public BidService(IBidRepository bidRepository)
        {
            _bidRepository = bidRepository;
        }
        public async Task Add(BidDto BidDto)
        {
            await _bidRepository.Add(BidDto);
        }

        public async Task Delete(int Id)
        {
            await _bidRepository.Delete(Id);
        }

        public async Task<BidDto> Get(int id)
        {
            return await _bidRepository.Get(id);
        }

        public async Task<List<BidDto>> GetAll()
        {
            return await _bidRepository.GetAll();
        }

        public async Task Update(BidDto BidDto)
        {
            await _bidRepository.Update(BidDto);
        }
    }
}
