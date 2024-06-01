using Documents;

namespace Documents
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            inputKeyDesc: Console.WriteLine("keyi daxil edin: ");
            string key = Console.ReadLine();

            if (key == "basic" || key =="pro" || key == "expert" )
            {
                switch (key)
                {
                    case "basic":
                        DocumentsProgram documentProgram = new DocumentsProgram();
                        documentProgram.OpenDocument();
                        documentProgram.EditDocument();
                        documentProgram.SaveDocument("xlsx");

                        break;

                    case "pro":
                        ProDocumentProgram proDocument = new ProDocumentProgram();
                        proDocument.OpenDocument();
                        proDocument.EditDocument();
                        proDocument.SaveDocument("pdf");

                        break;

                    case "expert":
                        ExpertDocumentProgram experDocumenDocument = new ExpertDocumentProgram();
                        experDocumenDocument.OpenDocument();
                        experDocumenDocument.EditDocument();
                        experDocumenDocument.SaveDocument("doc");

                        break;
                    default:
                        goto inputKeyDesc;
                }
            }

            else
            {
                goto inputKeyDesc;
            }

        }
    }
}