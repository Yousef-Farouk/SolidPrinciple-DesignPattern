using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinc.Decorator_Pattern
{
    internal interface IText
    {  
        public  string GetText();
    }


    internal class PlainText : IText
    {
        private string text;

        public PlainText(string _text)
        {
            text = _text;
        }

        public string GetText()
        {
            return text;
        }

    }

    internal abstract class TextDecorator : IText
    {
        protected IText component;

        public TextDecorator(IText _component)
        {
            component = _component;
        }
        public virtual string GetText()
        {
            return component.GetText();
        }
    }

    internal class BoldTextDecorator : TextDecorator
    {
        public BoldTextDecorator(IText component) :base(component)
        {
            
        }

        public override string GetText() 
        {
           return $"{component.GetText()} bold";
        }
    }


    internal class ItalicTextDecorator : TextDecorator
    {
        public ItalicTextDecorator(IText component) : base(component)
        {

        }

        public override string GetText()
        {
            return $"{component.GetText()} Italic";
        }
    }


}
