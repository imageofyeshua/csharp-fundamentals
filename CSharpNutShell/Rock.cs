class Rock
{
    private string _name;
    private int _weight;

    public Rock(string name, int weight)
    {
        _weight = weight;
        _name = name;
    }

    public override string? ToString()
    {
        return $"Name: {_name}, Weight: {_weight}";
    }
}
