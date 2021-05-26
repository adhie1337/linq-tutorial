namespace LinqTutorial.Implementation.Stables
{
    public sealed record Horse(int Id)
    {
        public bool IsLucky => this.Id % 2 == 1;
    }
}
