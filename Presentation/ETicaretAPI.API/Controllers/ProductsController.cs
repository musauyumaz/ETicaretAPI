using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;

        readonly private IOrderWriteRepository _orderWriteRepository;
        readonly private IOrderReadRepository _orderReadRepository;

        readonly private ICustomerWriteRepository _customerWriteRepository;
        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository, IOrderWriteRepository orderWriteRepository, IOrderReadRepository orderReadRepository, ICustomerWriteRepository customerWriteRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _orderReadRepository = orderReadRepository;
            _customerWriteRepository = customerWriteRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            //var customerId = Guid.NewGuid();
            //await _customerWriteRepository.AddAsync(new() {Id = customerId,Name ="Muiidddin" });

            //await _orderWriteRepository.AddAsync(new() {Description ="bla bla bla",Address = "Ankara, Çankaya" ,CustomerId = customerId});
            //await _orderWriteRepository.AddAsync(new() {Description ="bla bla bla 2",Address = "Ankara, Pursaklar", CustomerId = customerId });
            //await _orderWriteRepository.SaveAsync(); 

            var order = await _orderReadRepository.GetByIdAsync("78563f7f-c744-4771-b4ac-e4f2b36ac847");
            order.Address = "İstanbul";
            await _orderWriteRepository.SaveAsync();
        }
       
    }
}
