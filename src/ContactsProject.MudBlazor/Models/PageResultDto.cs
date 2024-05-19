﻿namespace ContactsWebClientMudBlazor.Models
{
    public class PagedResultDto<T>
    {
        public long TotalCount { get; set; }
        public IReadOnlyList<T>? Items { get; set; }
    }
}
