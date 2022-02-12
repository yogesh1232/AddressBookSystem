using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBookMain
    {
        // constants
        const int LAST_NAME = 1, ADDRESS = 2, CITY = 3, STATE = 4, ZIP = 5, PHONE_NUMBER = 6, EMAIL = 7;

        private LinkedList<CreateContact> contactList;
        public AddressBookMain()
        {
            this.contactList = new LinkedList<CreateContact>();
        }
        //this method add details to the address book
        public void AddContactDetails(string firstName, string lastName, string address, string city, string state, long zipCode, long phoneNumber, string email)
        {
            // finding the data that already has the same first name
            Contact contact = this.contactList.Find(x => x.firstName.Equals(firstName));
            // if same name is not present then add into address book
            if (contact == null)
            {
                Contact contactDetails = new Contact(firstName, lastName, address, city, state, zipCode, phoneNumber, email);
                this.contactList.Add(contactDetails);
            }
            // print person already exists in the address book
            else
            {
                Console.WriteLine("Person, {0} is already exist in the address book", firstName);
            }
        }

        // display the contact details.
        public void DisplayContact()
        {
            foreach (CreateContact data in this.contactList)
            {
                data.Display();
            }
        }

        // update the contact details.
        public void EditContact(string name)
        {
            Console.WriteLine("Enter your choice:");
            Console.WriteLine("1. Last Name");
            Console.WriteLine("2. Address");
            Console.WriteLine("3. City");
            Console.WriteLine("4. State");
            Console.WriteLine("5. Zip");
            Console.WriteLine("6. Phone Number");
            Console.WriteLine("7. Email");
            int choice = Convert.ToInt32(Console.ReadLine());
            // checks for every object whether the name is equal the given name
            foreach (CreateContact data in this.contactList)
            {
                if (data.firstName.Equals(name))
                {
                    switch (choice)
                    {
                        case LAST_NAME:
                            data.lastName = Console.ReadLine();
                            Console.WriteLine("Data updated successfully");
                            break;
                        case ADDRESS:
                            data.address = Console.ReadLine();
                            Console.WriteLine("Data updated successfully");
                            break;
                        case CITY:
                            data.city = Console.ReadLine();
                            Console.WriteLine("Data updated successfully");
                            break;
                        case STATE:
                            data.state = Console.ReadLine();
                            Console.WriteLine("Data updated successfully");
                            break;
                        case ZIP:
                            data.zipCode = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("Data updated successfully");
                            break;
                        case PHONE_NUMBER:
                            data.phoneNumber = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("Data updated successfully");
                            break;
                        case EMAIL:
                            data.email = Console.ReadLine();
                            Console.WriteLine("Data updated successfully");
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        
        // delete a contact from address book.
        public void DeleteContact(string name)
        {
            foreach (CreateContact contact in this.contactList)
            {
                if (contact.firstName.Equals(name))
                {
                    this.contactList.Remove(contact);
                    Console.WriteLine("Contact Deleted Successfully");
                    break;
                }
            }
        }

        // display list of person across adress book system
        public static void DisplayPerson(Dictionary<string, AddressBookMain> addressDictionary)
        {
            List<Contact> list = null;
            string name;
            Console.WriteLine("Enter City or State name");
            name = Console.ReadLine();
            foreach (var data in addressDictionary)
            {
                AddressBookMain address = data.Value;
                list = address.contactList.FindAll(x => x.city.Equals(name) || x.state.Equals(name));
                if (list.Count > 0)
                {
                    DisplayList(list);
                }
            }
            if (list == null)
            {
                Console.WriteLine("No person present in the address book with same city or state name");
            }
        }

        // display the data 
        public static void DisplayList(List<Contact> list)
        {
            foreach (var data in list)
            {
                data.Display();
            }
        }
    }

}

