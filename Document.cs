using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    public class Document : IDocumentComponent
    {
        private List<IDocumentComponent> sections = new List<IDocumentComponent>();

        public void Add(IDocumentComponent component)
        {
            sections.Add(component);
        }
        public void Remove(IDocumentComponent component)
        {
            sections.Remove(component);
        }
        public void Display(int hierarchy)
        {
            Console.WriteLine("Документ:");
            foreach (IDocumentComponent section in sections)
            {
                section.Display(hierarchy + 2);
            }
        }
    }
}

