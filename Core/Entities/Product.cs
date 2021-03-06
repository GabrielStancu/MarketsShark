using System;

namespace Core.Entities
{
    //the extended (full) format of a product from our database 
    public class Product : BaseEntity, IEquatable<Product>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }      
        public string PictureUrl { get; set; }      
        public ProductType ProductType { get; set; }    
        public int ProductTypeId { get; set; }  
        public ProductBrand ProductBrand { get; set; }  
        public int ProductBrandId { get; set; }
        public string ProductUrl { get; set; }

        public bool Equals(Product other)
        {
            if (other.ProductUrl.ToUpper().Equals(ProductUrl))
            {
                return true;
            }

            return false;
        }
    }
}