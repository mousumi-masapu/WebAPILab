using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPIScratch.Controllers;
using WebAPIScratch.Models;

namespace WebAPIScratch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        List<Product> products = new List<Product>()
        {
        new Product{
            Id=1006368,
            Name="Austin and BBQ AABQ Wifi Food Thermometer",
            Description="Thermometer and med wifi for en optimal innertemparatiure",
            Price=399


            },
     new Product{
            Id=1009334,
            Name="Anderson Elektrisk Tandare ECL 1.1",
            Description="Elektrisk stormsaker tander helt utan gas ovh bransel",
            Price=89


            },
     new Product
     {
     Id = 1002266,
     Name = "Webber Non Stick Spray",
     Description = "BBQ olijespray som motverkar att ravaror pa gallet",
     Price = 399


     }
 
    };

[HttpGet]

public IEnumerable<Product> Get()
{
    return products;


}

        [HttpGet("{id}")]

        public Product Get(int id)
        {
            var product = products.Find(product => product.Id == id);
            return product;


        }


    }
}
