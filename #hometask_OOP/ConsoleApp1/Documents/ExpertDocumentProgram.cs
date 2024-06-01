using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documents
{
    internal class ExpertDocumentProgram : ProDocumentProgram
    {
        public override void SaveDocument(string format)
        {
            if (format == "doc")
            {
                Console.WriteLine("document saved in doc format");
            }
            else if (format == "pdf")
            {
                Console.WriteLine("document saved in pdf format");
            }
            else
            {
                Console.WriteLine("format invalid.");
            }
        }
    }
}
