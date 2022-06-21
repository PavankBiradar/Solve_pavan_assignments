using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample
{
    public interface IDocument
    {
        string GetDocType();
        int GetDocSize();
        
    }

}
