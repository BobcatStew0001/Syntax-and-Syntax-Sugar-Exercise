namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = 4; //Inferred Typing: The variables are defined as an integer and string

            var response = answer < 9 ? "less than nine" : "greater than nine"; //ternary operator 
            Console.WriteLine($" The answer is {response}"); //string interpolation 

            answer = 10; //Changed the value of variable "answer" for testing 
            response = answer < 9 ? "less than nine" : "greater than nine"; //Used the same ternary operator statement
            Console.WriteLine($" The answer is {response}");//Same string interpolation 
            
            //Output is correct for both test. 
            
            

        }
    }
}
