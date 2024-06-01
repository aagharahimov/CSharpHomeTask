using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documents
{
    internal class DocumentsProgram
    {
        public void OpenDocument() 
        {
            Console.WriteLine("Document Opened.");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("Can edit in pro and expert verions");
        }

        public virtual void SaveDocument(string format)
        {
            Console.WriteLine("can save in pro and expert vrsions");
        }

    }


}
