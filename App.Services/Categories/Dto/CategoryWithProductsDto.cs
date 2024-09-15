using App.Services.Products;
using App.Services.Products.Dto;

namespace App.Services.Categories;

public record CategoryWithProductsDto(int Id, string Name, List<ProductDto> Products);