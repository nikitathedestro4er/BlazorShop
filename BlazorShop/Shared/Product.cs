using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BlazorShop.Shared
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required field")]
        [MinLength(3, ErrorMessage = "Title must be 3 or more characters")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Description is required field")]
        [MinLength(20, ErrorMessage = "Description must be 20 or more characters")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Image is required field")]
        public string Image { get; set; } = "https://via.placeholder.com/300x300";
        public bool IsPublic { get; set; }
        public bool IsDeleted { get; set; }
        [JsonIgnore]
        public Category Category { get; set; }
        [Required(ErrorMessage = "Category is must be selected")]
        public int CategoryId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Range(1, double.MaxValue, ErrorMessage = "Value for the Price can't be lower than 1")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [Range(1, double.MaxValue, ErrorMessage = "Value for the Original Price can't be lower than 1")]
        public decimal OriginalPrice { get; set; }
        public DateTime? DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateUpdated { get; set; }
        public int Views { get; set; }
    }
}