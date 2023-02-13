using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients.Repository.Entities
{
    public class Child
    {
        #region data members
        public string Id{ get; set; } = string.Empty;
        public string FirstName { get; set; }=string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }

        #endregion
  
      
    }
}
