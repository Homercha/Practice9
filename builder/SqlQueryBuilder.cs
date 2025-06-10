public class SqlQueryBuilder
{
    private string select = "*";
    private string table;
    private string where;
    private string orderBy;
    public SqlQueryBuilder Select(string fields)
    {
        select = fields;
        return this;
    }
    public SqlQueryBuilder From(string tableName)
    {
        table = tableName;
        return this;
    }
    public SqlQueryBuilder Where(string condition)
    {
        where = condition;
        return this;
    }
    public SqlQueryBuilder OrderBy(string field)
    {
        orderBy = field;
        return this;
    }
    public string Build()
    {
        var query = $"SELECT {select} FROM {table}";
        if (!string.IsNullOrEmpty(where))
            query += $" WHERE {where}";
        if (!string.IsNullOrEmpty(orderBy))
            query += $" ORDER BY {orderBy}";
        return query + ";";
    }
}
