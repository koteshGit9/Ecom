using Ecom.Entity;

namespace Ecom.Services
{
    public interface IproductSevice
    {
        public interface IProduct
        {
            List<Product> GetProduct();

            List<Product> GetProductsByPrice(double price);

            Product GetProductById(int productId);

            void AddProduct(Product product);

            void UpdateProduct(Product product);

            void DeleteProduct(int productId);
        }
    }
}
