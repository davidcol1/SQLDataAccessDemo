using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace FormUI
{
  public class DataAccess
  {
    public List<Person> GetPeople( string lastName )
    {
      using ( IDbConnection connection = new SqlConnection( Helper.CnnVal( "SampleDB" ) ) )
      {
        //return connection.Query<Person>( $"select * from People where LastName = '{lastName}'" ).ToList(); //don't ever do this
        return connection.Query<Person>( $"dbo.People_GetByLastName @LastName", new { LastName = lastName } ).ToList();
      }
    }

    public void InsertPerson(string firstName, string lastName, string emailAddress, string phoneNumber)
    {
      using (IDbConnection connection = new SqlConnection(Helper.CnnVal("SampleDB")))
      {
        List<Person> people = new List<Person>
        {
          new Person { FirstName = firstName, LastName = lastName, EmailAddress = emailAddress, PhoneNumber = phoneNumber }
        };

        connection.Execute( "dbo.People_Insert @FirstName, @LastName, @EmailAddress, @PhoneNumber", people );
      }
    }
  }
}
