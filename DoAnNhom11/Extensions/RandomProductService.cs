using DoAnNhom11.Models;

namespace DoAnNhom11.Extensions
{
    public class RandomProductService
    {
        private List<Product> _randomProducts;
        private DateTime _lastUpdate;

        public RandomProductService()
        {
            _randomProducts = new List<Product>();
            _lastUpdate = DateTime.MinValue;
        }

        public List<Product> GetRandomProducts()
        {
            return _randomProducts;
        }

        public void SetRandomProducts(List<Product> products)
        {
            _randomProducts = products;
            _lastUpdate = DateTime.Today;
        }

        public DateTime GetLastUpdate()
        {
            return _lastUpdate;
        }
    }

}
