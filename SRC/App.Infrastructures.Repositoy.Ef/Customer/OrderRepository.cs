using App.Domain.Core.BaseData.Entity;
using App.Domain.Core.Customer.Contacts.Repositories;
using App.Domain.Core.Customer.Dtos;
using App.Domain.Core.Customer.Entity;
using App.Infrastructures.Database.SqlServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructures.Repositoy.Ef.Customer
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly UserManager<AppUser> _userManager;

        public OrderRepository(AppDbContext DbContext, UserManager<AppUser> userManager)
        {
            _dbContext = DbContext;
            _userManager = userManager;
        }

        /// <summary>
        /// ثبت سفارشات توسط مشتریان
        /// </summary>
        /// <param name="OrderDto"></param>
        /// <returns></returns>
        public async Task Add(OrderDto OrderDto)
        {
            Order order = new Order
            {
                StatusId=OrderDto.StatusId,
                ServiceBasePrice = OrderDto.ServiceBasePrice,
                Serviceid = OrderDto.Serviceid,
                CreatedAt=OrderDto.CreatedAt,
            };
            _dbContext.Orders.Add(order);
            await _dbContext.SaveChangesAsync();
        }

    /// <summary>
    /// حذف سفارش از سبد خرید
    /// </summary>
    /// <param name="Id"></param>
    /// <returns></returns>
        public async Task Delete(int Id)
        {
            var record = await _dbContext.Orders.Where(p => p.Id == Id).SingleOrDefaultAsync();
            _dbContext.Orders.Remove(record);
            _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// مشاهده لیست کلیه سفارشات مشتری
        /// </summary>
        public async Task<OrderDto> Get(int id)
        {
            return await _dbContext.Orders.Where(p => p.Id == id).Select(u => new OrderDto()
            {
                Id = u.Id,
                Servicetitle=u.Service.Title,
                CustomerUserId=u.CustomerUserId,
                
            }).SingleAsync();
        }
      
        public async Task<List<OrderDto>> GetAll(CancellationToken cancellationToken)
        {
           
            return await _dbContext.Orders.Select(p => new OrderDto()
            {
                Id=p.Id,
                Servicetitle = p.Service.Title,

                CustomerUserName = _userManager.Users.Where(u => u.Id == p.CustomerUserId)
                .Select(x => x.UserName).SingleOrDefault(),

                ServiceBasePrice = p.Service.Price,

                TotalPrice = _dbContext.Bids.Where(u => u.OrderId == p.Id && u.IsApproved ==true)
                .Select(x=>x.SuggestedPrice).SingleOrDefault(),

                CreatedAt = p.CreatedAt,
                Statustitle = p.Status.Title,

                FainalExpertUserName = _userManager.Users.Where(u => u.Id == p.FainalExpertUserid)
                .Select(p => p.UserName).SingleOrDefault(),
            }).ToListAsync();
        }

        public Task Update(OrderDto OrderDto)
        {
            throw new NotImplementedException();
        }
    }
}
