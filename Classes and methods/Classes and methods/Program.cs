using System;

namespace Home_task_4
{
    internal class Program
    {
        public static string name { get; private set; }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Melumatlari daxil edin:");
                userInformation userInformation = new userInformation();



            }

        }


    }

    public class userInformation
    {
        public string _name;
        public string _surname;
        public string _fatherName;
        public string _age;
        public string _idCardFin;
        public string _phoneNumber;
        public string _position;
        public string _salary;

        public userInformation()
        {


            _name = GetValidNameValue("Name", GetCommand("Name"));
            _surname = GetValidNameValue("Surname", GetCommand("Surname"));
            _fatherName = GetValidNameValue("Father name", GetCommand("Father name"));
            _age = GetValidAgeValue("Age", GetCommand("Age"));
            _idCardFin = GetValidNameValue("Id card", GetCommand("Id card"));
            _phoneNumber = GetValidNameValue("Phone number", GetCommand("Phone number"));
            _position = GetValidNameValue("Position", GetCommand("Position"));
            _salary = GetValidNameValue("Salary", GetCommand("Salary"));
        }

        string GetCommand(string text)
        {
            Console.Write($"{text}: ");
            return Console.ReadLine();
        }

        string GetValidNameValue(string propertyName, string value)
        {
            while (!FirstLetter(value) || !LengthDetector(value) || !NumberDetector(value))
            {
                value = GetCommand(propertyName);
            }

            return value;
        }

        string GetValidAgeValue(string propertyAge, string value)
        {
            while (!AgeDetector(value))
            {
                value = GetCommand(propertyAge);
            }

            return value;
        }

        bool FirstLetter(string targetName)
        {
            char[] lowerLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                                       'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int i = 0; i < lowerLetters.Length; i++)
            {
                if (targetName[0] == lowerLetters[i])
                {
                    Console.WriteLine("Entered format incorrect firstletter");
                    return false;
                }
            }
            return true;
        }
        bool LengthDetector(string targetName)
        {
            if (targetName.Length < 2 || targetName.Length > 20)
            {
                Console.WriteLine("Entered format incorrect length");
                return false;
            }
            return true;
        }
        bool NumberDetector(string value)
        {
            char[] allLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w',
                                          'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I',
                                         'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            for (int i = 0; i < value.Length; i++)
            {
                bool isValidLetter = false;

                for (int j = 0; j < allLetters.Length; j++)
                {
                    if (value[i] == allLetters[j])
                    {
                        isValidLetter = true;
                        break;
                    }
                }

                if (!isValidLetter)
                {
                    Console.WriteLine("Entered format incorrect number");
                    return false;
                }
            }

            return true;
        }
        bool AgeDetector(string targetAge)
        {
            string[] ageLength = {"18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","33","34","35","36","37","38","39","40","41","42","43","44","45","46","47","48",
            "49","50","51","52","53","54","55","56","57","58","59","60","61","62","63","64","65"};
            for (int i = 0; i < ageLength.Length; i++)
            {

                if (targetAge == ageLength[i])
                {
                    return true;
                }

            }

            Console.WriteLine("Entered age false");
            return false;
        }
    }
}