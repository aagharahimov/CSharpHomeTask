using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Documents
{
    internal class ProDocumentProgram : DocumentsProgram
    {
        public sealed override void EditDocument()
        {
            Console.WriteLine("document edited.");
        }

        public override void SaveDocument(string format)
        {
            if (format == "doc")
            {
                Console.WriteLine("document saved in doc format");
            }
            else if (format == "pdf")
            {
                Console.WriteLine("buy expert for pdf format");
            }
            else
            {
                Console.WriteLine("format invalid.");
            }
          
        }
    }
}
