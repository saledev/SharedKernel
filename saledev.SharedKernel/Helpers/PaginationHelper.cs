namespace saledev.SharedKernel.Helpers;

public static class PaginationHelper
{
    public static int DefaultPage => 1;
    public static int DefaultPageSize => 10;

    public static int CalculateTake(int pageSize)
    {
        return pageSize <= 0 ? DefaultPageSize : pageSize;
    }
    public static int CalculateSkip(int pageSize, int page)
    {
        page = page <= 0 ? DefaultPage : page;

        return CalculateTake(pageSize) * (page - 1);
    }

    public static int CalculateTake(BaseFilter baseFilter)
    {
        return CalculateTake(baseFilter.PageSize);
    }
    public static int CalculateSkip(BaseFilter baseFilter)
    {
        return CalculateSkip(baseFilter.PageSize, baseFilter.Page);
    }

    public static int CalculateTotalPages(BaseFilter baseFilter)
    {
        return CalculateSkip(baseFilter.PageSize, baseFilter.Page);
    }

    public static T ProvideDefaultValues<T>(T filter) where T : BaseFilter
    {
        filter.IsPagingEnabled = true;
        if (filter.PageSize == 0)
        {
            filter.PageSize = DefaultPageSize;
        }

        if (filter.Page == 0)
        {
            filter.Page = DefaultPage;
        }

        return filter;
    }
}
