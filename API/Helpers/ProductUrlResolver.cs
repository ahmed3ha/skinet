using API.Dtos;
using AutoMapper;
using Core.Entites;
using Microsoft.Extensions.Configuration;

namespace API.Helpers
{
    public class ProductURlResolver : IValueResolver<Product, ProductToReturnDto, string>
    {
        private readonly IConfiguration _config;
        public ProductURlResolver(IConfiguration config)
        {
            _config = config;
        }

        public string Resolve(Product source,
        ProductToReturnDto destination,
        string destMember, ResolutionContext context)
        {
            if (!string.IsNullOrEmpty(source.PictureUrl))
            {
                return _config["ApiUrl"] +source.PictureUrl;
            }
            return null;

        }
    }
}