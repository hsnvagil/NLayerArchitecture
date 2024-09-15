namespace App.Repositories.Products;

public interface IProductRepository : IGenericRepository<Product, int> {
    Task<List<Product>> GetTopPriceProductAsync(int count);
}