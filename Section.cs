using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    public class Section : IDocumentComponent
    {
        private string _title;
        private List<IDocumentComponent> components = new List<IDocumentComponent>();


        public Section(string title)
        {
            _title = title;
        }
        public void Add(IDocumentComponent component)
        {
            components.Add(component);
        }
        public void Remove(IDocumentComponent component)
        {
            components.Remove(component);
        }
        public void Display(int hierarchy)
        {
            Console.WriteLine(new string(' ', hierarchy) + _title);
            foreach (IDocumentComponent component in components)
            {
                component.Display(hierarchy+2);  
            }
        }
    }
}
