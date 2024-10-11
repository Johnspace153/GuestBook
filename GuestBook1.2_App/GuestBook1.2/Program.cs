
using GuestBookLibrary;

internal class Program
{
    private static List<GuestModel> guestList = new List<GuestModel>();
    private static void Main(string[] args)
    {
        WelcomeMessage();
        GetGuestInfo();
        PrintGuesttInfo();
    }

    private static void GetGuestInfo()
    {
        string anwser;
        bool continueLoop = true;
        
        do
        {
            GuestModel guest = new GuestModel(RequestString("Please enter in your firstname: "),
                                         RequestString("Please enter in your lastname: "),
                                         RequestBirthday());

            guest.MessageToHost = RequestString("What is your message to the host: ");

            guestList.Add(guest);

            anwser = RequestString("Is there more guests coming(Yes/No): ");

            if (anwser.ToLower() == "no" )
            {
                Console.Clear();
                Console.WriteLine("Enjoy your evening!");
                Console.Write("\n");
                continueLoop = false;
            }
            else
            {
                Console.Clear();
            }
        } while (continueLoop == true);
        
    }

    private static void PrintGuesttInfo()
    {
        foreach (var guest in guestList)
        {
            Console.WriteLine($"{guest.FullName},{guest.Age} ,Message to Host: {guest.MessageToHost}");
        }
    }





    private static void WelcomeMessage()
    {
        Console.WriteLine("Thank you for attending this splendid event!!");
        Console.Write("\n");
    }
    private static string RequestString(string message)
    {
        Console.Write(message);
        string output = Console.ReadLine();
        Console.Write("\n");
        return output;
    }

    private static DateTime RequestBirthday()
    {
        bool isValidDate = false;
        string dateText;
        DateTime output;

        do
        {
            dateText = RequestString("Please enter in your birthday(yyyy-mm-dd): ");
            isValidDate = DateTime.TryParse(dateText, out output);
            Console.Write("\n");
            if (isValidDate == false)
            {
                Console.WriteLine("Please enter the correct format!!");
                Console.Write("\n");
            }

        } while (isValidDate == false);

        return output;
    }

    private int RequestInt(string message) 
    {
        bool isValidNum = false;
        int output;
        
        do
        {
            Console.Write(message);
            string NumText = Console.ReadLine();
            isValidNum = int.TryParse(NumText, out output);
            if (isValidNum == false)
            {
                Console.WriteLine("Please type in valid number");
            }

        } while (isValidNum == false);
        return output;
    }
}