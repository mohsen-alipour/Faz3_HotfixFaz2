using App.Domain.Core.BaseData.Contacts.Repositories;
using App.Domain.Core.BaseData.Dtos;
using App.Domain.Core.BaseData.Entity;
using App.Infrastructures.Database.SqlServer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructures.Repositoy.Ef.BaseData
{
    public class StatusRepository : IStatusRepository
    {
        private readonly AppDbContext _DbContext;

        public StatusRepository(AppDbContext DbContext)
        {
            _DbContext = DbContext;
        }
        public async Task Add(StatusDto StatusDto)
        {
            Status status = new Status
            {
                Id = StatusDto.Id,
                Title = StatusDto.Title,
          
            };
            _DbContext.Statuses.Add(status);
            await _DbContext.SaveChangesAsync();
        }

        public async Task Delete(int Id)
        {
            var record = await _DbContext.Statuses.Where(p => p.Id == Id).SingleOrDefaultAsync();
            _DbContext.Statuses.Remove(record);
            _DbContext.SaveChangesAsync();
        }

        public async Task<StatusDto> Get(int id)
        {
            return await _DbContext.Statuses.Where(p => p.Id == id).Select(p => new StatusDto()
            {
                Id=p.Id,
                Title=p.Title,
            }).SingleAsync();
        }

        public async Task<List<StatusDto>> GetAll()
        {
            return await _DbContext.Statuses.Select(p => new StatusDto()
            {
                Id = p.Id,
                Title = p.Title,
            }).ToListAsync();
        }

        public async Task Update(StatusDto StatusDto)
        {
            var record = await _DbContext.Statuses.Where(p => p.Id == StatusDto.Id).SingleOrDefaultAsync();
            record.Title = StatusDto.Title;
            _DbContext.SaveChangesAsync();
        }
    }
}
