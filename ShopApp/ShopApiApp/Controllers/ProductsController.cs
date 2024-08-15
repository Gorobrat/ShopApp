using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using ShopApiApp.Model;

namespace ShopApiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly MyDb dbContext;

        public ProductsController(MyDb dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<Product> GetAll()//async
        {
            return dbContext.Products;
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create(Product product)//async
        {
            var result = dbContext.Products.Add(product);
            dbContext.SaveChanges();
            return Ok(result.Entity);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)//async
        {
            var result = dbContext.Products.FirstOrDefault(x => x.Id == id);
            if (result != null)
            {
                dbContext.Remove(result);
                dbContext.SaveChanges();
            }
            return Ok(result);
        }

        [HttpGet("id")]
        public IActionResult Get(int id)//async
        {
            var result = dbContext.Products.FirstOrDefault(x => x.Id == id);
            dbContext.SaveChanges();
            return Ok(result);
        }

        [HttpGet]
        [Route("GetByKeyword")]
        public IActionResult Get(string? keyword)//async
        {
            var result = keyword == null
                ? dbContext.Products
                : dbContext
                .Products
                .Where(x => x.Id.ToString() == keyword || x.Name.Contains(keyword)||x.DataExpiration.Contains(keyword)||x.Description.Contains(keyword));

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult>Put(Product product)
        {
            var res =await dbContext
                .Products
                .FindAsync(product.Id);

            res.Name= product.Name;
            res.Description= product.Description;
            res.DataExpiration= product.DataExpiration;

            if (res != null)
            {
                dbContext.Products.Update(res);
                dbContext.SaveChanges();//async

            }
            return Ok(res);
        }
    }

}
