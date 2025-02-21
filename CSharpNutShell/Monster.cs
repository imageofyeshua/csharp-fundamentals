partial class Monster : Android
{
    public Monster(string name) : base(name, "Monster") {}

    public override void Introduce()
    {
        base.Introduce();
        WriteLine($"I'm {Name}, the doomed monster!");
    }
}
