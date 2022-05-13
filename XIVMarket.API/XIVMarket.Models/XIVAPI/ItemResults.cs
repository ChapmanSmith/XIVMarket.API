namespace XIVMarket.Models.XIVAPI
{
       
    public class ItemResults
    {
        public ItemPagination Pagination { get; set; }
        public List<Result> Results { get; set; }
        public int SpeedMs { get; set; }
    }
}