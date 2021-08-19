using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int userChoice;
            //Constants
            const int ADD_PERSON_DATA = 1, EXIT = 0,TOP_TWO_RECORDS=2,AGE_BETWEEN13TO18=3,AVERAGE_AGE=4, SHOW_ALL_DATA = 8;
            List<PersonModel> list = new List<PersonModel>();
            while (true)
            {
                Console.WriteLine("........................Main Menu........................");
                Console.WriteLine("Press 1 : Add new person data");
                Console.WriteLine("Press 2 : Retrive top 2 records from list age below 60");
                Console.WriteLine("Press 3 : All Record for age between 13 to 18");
                Console.WriteLine("Press 4 : Retrive Average age");
                Console.WriteLine("Press 8 : Show all person data");
                Console.WriteLine("Press 0 : To Exit");
                Console.WriteLine("................................................");
                Console.WriteLine("Enter your choice");
                userChoice = Convert.ToInt32(Console.ReadLine());
                if (userChoice == EXIT)
                    break;
                switch (userChoice)
                {
                    case ADD_PERSON_DATA:
                        DataManagement dataManagement = new DataManagement();
                        dataManagement.AddPersonData(list);
                        break;
                    case TOP_TWO_RECORDS:
                        DataManagement topRecord = new DataManagement();
                        topRecord.TopTwoRecordsBelowAge(list);
                        break;
                    case SHOW_ALL_DATA:
                        DataManagement showAllData = new DataManagement();
                        showAllData.ShowAllData(list);
                        break;
                    case AGE_BETWEEN13TO18:
                        DataManagement recordBetween = new DataManagement();
                        recordBetween.RecordAgeBetween13To18(list);
                        break;
                    case AVERAGE_AGE:
                        DataManagement averageAge = new DataManagement();
                        averageAge.RetrieveAverageAge(list);
                        break;
                    default:
                        Console.WriteLine("Enter a right choice");
                        break;
                }
            }
        }
    }
}