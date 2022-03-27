namespace saledev.SharedKernel;

public class BaseFilter
{
    public bool LoadChildren { get; set; }
    public bool IsPagingEnabled { get; set; }

    public int Page { get; set; }
    public int PageSize { get; set; }

    public string SearchFor { get; set; } = string.Empty;
}
