using Ecom.DataBase;
using Ecom.Entity;
using static Ecom.Services.IproductSevice;

namespace Ecom.Services
{
    public class ProductService : IProduct
    {
        private readonly EcommContext _Context;
        public ProductService()
        {
            _Context = new EcommContext();
        }
        public void AddProduct(Product product)
        {
            _Context.Products.Add(product);
            _Context.SaveChanges();
        }


        public List<Product> GetProduct()
        {
            return _Context.Products.ToList();
        }
        public List<Product> GetProductsByPrice(double price)
        {
            try
            {
                List<Product> products =
                        _Context.Products.Where(item => item.price > price).ToList();
                return products;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public Product GetProductById(int productId)
        {
            Product product = _Context.Products.Find(productId);
            return product;
        }

        public void UpdateProduct(Product product)
        {
            try
            {
                _Context.Products.Update(product);
                _Context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void DeleteProduct(int productId)
        {
            try
            {
                Product product = _Context.Products.SingleOrDefault(x => x.ProductId == productId);
                _Context.Products.Remove(product);
                _Context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
