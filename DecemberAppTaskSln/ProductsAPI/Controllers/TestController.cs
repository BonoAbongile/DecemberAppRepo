using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProductsAPI.Models;

namespace ProductsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        List<Product> Products = new List<Product>();
        public TestController()
        {
                Products.Add(new Product
                {

                    Name = "Aveda Dry Remedy Moisturizing Shampoo",
                    Id = 0,
                    Rating = "Rating : 10",
                    IgredientRating = "IgredientRating : 10",
                    MakerOfProduct = "by Aveda",
                    ImgURL = "avedacream.jpg",
                    Ingredient = "This product contains no ingredients with health concerns.",
                    IngredientConcern = "No Concern",
                }); ;

                Products.Add(new Product
                {

                    Name = "Head & Shoulders Smooth & Silky Shampoo, 13.5oz",
                    Id = 1,
                    Rating = "Rating : 8.5",
                    IgredientRating = "IgredientRating : 8.0",
                    MakerOfProduct = "by Head & Shoulders",
                    ImgURL = "headshoulders.jpg",
                    Ingredient = "Ingredient: Triethylene Glycol",
                    IngredientConcern = "Low Hazard Concern",

                });

                Products.Add(new Product
                {

                    Name = "Mario Badescu Temporary Lifting Mask, 1oz",
                    Id = 2,
                    Rating = "Rating : 7.8",
                    IgredientRating = "IgredientRating : 8.0",
                    MakerOfProduct = "by Mario Badescu",
                    ImgURL = "mariobadescu.jpg",
                    Ingredient = "Hops",
                    IngredientConcern = "Low Hazard Concern",

                });

                Products.Add(new Product
                {
                    Name = "Desert Essence 100% Pure Jojoba Oil",
                    Id = 3,
                    Rating = "Rating : 7.5",
                    IgredientRating = "IgredientRating : 8.0",
                    MakerOfProduct = "by Desert Essence",
                    ImgURL = "desertEssence.jpg",
                    Ingredient = "Citric Acid",
                    IngredientConcern = "Medium Hazard Concern",

                });

                var client = new HttpClient();

                List<Product> product = Products;

                var json = JsonConvert.SerializeObject(product);
                var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

                try
                {
                    var response = client.PostAsync("http://10.0.2.2:5000/api/Test", content);
                    // await DisplayAlert("Expection", response.Content, "OK");
                }
                catch
                {
                    //DisplayAlert("Expection", ex.Message, "Ok");
                }
            }

        // GET: api/Test
        [HttpGet]
        public List<Product> Get()
        {
            
            return Products;
        }


        // GET: api/Test/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Test
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Test/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
