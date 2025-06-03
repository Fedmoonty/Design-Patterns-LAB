namespace APIMain;

public class EntityQueryCriteria
{
    public string Filter { get; set; }
    public string SortBy { get; set; }
    public bool Descending { get; set; }
    public int? Page { get; set; }
    public int? PageSize { get; set; }
}

