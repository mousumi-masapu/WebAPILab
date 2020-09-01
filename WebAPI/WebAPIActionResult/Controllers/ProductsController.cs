using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPIActionResult.Models;

namespace WebAPIActionResult.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static List<Product> products = new List<Product>()
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

        public ActionResult<Product> Get(int id)
        {
            var product = products.Find(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }



        [HttpPost]
        public ActionResult Post([FromBody] Product product)
        {
            if (products.Exists(p => p.Id == product.Id))
            {
                return Conflict();
            }
            products.Add(product);
            return CreatedAtAction(nameof(Get), new { id = product.Id }, products);
        }


        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Product>> Delete(int id)
        {
            var product = products.Where(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            products = products.Except(product).ToList();
            return products;
        }
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<Product>> Put(int id, [FromBody] Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }
            var exsistingProduct = products.Where(p => p.Id == id);
            products = products.Except(exsistingProduct).ToList();
            products.Add(product);
            return products;
        }

    }
}
