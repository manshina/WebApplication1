using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class PizzaModel : PageModel
    {
        
        
        private readonly ApplicationDbContext _context;
        public PizzaModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<PizzasModel> pizzasModels;
        public void OnGet()
        {
            var pizzas = from m in _context.pizzas
                        select m;


            pizzasModels = pizzas.ToList();
        }

    }
}
