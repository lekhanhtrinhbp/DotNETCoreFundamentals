using DotNETCoreFundamentals.Models;
using System.ComponentModel.DataAnnotations;

namespace DotNETCoreFundamentals.ViewModels
{
    public class RestaurantEditViewModel
    {
        [Required, MaxLength(80)]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
