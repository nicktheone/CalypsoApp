using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calypso.Models;
public class CustomerModel
{
	private string firstName;
	private string lastName;
	private string phone;
	private string email;

	public string FirstName
	{
		get { return firstName; }
		set { firstName = value; }
	}
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
    public string Phone
    {
        get { return phone; }
        set { phone = value; }
    }
    public string Email
    {
        get { return email; }
        set { email = value; }
    }
}