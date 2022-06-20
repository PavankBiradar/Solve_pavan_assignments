namespace assignment{

    class Solution {
        static void Main(string[] args) {
            int[] collection = { 1, 2, 4, 5, 6, 7, 8, 9, 3, 0 };

             
                int operator1 = 100;
                
                
                    for (int i = 0; i < collection.Length; i++)
                    {

                    try
                    {
                        var temp = collection[i + 1];
                        Console.WriteLine(operator1 / temp);
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("You can't divide a no with zero");

                    }
                    catch (IndexOutOfRangeException) { 
                        Console.WriteLine("sorry!!size of array is 10");
                    }
                       

                    

                
                
               

            }

        }
        
    
    }



}
