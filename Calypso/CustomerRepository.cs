using Calypso.Models;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calypso;
public class CustomerRepository : Repository<CustomerModel>
{
    public CustomerRepository(LiteDatabase liteDatabase) : base(liteDatabase)
    {

    }
}
