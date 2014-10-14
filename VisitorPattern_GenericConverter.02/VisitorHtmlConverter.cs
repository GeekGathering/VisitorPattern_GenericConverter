using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorsPattern_GenericConverter
{
    public class VisitorHtmlConverter : IConverter
    {
        string outputString = string.Empty;

        public string Result
        {
            get { return outputString; }
            set { outputString = value; }
        }
            
        public void Convert(Title item)
        {
            outputString += "<H1>" + item.Text + "</H1>";
        }

        public void Convert(BoldText item)
        {
            outputString += "<B>" + item.Text + "</B>";
        }

        public void Convert(PlainText item)
        {
            outputString += item.Text;
        }

    }
}
