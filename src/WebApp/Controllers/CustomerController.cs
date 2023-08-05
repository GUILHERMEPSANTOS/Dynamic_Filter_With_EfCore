using DynamicFilter.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Data.Context;
using WebApp.Domain;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("customer")]
    public class CustomerController : ControllerBase
    {
        private readonly IDynamicFilter _dynamicFilter;
        private readonly ApplicationDbContext _context;

        public CustomerController(IDynamicFilter dynamicFilter, ApplicationDbContext context)
        {
            _dynamicFilter = dynamicFilter;
            _context = context;

        }

        [HttpPost]
        public async Task<IActionResult> GetCostumerByFilter([FromBody] PaginationFilter paginationFilter)
        {
            var expressionDynamic = _dynamicFilter.Generate<Customer>(paginationFilter.Filters.ToList());
            var customers = await _context.Customers.Where(expressionDynamic).ToListAsync();

            return Ok(customers);
        }
    }
}
