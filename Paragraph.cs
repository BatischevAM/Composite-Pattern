using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    public class Paragraph : IDocumentComponent
    {
        private string _text;

        public Paragraph(string text)
        {
            _text = text;
        }
        public void Add(IDocumentComponent component)
        {
            throw new NotImplementedException("нельзя добавить параграф.");
        }
        public void Remove(IDocumentComponent component)
        {
            throw new NotImplementedException("нельзя добавить параграф.");
        }
        public void Display(int hierarchy)
        {
            Console.WriteLine(new string(' ', hierarchy)+ _text);
        }

    }
}
