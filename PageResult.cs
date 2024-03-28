namespace Lunavex.EFCore.Pagination;
public class PageResult<T>
{
    public IList<T> Datas { get; set; }

    public int PageNumber { get; set; }

    public int PageSize { get; set; }

    public int TotalPages { get; set; }

    public bool IsFirstPage { get; set; }

    public bool IsLastPage { get; set; }

    public PageResult(IList<T> datas, int pageNumber, int pageSize, int totalCount)
    {
        Datas = datas;
        PageNumber = pageNumber;
        PageSize = pageSize;
        TotalPages = ((totalCount + pageSize > 0) ? ((int)Math.Ceiling((double)totalCount / (double)pageSize)) : 0);
        IsFirstPage = PageNumber == 1;
        IsLastPage = PageNumber == TotalPages;
    }
}
