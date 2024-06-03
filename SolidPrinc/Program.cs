using SolidPrinc.Builder_DP;

namespace SolidPrinc
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var toyACreator = new ToyCreator(new ToyABuilder());
            toyACreator.CreateToy();
            toyACreator.GetToy();
            var toyBCreator = new ToyCreator(new ToyBBuilder());
            toyBCreator.CreateToy();
            toyBCreator.GetToy();
        }
    }

}
