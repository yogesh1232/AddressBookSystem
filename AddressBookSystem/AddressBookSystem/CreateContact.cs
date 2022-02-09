﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class CreateContact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public double Zip { get; set; }
        public double PhoneNumber { get; set; }
        public string Email { get; set; }
        /// <summary>
        /// display contact information.
        /// </summary>
        public void displayContact()
        {
            Console.WriteLine("FirstName: " + this.FirstName + " LastName: " + this.LastName + " Address: " + this.Address +
                                " City: " + this.City + " State: " + this.State + " Zip: " + this.Zip +
                                  " PhoneNumber: " + this.PhoneNumber + " Email: " + this.Email);
        }

        public void AddContact()
        {
            Console.Write("Enter First Name, Last Name, Address, City, State, Zip, Phone Number, Email \n");
            CreateContact contactPerson = new CreateContact()
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                Zip = Convert.ToDouble(Console.ReadLine()),
                PhoneNumber = Convert.ToDouble(Console.ReadLine()),
                Email = Console.ReadLine(),
            };
            List<CreateContact> list = new List<CreateContact>();
            list.Add(contactPerson);
            contactPerson.displayContact();
        }
    }
}
