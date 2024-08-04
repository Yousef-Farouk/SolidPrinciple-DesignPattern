using SolidPrinc.Decorator_Pattern;
﻿using SolidPrinc.Builder_DP;
using SolidPrinc.Adapter_Pattern;
using SolidPrinc.Builder_DP;

namespace SolidPrinc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IText text = new PlainText("Text");

            ////var bold = new BoldTextDecorator(text);
            // text = new BoldTextDecorator(text);
            // text = new ItalicTextDecorator(text);

            //Console.WriteLine(text.GetText());

            //var toyACreator = new ToyCreator(new ToyABuilder());
            //toyACreator.CreateToy();
            //toyACreator.GetToy();
            //var toyBCreator = new ToyCreator(new ToyBBuilder());
            //toyBCreator.CreateToy();
            //toyBCreator.GetToy();
            //var toyACreator = new ToyCreator(new ToyABuilder());
            //toyACreator.CreateToy();
            //toyACreator.GetToy();
            //var toyBCreator = new ToyCreator(new ToyBBuilder());
            //toyBCreator.CreateToy();
            //toyBCreator.GetToy();


            Adaptee adaptee = new Adaptee();
            ITarget adapter = new Adapter(adaptee);

            Console.WriteLine("Client: I can work just fine with the Adapter:");
            Console.WriteLine(adapter.Request());
        }
    }

}
