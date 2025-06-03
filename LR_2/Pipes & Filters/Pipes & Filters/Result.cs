namespace LR2_0;

class Result
{
    public string GetResult()
    {
        var pipeline = new Pipeline<string>()
            .AddFilter(new UpperCaseFilter())
            .AddFilter(new ReverseFilter())
            .AddFilter(new PrefixFilter("Prefix"));

        string input = "Some text";
        string result = pipeline.Execute(input);

        return result;
    }
}
