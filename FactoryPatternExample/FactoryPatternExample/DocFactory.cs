using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample
{
    public  class DocFactory
    {
        public static IDocument GetDoc(string docType)
        {
            IDocument docDetails = null;
            if (docType == "Pdf")
            {
                docDetails = new Pdf();
            }
            else if (docType == "Word")
            {
                docDetails = new Word();
            }
            
            return docDetails;
        }

    }
}
