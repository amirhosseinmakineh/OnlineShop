namespace OnlineShop.Domain.Models
{
    public class Product : BaseEntity<int>
    {
        public string Name { get; set; }
        public string ImageName { get; set; }
        public float Price { get; set; }
        public int CategoryId { get; set; }
        #region Relations
        public Category Category { get; set; }
        #endregion
    }
}
