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
    public class AppFileRepository : IAppFileRepository
    {
        private readonly AppDbContext _dbContext;

        public AppFileRepository(AppDbContext DbContext)
        {
            _dbContext = DbContext;
        }
        public async Task Add(AppFileDto AppFileDto)
        {
            AppFile F = new AppFile()
            {
                CreatedAt = DateTime.Now,
                FileAddress = AppFileDto.FileNme,
                CreatedUserId = AppFileDto.CreatedUserId,
            };

            _dbContext.Files.Add(F);
            await _dbContext.SaveChangesAsync();
            
        }

        public Task Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<AppFileDto> Get(int Id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<AppFileDto>> GetAll()
        {
            return await _dbContext.Files.Select(p => new AppFileDto()
            {
                FileNme=p.FileAddress,
                CreatedAt=p.CreatedAt,
                Id=p.Id,
            }).ToListAsync();
        }

        public Task Update(AppFileDto AppFileDto)
        {
            throw new NotImplementedException();
        }
    }
}
