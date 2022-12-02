using ETicaretAPI.Application.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ETicaretAPI.Application.Features.Commands.ProductImageFile.ChangeShowCaseImage
{
    public class ChangeShowCaseImageCommandRequest : IRequest<ChangeShowCaseImageCommandResponse>
    {
        public string ImageId { get; set; }
        public string ProductId { get; set; }
    }
    public class ChangeShowCaseImageCommandResponse
    {
    }
    public class ChangeShowCaseImageCommandHandler : IRequestHandler<ChangeShowCaseImageCommandRequest, ChangeShowCaseImageCommandResponse>
    {
        private readonly IProductImageFileWriteRepository _productImageFileWriteRepository;

        public ChangeShowCaseImageCommandHandler(IProductImageFileWriteRepository productImageFileWriteRepository)
        {
            _productImageFileWriteRepository = productImageFileWriteRepository;
        }

        public async Task<ChangeShowCaseImageCommandResponse> Handle(ChangeShowCaseImageCommandRequest request, CancellationToken cancellationToken)
        {
            var query = _productImageFileWriteRepository.Table
                .Include(p => p.Products)
                .SelectMany(p => p.Products, (pif, p) => new
                {
                    pif,
                    p
                });
            var data = await query.FirstOrDefaultAsync(p => p.p.Id == Guid.Parse(request.ProductId) && p.pif.Showcase);
            if (data != null)
                data.pif.Showcase = false;

            var image = await query.FirstOrDefaultAsync(p => p.pif.Id == Guid.Parse(request.ImageId));
            if (image != null)
                image.pif.Showcase = true;

            await _productImageFileWriteRepository.SaveAsync();
            return new();
        }
    }
}
