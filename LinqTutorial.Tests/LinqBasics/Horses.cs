using LinqTutorial.Implementation.Stables;

namespace LinqTutorial.Tests.LinqBasics
{
    public enum Luck
    {
        Lucky,
        UnLucky,
    }

    public static class Horses
    {
        public static Luck GetLuck(this Horse horse) => horse.IsLucky ? Luck.Lucky : Luck.UnLucky;
    }
}
