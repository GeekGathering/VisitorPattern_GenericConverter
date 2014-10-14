using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VisitorsPattern_GenericConverter
{
    public class ElementsCounter : IVisitor
    {
        public int TitleElementsCount { get; set; }
        public int BoldTextElementsCount { get; set; }
        public int PlainTextElementsCount { get; set; }

        public void Visit(Title element)
        {
            TitleElementsCount++;
        }

        public void Visit(BoldText element)
        {
            BoldTextElementsCount++;
        }

        public void Visit(PlainText element)
        {
            PlainTextElementsCount++;
        }
    }
}
