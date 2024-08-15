using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopApiApp.DTOs;
using ShopApiApp.Model;

namespace ShopApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly MyDb dbContext;

        public OrdersController(MyDb dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateOrderDTO orderDTO)
        {
            var newOrder = new Order
            {
                User = await dbContext.Users.FindAsync(orderDTO.UserId),
                Date = DateTime.Now,
                Items = orderDTO.Items.Select(ToEntity).ToList(),
            };

            var result = dbContext.Orders.Add(newOrder);

            await dbContext.SaveChangesAsync();

            return Ok(result.Entity);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await dbContext
                .Orders
                .Include(o => o.Items).ThenInclude(i => i.Product)
                .ToListAsync();

            return Ok(result);
        }

        [HttpGet]
        [Route("GetByKeyword")]
        public IActionResult Get(string? keyword)//async
        {
            var result = keyword == null
                ? dbContext.Orders
                : dbContext
                .Orders
                .Where(o => o.Id.ToString() == keyword || o.User.Id.ToString().Contains(keyword));//Order obekti mej tipic a datatime

            return Ok(result);
        }

        [HttpGet]
        [Route("/users/{userId}/[controller]")]
        public async Task<IActionResult> GetByUserId(int userId)
        {
            var result = await dbContext
                .Orders
                .Where(o => o.User.Id == userId)
                .Include(o => o.User)
                //.Include(o => o.Date)
                .Include(o => o.Items).ThenInclude(i => i.Product)
                .ToListAsync();

            return Ok(result);
        }

        [HttpGet]
        [Route("id")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await dbContext
                .Orders
                .Where(o => o.Id == id)
                .Include(o => o.Items).ThenInclude(i => i.Product)
                .FirstOrDefaultAsync();

            return Ok(result);
        }

        private OrderItem ToEntity(OrderItemDTO orderItemDTO)
        {
            return new OrderItem
            {
                Product = dbContext.Products.Find(orderItemDTO.ProductId),
                Count = orderItemDTO.Count,
            };
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)//async
        {
            var result = dbContext.Orders.FirstOrDefault(x => x.Id == id);
            if (result != null)
            {
                dbContext.Orders.Remove(result);
                dbContext.SaveChanges();
            }
            return Ok(result);/// vveradarcnmum a menak useri in meke items?>??????heto
        }
       
    }
}
