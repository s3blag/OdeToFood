using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Models;
using OdeToFood.Services;
using System.Collections.Generic;

//Razor Page variant made in order to practice Razor Pages
namespace OdeToFood.Pages
{ 
    public class IndexModel : PageModel
    {
        private IRestaurantData _context;

        public IEnumerable<Restaurant> Restaurants { get; set; }

        public IndexModel(IRestaurantData context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Restaurants = _context.GetAll();
        }
    }
}