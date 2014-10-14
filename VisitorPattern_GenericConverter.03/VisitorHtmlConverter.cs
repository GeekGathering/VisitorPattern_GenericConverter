using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorsPattern_GenericConverter
{
    public class VisitorHtmlConverter : IVisitor
    {
        string outputString = string.Empty;

        public string Result
        {
            get { return outputString; }
            set { outputString = value; }
        }
  
        internal string Convert(Book book)
        {
            outputString = string.Empty;
            foreach (var item in book.BookElements)
            {
                item.Accept(this);
            }
            return outputString;
        }

        public void Visit(Title item)
        {
            outputString += "<H1>" + item.Text + "</H1>";
        }

        public void Visit(BoldText item)
        {
            outputString += "<B>" + item.Text + "</B>";
        }

        public void Visit(PlainText item)
        {
            outputString += item.Text;
        }

    }
}
