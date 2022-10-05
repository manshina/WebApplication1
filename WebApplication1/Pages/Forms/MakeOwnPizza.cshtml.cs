using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Pages.Forms
{
    [BindProperties(SupportsGet = true)]

    public class MakeOwnPizzaModel : PageModel
    {
        //public ApplicationDbContext _context;
        //public MakeOwnPizzaModel(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        
        public PizzasModel Pizza { get; set; }
        
        public float PizzaPrice { get; set; }
        
        public int Id { get; set; }

        
        public void OnGet()
        {
            //Pizza = _context.pizzas
            //    .FirstOrDefault(m => m.Id == Id);

            
        }
        public IActionResult OnPost()
        {

            PizzaPrice = Pizza.BasePrice;
            if (Pizza.Tomato) PizzaPrice += 1;
            if (Pizza.Salat) PizzaPrice += 1;
            if (Pizza.Cheese) PizzaPrice += 1;
            if (Pizza.Pepper) PizzaPrice += 1;
            if (Pizza.Mushroom) PizzaPrice += 1;
            


            return RedirectToPage("/Checkout/Checkout", new { Pizza.Name, PizzaPrice });
        }

    }
}
