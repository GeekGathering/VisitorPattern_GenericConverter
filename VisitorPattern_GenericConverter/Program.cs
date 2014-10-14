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
 
            string outputConversion = string.Empty;
            //create your own implementation to convert

            Console.WriteLine(outputConversion);
            Console.ReadKey();
        }
    }


    public interface IBookElement
    {
        string Text { get;}
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
    }

    public class BoldText : IBookElement
    { 
         public string Text { get; private set; }
        public BoldText(string text)
        {
            this.Text = text;
        }
    }

    public class PlainText : IBookElement
    { 
         public string Text { get; private set; }
         public PlainText(string text)
        {
            this.Text = text;
        }
    }

}
