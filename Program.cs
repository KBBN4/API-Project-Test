
// See https://aka.ms/new-console-template for more information
using API_Project_Exercise;
using Newtonsoft.Json.Linq;

public class Program
{
     static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // character beginnigns

        //var character = 0;
        //for (int i = 0; i < 100; i++)
        //{
        //    CharactersClass.Name();
        //    character++;
        //} 

        
        
        List<string> characterNames = new List<string>();
        IEnumerable<string> names = characterNames.Where(name => name.Contains("name"));
        CharactersClass.Name();


        for (int i = 0; i < characterNames.Count(); i++)
        {
            CharactersClass.Name();
            i++;
        }
        
      
        //CharacterClass names = new CharacterClass();
    }
}