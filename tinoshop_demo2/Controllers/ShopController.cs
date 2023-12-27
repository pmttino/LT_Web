using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tinoshop_demo2.Data;
using tinoshop_demo2.Models;

namespace tinoshop_demo2.Controllers
{
    public class ShopController : Controller
    {
		private readonly tinoshop_demo2Context _context;

		public ShopController(tinoshop_demo2Context context)
		{
			_context = context;
		}

		public async Task<IActionResult> Index()
        {
			var tinoshop = _context.Product.Include(s => s.Category);
			return View(await tinoshop.ToListAsync());
		}

   //     public async Task<IActionResult> Index(int? pageNumber = 1)
   //     {
			//var sanphams = from s in _context.Product select s;
			//int pageSize =6;
			//pageNumber = pageNumber< 1 ? 1 : pageNumber;
			//sanphams = _context.Product.Include(s => s.Category);
   //         return View(await PageList<Product>.CreateAsync(sanphams.AsNoTracking(), pageNumber ?? 1, pageSize));
   //     }

        public async Task<IActionResult> TheLoai(int? ID)
        {
            var tinoshop = _context.Product.Include(s => s.Category);
            return View("TheLoai", await tinoshop.Where(s => s.CategoryID == ID).ToListAsync());
        }

		[HttpPost]
		public async Task<IActionResult> TimKiem(String timKiem)
		{
			var tinoshop = _context.Product.Include(s => s.ProductName);
			return View("TheLoai", await _context.Product.Where(s => s.ProductName!.Contains(timKiem)).ToListAsync());
		}
	}
}
