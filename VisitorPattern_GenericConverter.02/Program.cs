using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorsPattern_GenericConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.Add(new Title("Hansel and Gretel"));
            book.Add(new PlainText("Near a great forest there lived a poor woodcutter and his wife, and his two children."));
            book.Add(new BoldText("The boy's name was Hansel and the girl's Grethel"));
            book.Add(new PlainText("More text..."));
 
            var htmlConverter= new VisitorHtmlConverter();

            foreach (var item in book.BookElements)
            {
                item.Accept(htmlConverter);
            }

            Console.WriteLine(htmlConverter.Result);
            Console.ReadKey();
        }
    }

    //IVisitor
    public interface IConverter
    {
        void Convert(Title element);        //Visit
        void Convert(BoldText element);
        void Convert(PlainText element);
    }

    //IElement
    public interface IBookElement
    {
        string Text { get;}
        void Accept(IConverter converter);  //Accept
    }

    public class Book
    {
        List<IBookElement> _bookElements = new List<IBookElement>();

        public List<IBookElement> BookElements
        {
            get { return _bookElements; }
            set { _bookElements = value; }
        }

        internal void Add(IBookElement bookElement)
        {
            _bookElements.Add(bookElement);
        }
    }

    public class Title : IBookElement
    {
        public string Text { get; private set; }
        public Title(string text)
        {
            this.Text = text;
        }


        public void Accept(IConverter converter)
        {
            converter.Convert(this);
        }
    }

    public class BoldText : IBookElement
    { 
         public string Text { get; private set; }
        public BoldText(string text)
        {
            this.Text = text;
        }

        public void Accept(IConverter converter)
        {
            converter.Convert(this);
        }
    }

    public class PlainText : IBookElement
    { 
         public string Text { get; private set; }
         public PlainText(string text)
        {
            this.Text = text;
        }

         public void Accept(IConverter converter)
         {
             converter.Convert(this);
         }
    }

}
