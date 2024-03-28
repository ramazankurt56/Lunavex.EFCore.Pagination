using Microsoft.EntityFrameworkCore;

namespace Lunavex.EFCore.Pagination;
public static class PagesListQuerableExtensions
{
    public static async Task<PageResult<T>> ToPagedListAsync<T>(this IQueryable<T> source, int pageNumber, int pageSize, CancellationToken cancellationToken = default) where T : class
    {
        int count = await source.CountAsync(cancellationToken);
        if (count > 0)
        {
            return new PageResult<T>(await source.Skip((pageNumber - 1) * pageSize).Take(pageSize).AsNoTracking()
                .ToListAsync(cancellationToken), pageNumber, pageSize, count);
        }

        return new PageResult<T>(null, 0, 0, 0);
    }
}
