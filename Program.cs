namespace A_Password_Generator_but_in_CSharp
{
    internal class Program
    {
        public static void ReceiveInputs()
        {
            Console.Write("Enter the length of the password: ");
            int length = int.Parse(Console.ReadLine());

            Console.Write("Include Uppercase letters (Y/N)? ");
            bool includeUppercase = Console.ReadLine().ToUpper() == "Y";

            Console.Write("Include Lowercase letters (Y/N)? ");
            bool includeLowercase = Console.ReadLine().ToUpper() == "Y";

            Console.Write("Include Numbers (Y/N)? ");
            bool includeNumbers = Console.ReadLine().ToUpper() == "Y";

            Console.Write("Include Special characters (Y/N)? ");
            bool includeSpecialChars = Console.ReadLine().ToUpper() == "Y";

            string password = GeneratePassword(length, includeUppercase, includeLowercase, includeNumbers, includeSpecialChars);

            Console.WriteLine("Generated Password: " + password);
        }

        public static string GeneratePassword(int length, bool includeUppercase, bool includeLowercase, bool includeNumbers, bool includeSpecialChars)
        {
            string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercaseChars = "abcdefghijklmnopqrstuvwxyz";
            string numberChars = "0123456789";
            string specialChars = "!@#$%^&*()-_=+[]{}|;:',.<>?";

            string validChars = "";
            if (includeUppercase) validChars += uppercaseChars;
            if (includeLowercase) validChars += lowercaseChars;
            if (includeNumbers) validChars += numberChars;
            if (includeSpecialChars) validChars += specialChars;

            Random random = new Random();
            string password = new string(Enumerable.Repeat(validChars, length).Select(s => s[random.Next(s.Length)]).ToArray());

            return password;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Password Generator!");
            ReceiveInputs();
        }
    }
}
