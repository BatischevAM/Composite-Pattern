using Composite_Pattern;
using System.Reflection.Metadata;
using Document = Composite_Pattern.Document;

class Program
{
    static void Main(String[] args)
    {
        Document doc = new Document();
        Section section1 = new Section("первый абзац");
        section1.Add(new Paragraph("параграф абзаца."));
        doc.Add(section1);

        Section section2 = new Section("второй абзац");
        section2.Add(new Paragraph("первый параграф абзаца."));
        section2.Add(new Paragraph("второй параграф абзаца."));
        doc.Add(section2);

        Section subsection1 = new Section("подабзац 1.1");
        subsection1.Add(new Paragraph("параграф подабзаца 1.1."));
        section2.Add(subsection1);

        doc.Display(0);
    }
}