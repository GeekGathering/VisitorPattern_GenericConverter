using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorsPattern_GenericConverter
{
    public class HtmlConverter
    {
        internal string Convert(Book book)
        {
            var convertedString = string.Empty;

            foreach (IBookElement element in book.BookElements)
            {
                if (element is Title)
                {
                    convertedString += "<H1>" + element.Text + "</H1>";
                }
                if (element is BoldText)
                {
                    convertedString += "<B>" + element.Text + "</B>";
                }
                if (element is PlainText)
                {
                    convertedString += element.Text;
                }
            }
            return convertedString;
        }
    }
}
