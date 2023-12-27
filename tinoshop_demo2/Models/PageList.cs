using Microsoft.EntityFrameworkCore;

namespace tinoshop_demo2.Models
{
    public class PageList<T> : List<T>
    {
        public int PageIndex { get; private set; }
        public int TotalPages { get; private set; }

        public PageList(List<T> items, int count, int pageIndex, int pageSize) 
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count/ (double)pageSize);
            this.AddRange(items);
        }

        public bool HasPreviousPage => PageIndex > 1;

        public bool HasNextPage => PageIndex < TotalPages;

        public static async Task<PageList<T>> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize)
        {
            var count = await source.CountAsync();
            var items = await source.Skip(pageIndex-1).Take(pageSize).ToListAsync();
            return new PageList<T>(items, count, pageIndex, pageSize);
        }
    }
}
