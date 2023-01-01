using ETicaretAPI.Application.Abstractions.Services;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using System.Text.Json;

namespace ETicaretAPI.Persistence.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IQRCodeService _qRCodeService;
        public ProductService(IProductReadRepository productReadRepository, IQRCodeService qRCodeService)
        {
            _productReadRepository = productReadRepository;
            _qRCodeService = qRCodeService;
        }

        public async Task<byte[]> QrCodeToProductAsync(string productId)
        {
            Product product = await _productReadRepository.GetByIdAsync(productId);
            if (product == null)
                throw new Exception("Product Not Found");

            var plainObject = new 
            {
                product.Id,
                product.Name,
                product.Price,
                product.Stock,
                product.CreatedDate
            };
            string plainText = JsonSerializer.Serialize(plainObject);

            return _qRCodeService.GenerateQRCodeAsync(plainText);
        }
    }
}
