namespace commercetools.HistoryApi.Models.Common
{
    public partial class SearchKeyword : ISearchKeyword
    {
        public string Text { get; set; }

        public ISuggestTokenizer SuggestTokenizer { get; set; }
    }
}
