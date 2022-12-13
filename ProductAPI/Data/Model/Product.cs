using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ProductAPI.Data.Model
{
    /// <summary>
    /// Product Object 
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [Required(ErrorMessage = "Name is required.")]
        [MaxLength(50, ErrorMessage = "Name must be less than 50")]
        public string Name { get; set; }

        /// <summary>
        /// Desciption
        /// </summary>
        [Required(ErrorMessage = "Description is required.")]
        [MaxLength(150, ErrorMessage = "Description must be less than 150")]
        public string Desciption { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        [Required(ErrorMessage = "Price is required"), Precision(18, 2)]       
        public decimal Price { get; set; }
    }
}
