using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample
{
    public class Word : IDocument
    {
        public string GetDocType()
        {
            return "Word";
        }
        //Size of doc is in kb
        public int GetDocSize()
        {
            return 250;
        }


    }
}
