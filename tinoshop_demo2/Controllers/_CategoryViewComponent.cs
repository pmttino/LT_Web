using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tinoshop_demo2.Data;

namespace tinoshop_demo2.Controllers
{
	[ViewComponent(Name ="_Category")]

	public class _CategoryViewComponent : ViewComponent
	{
		private readonly tinoshop_demo2Context _context;

		public _CategoryViewComponent(tinoshop_demo2Context context)
		{
			_context = context;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View("_Category", await _context.Category.ToListAsync());
		}
	}
}
