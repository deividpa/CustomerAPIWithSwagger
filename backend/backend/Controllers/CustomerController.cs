using backend.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        [HttpGet]
        public async Task<List<CustomerDTO>> GetCustomers()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<CustomerDTO> CreateCustomer(CreateCustomerDTO customer)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public async Task<CustomerDTO> GetCustomer(long id) {
            throw new NotImplementedException();
        }

        [HttpPut]
        public async Task<CustomerDTO> UpdateCustomer(CustomerDTO customer)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeleteCustomer(long id)
        {
            throw new NotImplementedException();
        }
    }
}
