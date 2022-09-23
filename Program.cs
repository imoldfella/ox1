using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml;



internal class Program
{
    private static void Main(string[] args)
    {
        WordprocessingDocument wordDoc = WordprocessingDocument.Open("./test.docx", false);
        DocumentFormat.OpenXml.Wordprocessing.Body body
    = wordDoc.MainDocumentPart.Document.Body;
        var totaltext = body.InnerText;
        Console.WriteLine(totaltext);
    }
}