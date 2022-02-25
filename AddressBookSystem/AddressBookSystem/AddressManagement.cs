﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class AddressManagement
    {
        static AddressBookMain addressBookMain = new AddressBookMain();
        static Dictionary<string, AddressBookMain> addressDictionary = new Dictionary<string, AddressBookMain>();
        static Dictionary<string, List<CreateContact>> cityDictionary = new Dictionary<string, List<CreateContact>>();
        static Dictionary<string, List<CreateContact>> stateDictionary = new Dictionary<string, List<CreateContact>>();
        /// <summary>
        /// display the menu to user
        /// </summary>
        public static void ReadInput()
        {
            // variables
            bool CONTINUE = true;
            //// the loop continues until the user exit.
            while (CONTINUE)
            {
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("1.Add Address Book");
                Console.WriteLine("2.Add Contacts");
                Console.WriteLine("3.Display");
                Console.WriteLine("4.Edit Details");
                Console.WriteLine("5.Delete Contact");
                Console.WriteLine("6.Delete the address book");
                Console.WriteLine("7.Display person by city or state name");
                Console.WriteLine("8.View person by city or state");
                Console.WriteLine("9.Count person by city or state");
                Console.WriteLine("10.Sort the Address book");
                Console.WriteLine("0.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter address book name:");
                        string addBookName = Console.ReadLine();
                        AddressBookMain addressBook1 = new AddressBookMain();
                        addressDictionary.Add(addBookName, addressBook1);
                        break;
                    case 2:
                        AddDetails(AddressManagement.BookName(addressDictionary), cityDictionary, stateDictionary);
                        break;
                    case 3:
                        addressBookMain = AddressManagement.BookName(addressDictionary);
                        addressBookMain.DisplayContact();
                        break;
                    case 4:
                        addressBookMain = AddressManagement.BookName(addressDictionary);
                        Console.WriteLine("Enter the first name of person");
                        string name = Console.ReadLine();
                        addressBookMain.EditContact(name);
                        break;
                    case 5:
                        addressBookMain = AddressManagement.BookName(addressDictionary);
                        string firstName = Console.ReadLine();
                        addressBookMain.DeleteContact(firstName);
                        break;
                    case 6:
                        Console.WriteLine("Enter address book name to delete");
                        string addressBook = Console.ReadLine();
                        addressDictionary.Remove(addressBook);
                        break;
                    case 7:
                        AddressBookMain.DisplayPerson(addressDictionary);
                        break;
                    case 8:
                        AddressBookMain.PrintList(cityDictionary);
                        AddressBookMain.PrintList(stateDictionary);
                        break;
                    case 9:
                        Console.WriteLine("City");
                        AddressBookMain.CountPerson(cityDictionary);
                        Console.WriteLine("State");
                        AddressBookMain.CountPerson(stateDictionary);
                        break;
                    case 10:
                        Console.WriteLine("AddressBook after sorting");
                        foreach (var data in addressDictionary.OrderBy(x => x.Key))
                        {
                            Console.WriteLine("{0}", data.Key);
                        }
                        break;
                    case 0:
                        CONTINUE = false;
                        Console.WriteLine("Thank you for using Address Book System!");
                        break;
                    default:
                        break;
                }
            }
        }
        /// This method is used to add multiple contacts.
        public static void AddDetails(AddressBookMain addressBookMain, Dictionary<string, List<CreateContact>> cityDictionary, Dictionary<string, List<CreateContact>> stateDictionary)
        {
            Console.WriteLine("Enter first Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter City");
            string city = Console.ReadLine();
            Console.WriteLine("Enter State");
            string state = Console.ReadLine();
            Console.WriteLine("Enter Zipcode");
            long zipCode = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Phone Number");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            addressBookMain.AddContactDetails(firstName, lastName, address, city, state, zipCode, phoneNumber, email, cityDictionary, stateDictionary);
        }
        // method to find the address of particular address book.
        public static AddressBookMain BookName(Dictionary<string, AddressBookMain> addBook)
        {
            addressDictionary = addBook;
            Console.WriteLine("Enter address book name:");
            string name = Console.ReadLine();
            AddressBookMain address = addressDictionary[name];
            return address;
        }
    }
}

