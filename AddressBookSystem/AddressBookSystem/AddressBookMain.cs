using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBookMain
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
            CreateContact contactDetails = new CreateContact(firstName, lastName, address, city, state, zipCode, phoneNumber, email);
            this.contactList.AddLast(contactDetails);
        }

        /// <summary>
        /// display the contact details.
        /// </summary>
        public void DisplayContact()
        {
            foreach (CreateContact data in this.contactList)
            {
                data.Display();
            }
        }
        /// <summary>
        /// update the contact details.
        /// </summary>
        /// <param name="name"></param>
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
            //// checks for every object whether the name is equal the given name
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
        /// delete a contact from address book.
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
    }

}

