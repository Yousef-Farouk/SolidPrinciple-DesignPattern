namespace SolidPrinc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IText text = new PlainText("Text");

            //var bold = new BoldTextDecorator(text);
             text = new BoldTextDecorator(text);
             text = new ItalicTextDecorator(text);


        }
    }

}
