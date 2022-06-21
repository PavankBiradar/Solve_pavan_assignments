using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample
{
     public class Program
    {
        static void Main(string[] args)
        {
            IDocument docDetails = DocFactory.GetDoc("Pdf");

            if (docDetails != null)
            {
                Console.WriteLine("docType : " + docDetails.GetDocType());
                Console.WriteLine("docSize : " + docDetails.GetDocSize());
                
            }
            else
            {
                Console.Write("Invalid Document Type");
            }
            Console.ReadLine();
        }
    }
}
