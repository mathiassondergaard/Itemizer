namespace Itemizer.Domain.Common
{
    public class PaginationOptions
    {
        public int RowsToSkip { get; set; } = 0;
        public int RowsToGet { get; set; } = 15;
    }
}