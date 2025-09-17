using System;
class BankManagementSystemUI
{
public static void Main(String[] args)
{
BankManagementSystemUI bms=new BankManagementSystemUI();
bool running = true;

while (running)
{
Console.Clear(); 
Console.WriteLine("=====================================");
Console.WriteLine("       Bank Management System       ");
Console.WriteLine("=====================================");
Console.WriteLine("1.Customer Management");
Console.WriteLine("2.Account Management");
Console.WriteLine("3.Transactions");
Console.WriteLine("4.Loan Management");
Console.WriteLine("5.ATM Card Management");
Console.WriteLine("6.Online Banking");
Console.WriteLine("7.Employee Management");
Console.WriteLine("8.Security Features");
Console.WriteLine("9.Reports and Analytics");
Console.WriteLine("0. Exit");
Console.WriteLine("=====================================");
Console.Write("Enter your choice (0-9): ");

string choice = Console.ReadLine();

switch (choice)
{
case "1":
bms.CustomerManagementMenu();
break;
case "2":
bms.AccountManagementMenu();
break;
case "3":
bms.TransactionsMenu();
break;
case "4":
running = false;
Console.WriteLine("Exiting system. Goodbye!");
break;
default:
Console.WriteLine("Invalid choice! Please select a valid option (1-4).");
break;
}

if (running)
{
Console.WriteLine("\nPress any key to return to the menu...");
Console.ReadKey();
}
}




}
public void CustomerManagementMenu()
    {
        Console.WriteLine("Customer Management:");
        Console.WriteLine("1. Add Customer");
        Console.WriteLine("2. Edit Customer");
        Console.WriteLine("3. View Customer");
        Console.WriteLine("0. Exit");
        Console.Write("Enter your choice (0-3): ");
        string customerChoice = Console.ReadLine();

        switch (customerChoice)
        {
            case "1":
                AddCustomer();
                break;
            case "2":
                EditCustomer();
                break;
            case "3":
                ViewCustomer();
                break;
            case "0":
               Exit();
                break;
            default:
                Console.WriteLine("Invalid customer option.");
                break;
        }
    }

public void AccountManagementMenu()
{
}

public void TransactionsMenu()
{
}

BusinessLogic bl=new BusinessLogic();
public void AddCustomer()
{
    Console.WriteLine("=== Add New Customer ===");

    Console.Write("Enter customer name: ");
    string name = Console.ReadLine();

    Console.Write("Enter customer Email: ");
    string email= Console.ReadLine();

    Console.Write("Enter customer address: ");
    string address = Console.ReadLine();

    Console.Write("Enter customer phone number: ");
    string phone = Console.ReadLine();

    Customer newCustomer = bl.addCustomer(name, email, address, phone);
    Console.WriteLine($"\nCustomer '{name}' added successfully with ID: {newCustomer.CustomerId}");


}
public void EditCustomer()
{
Console.Write("Enter Customer ID to edit: ");
    if (!int.TryParse(Console.ReadLine(), out int customerId))
    {
        Console.WriteLine("Invalid ID.");
        return;
    }

    Console.Write("Enter new name: ");
    string newName = Console.ReadLine();

    Console.Write("Enter new email: ");
    string newEmail = Console.ReadLine();

    Console.Write("Enter new address: ");
    string newAddress = Console.ReadLine();

    Console.Write("Enter new phone number: ");
    string newPhone = Console.ReadLine();

    bool result = bl.updateCustomer(customerId, newName, newEmail, newAddress, newPhone);

    if (result)
        Console.WriteLine("Customer updated successfully.");
    else
        Console.WriteLine("Customer not found.");
}
public void ViewCustomer()
{
 List<Customer> customerList = bl.viewCustomer();

if (customerList.Count == 0)
{
Console.WriteLine("No customers found.");
return;
}
Console.WriteLine("=== Customer List ===");
foreach (Customer customer in customerList)
{
        Console.WriteLine($"ID: {customer.CustomerId}");
        Console.WriteLine($"Name: {customer.Name}");
        Console.WriteLine($"Email: {customer.Email}");
        Console.WriteLine($"Address: {customer.Address}");
        Console.WriteLine($"Phone: {customer.PhoneNo}");
        Console.WriteLine("-----------------------------");
}

}

public void Exit()
{


}


}