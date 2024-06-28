using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrientalOasis.Model
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string ItemName { get; set; }
        public string Description { get; set; }
        [Required]
        public string ItemNumber { get; set; }
        [Required]
        public string Origin { get; set; }

        [Required]
        [Display(Name = "List Price")]
        [Range(1, 1000)]
        public double ListPrice { get; set; }

        [Required]
        [Display(Name = "Price for 1-50 items")]
        [Range(1, 1000)]
        public double Price { get; set; }

        [Required]
        [Display(Name = "Price for 50+ items")]
        [Range(1, 1000)]
        public double Price50 { get; set; }

        [Required]
        [Display(Name = "Price for 100+ items")]
        [Range(1, 1000)]
        public double Price100 { get; set; }

        // Foreign key for Category table
        public int Cat_Id { get; set; }

        // Navigation property
        [ForeignKey("Cat_Id")]
        [ValidateNever]
        public virtual Category Category { get; set; }
		//property for images
		[ValidateNever]
		public string ImageURL {  get; set; }
    }
}
