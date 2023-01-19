using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using Databases;
using Models;

namespace Business
{
    public class ProductBusiness
    {
        ProductRepository repository;

        public ProductBusiness()
        {
            repository= new ProductRepository();
        }

        public void AddProduct(Product product)
        {
            if (product.Name == null || product.Name == " ")
            {
                throw new Exception("Product Name is Required");
            }
            if (product.Price <=0)
            {
                throw new Exception("Product price must be greaten than zero");
            }
            repository.AddProduct(product);
        }

        public void UpdateProduct(Product product) 
        {
            if (product.Name == null || product.Name == " ")
            {
                throw new Exception("Product Name is Required");
            }
            if (product.Price <= 0)
            {
                throw new Exception("Product price must be greater than zero");
            }
            repository.UpdateProduct(product);


        }
        public void DeleteProduct(Product product)
        {
            if (product.Name == null || product.Name == " ") 
            {
                throw new Exception("Product Name is Required");
            }
            repository.DeleteProduct(product);
        }
        public List<Product> GetAllProducts()
        {
            return repository.GetAllProducts();
        }

        public void SaveToTextFile(List<Product> list, string filePath)
        {
            repository.SaveToTextFile(list, filePath);
        }

    }
}
