
namespace FactoryPatternExample {

    public class Pdf:IDocument {
        public string GetDocType()
        {
            return "Pdf";
        }
        //Size of doc is in kb
        public int GetDocSize()
        {
            return 150;
        }


    }



}
