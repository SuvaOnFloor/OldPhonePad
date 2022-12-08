using OldPhonePadLibrary;

namespace OldPhonePad;

public class OldPhonePad
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter old phone string:");
            var input = Console.ReadLine();
            Console.WriteLine("Message:");
            var message = SendMessageLibrary.OldPhonePad(input);
            Console.WriteLine(message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message.ToString());
        }
    }
}
