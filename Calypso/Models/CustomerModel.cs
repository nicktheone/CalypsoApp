using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calypso.Models;
public class CustomerModel
{
    private Guid _id;
    private string firstName;
	private string lastName;
	private string phone;
	private string email;
    private string notes;

    [Display(AutoGenerateField = false)]
    public Guid Id
    {
        get { return _id; }
        set { _id = value; }
    }

    [Display(GroupName = "Name", Name = "Cognome")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Cognome necessario")]
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    [Display(GroupName = "Name", Name = "Nome")]
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    [Display(GroupName = "Contatti", Name = "Telefono")]
    public string Phone
    {
        get { return phone; }
        set { phone = value; }
    }

    [Display(GroupName = "Contatti")]
    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    [Display(GroupName = "Note", Name = "Note")]
    [DataType(DataType.MultilineText)]
    public string Notes
    {
        get { return notes; }
        set { notes = value; }
    }
}