using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class DataManagement
    {
        /// <summary>
        /// Insert a person data
        /// </summary>
        /// <param name="list"></param>
        public void AddPersonData(List<PersonModel> list)
        {
            Console.WriteLine(".........Enter person detail.........");
            PersonModel personModel = new PersonModel();
            Console.WriteLine("Enter Serial Number of Person");
            personModel.SSN = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Name of Person");
            personModel.Name = Console.ReadLine();
            Console.WriteLine("Enter Address of Person");
            personModel.Address = Console.ReadLine();
            Console.WriteLine("Enter Age of Person");
            personModel.Age = Convert.ToInt16(Console.ReadLine());
            list.Add(personModel);
            Console.WriteLine("............Record Inserted............");
        }
        /// <summary>
        /// show top 2 record for age below 60
        /// </summary>
        /// <param name="list"></param>
        public void TopTwoRecordsBelowAge(List<PersonModel> list)
        {
            if (list.Count > 0)
            {
                var data = list.Where(x => x.Age < 60).Take(2);
                Console.WriteLine("..........Top 2 Record Age below 60.........");
                foreach(var persondata in data)
                {
                    Console.WriteLine("SSN :" + persondata.SSN);
                    Console.WriteLine("Name :" + persondata.Name);
                    Console.WriteLine("Address :" + persondata.Address);
                    Console.WriteLine("Age :" + persondata.Age);
                    Console.WriteLine("...........................");
                }
            }
            else
                Console.WriteLine(".............Record is empty.............");
        }
        /// <summary>
        /// show record for age between 13 to 18
        /// </summary>
        /// <param name="list"></param>
        public void RecordAgeBetween13To18(List<PersonModel> list)
        {
            if (list.Count > 0)
            {
                var data = list.Where(x => x.Age > 13 && x.Age < 18);
                Console.WriteLine("..........Record age between 13 to 18.........");
                foreach (var persondata in data)
                {
                    Console.WriteLine("SSN :" + persondata.SSN);
                    Console.WriteLine("Name :" + persondata.Name);
                    Console.WriteLine("Address :" + persondata.Address);
                    Console.WriteLine("Age :" + persondata.Age);
                    Console.WriteLine("...........................");
                }
            }
            else
                Console.WriteLine(".............Record is empty.............");
        }
        /// <summary>
        /// Show average age of list
        /// </summary>
        /// <param name="list"></param>
        public void RetrieveAverageAge(List<PersonModel> list)
        {
            if (list.Count > 0)
            {
                double totalAge=0;
                var data = list.Where(x => x.Age >= 0);
                foreach(var age in data)
                {
                    totalAge += age.Age;
                }
                Console.WriteLine("..........Average Age.........");
                Console.WriteLine("Average Age :"+totalAge / list.Count);
            }
            else
                Console.WriteLine(".............Record is empty.............");
        }
        /// <summary>
        /// Check specific name present in list or not 
        /// </summary>
        /// <param name="list"></param>
        public void CheckNamePresent(List<PersonModel> list)
        {
            if (list.Count > 0)
            {
                Console.WriteLine("...........Check Name Present or not ...........");
                Console.WriteLine("Enter a person Name");
                string namePerson = Console.ReadLine();
                var data = list.Where(x => x.Name.Equals(namePerson));
                if (data.ToList().Count > 0)
                    Console.WriteLine(namePerson + " : is present in list");
                else
                    Console.WriteLine(namePerson + " : is not present in list");
            }
            else
                Console.WriteLine(".............Record is empty.............");
        }
        /// <summary>
        /// Skip record from list whose age below 60 
        /// </summary>
        /// <param name="list"></param>
        public void SkipRecordBelow60(List<PersonModel> list)
        {
            if (list.Count > 0)
            {
                Console.WriteLine(".........Skip record age below 60...........");
                List<PersonModel> tempDeleteList = new List<PersonModel>();
                var data = list.Where(x => x.Age < 60);
                foreach (var age in data)
                {
                    tempDeleteList.Add(age);
                }
                foreach(PersonModel temp in tempDeleteList)
                {
                    list.Remove(temp);
                }
                Console.WriteLine(".........Record skip successfully from list.........");
            }
            else
                Console.WriteLine(".............Record is empty.............");
        }
        /// <summary>
        /// Show data of all person
        /// </summary>
        /// <param name="list"></param>
        public void ShowAllData(List<PersonModel> list)
        {
            if (list.Count > 0)
            {
                Console.WriteLine("........Person data as listed below.......");

                foreach (PersonModel personData in list)
                {
                    Console.WriteLine("..........Record..........");
                    Console.WriteLine("SSN is :" + personData.SSN);
                    Console.WriteLine("Name :" + personData.Name);
                    Console.WriteLine("Address :" + personData.Address);
                    Console.WriteLine("Age :" + personData.Age);
                }
            }
            else
            {
                Console.WriteLine("..........Record is empty............");
            }
        }
    }
}
