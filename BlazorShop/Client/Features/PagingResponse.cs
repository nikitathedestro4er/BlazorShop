using System.Collections.Generic;
using BlazorShop.Shared.RequestFeatures;

namespace BlazorShop.Client.Features
{
    public class PagingResponse<T> where T : class
    {
        public List<T> Items { get; set; }
        public MetaData MetaData { get; set; }
    }
}