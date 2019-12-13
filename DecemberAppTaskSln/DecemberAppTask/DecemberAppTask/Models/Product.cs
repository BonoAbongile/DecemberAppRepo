using System;
using System.Collections.Generic;
using System.Text;

namespace DecemberAppTask.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rating { get; set; }
        public string MakerOfProduct { get; set; }
        public string ImgURL { get; set; }
        public string Ingredient { get; set; }
        public string IngredientConcern { get; set; }
        public string IgredientRating { get; set; }
    }
}
