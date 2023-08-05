using System;
using DynamicFilter.Core.Model;


namespace WebApp.Domain
{
    public class PaginationFilter
    {
        public required IEnumerable<Filter> Filters { get; set; }
        public int Take { get; set; }
        public int Skip { get; set; }
    }
}
