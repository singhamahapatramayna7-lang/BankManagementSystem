using System.Collections.Generic;
class BusinessLogic
{
    public List<Customer> customers = new List<Customer>();
    public int nextCustomerId= 1;

public Customer addCustomer(string name, string email, string address, string phone)
{
    Customer customer = new Customer();

    customer.CustomerId = nextCustomerId++;
    customer.Name = name;
    customer.Email = email;
    customer.Address = address;
    customer.PhoneNo = phone;

    customers.Add(customer);
    return customer;
}

 
public List<Customer> viewCustomer()
{
 return customers;

}


public bool updateCustomer(int id, string newName, string newEmail, string newAddress, string newPhone)
{
    Customer customer = customers.Find(c => c.CustomerId== id);
    if (customer == null)
    {
        return false;
    }

    if (!string.IsNullOrWhiteSpace(newName))
        customer.Name = newName;

    if (!string.IsNullOrWhiteSpace(newEmail))
        customer.Email = newEmail;

    if (!string.IsNullOrWhiteSpace(newAddress))
        customer.Address = newAddress;

    if (!string.IsNullOrWhiteSpace(newPhone))
        customer.PhoneNo = newPhone;

    return true; 
}




}