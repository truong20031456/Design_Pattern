namespace Factory_pattern
{
    using System;

    public abstract class Document
    {
        public abstract void Create();
    }

    public class PDFDocument : Document
    {
        public override void Create()
        {
            Console.WriteLine("Created a PDF document.");
        }
    }

    public class WordDocument : Document
    {
        public override void Create()
        {
            Console.WriteLine("Created a Word document.");
        }
    }

    public interface IDocumentFactory
    {
        Document CreateDocument();
    }

    public class PDFDocumentFactory : IDocumentFactory
    {
        public Document CreateDocument()
        {
            return new PDFDocument();
        }
    }

    public class WordDocumentFactory : IDocumentFactory
    {
        public Document CreateDocument()
        {
            return new WordDocument();
        }
    }

    class Program
    {
        static void Main()
        {
            IDocumentFactory pdfFactory = new PDFDocumentFactory();
            IDocumentFactory wordFactory = new WordDocumentFactory();

            Document pdfDocument = pdfFactory.CreateDocument();
            Document wordDocument = wordFactory.CreateDocument();

            pdfDocument.Create();    // Output: Created a PDF document.
            wordDocument.Create();   // Output: Created a Word document.
        }
    }
}