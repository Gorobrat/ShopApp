using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShopApiApp.DTOs;
using ShopApiApp.Model;
using System.Net.WebSockets;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ShopApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly MyDb dbContext;

        public UsersController(MyDb dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public  List<User> Get()//async
        {
            var result = dbContext.Users.ToList();

            return result;
        }

        [HttpGet]
        [Route("id")]
        public IActionResult Get(int userId)//async
        {
            var result = dbContext
                .Users
                .FirstOrDefault(x => x.Id == userId);

            return Ok(result);
        }

        [HttpGet]
        [Route("GetByKeyword")]
        public IActionResult Get(string? keyword)//async
        {
                var result = keyword == null
                    ? dbContext.Users
                    : dbContext
                    .Users
                    .Where(x => x.Id.ToString() == keyword || x.Name.Contains(keyword)||x.Address.Contains(keyword)||x.PhoneNumber.Contains(keyword));
            
            return Ok(result);
        }

        [HttpPost("CheackLogIn")]
        public async Task<IActionResult> CheackLogIn(Login login)//async
        {
            var result = await
                dbContext
                .Users
                .FirstOrDefaultAsync(x => x.Name == login.Username && x.Password == login.Password);

            if(result == null)
            {
                return Ok(false);
            }

            return Ok(true);
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult Post(CreateUserModel user)
        {
            var dbUser = new User
            {
                Name = user.Name,
                Password=user.Password,
                Address = user.Address,
                PhoneNumber = user.PhoneNumber,
            };
            var result = dbContext
                .Users
                .Add(dbUser);

            dbContext.SaveChanges();///async
            return Ok(result.Entity);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateUserModel userModel)
        {  var result = await dbContext
                .Users
                .FindAsync(userModel.Id);
            if(result == null)
            {
                return NotFound();
            }
            result.Name = userModel.Name;
            result.Password = userModel.Password;
            result.Address = userModel.Address;
            result.PhoneNumber = userModel.PhoneNumber;

            dbContext.Update(result);
            await dbContext.SaveChangesAsync();

            return Ok(result);
        }

        [HttpDelete("{userId}")]
        public async Task<IActionResult> DeleteUser(int userId)
        {
            var result = await dbContext
                .Users
                .FindAsync(userId);

            if (result != null)
            {
                dbContext.Users.Remove(result);
                dbContext.SaveChanges();
            }
            return Ok(result);
        }
    }
}
