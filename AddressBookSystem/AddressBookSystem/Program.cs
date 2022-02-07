using AddressBookSystem;

Console.Write("Enter First Name, Last Name, Address, City, State, Zip, Phone Number, Email \n");
CreateContact program = new CreateContact()
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
program.displayContact();