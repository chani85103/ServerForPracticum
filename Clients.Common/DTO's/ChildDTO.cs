using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients.Common.DTO_s
{
    public class ChildDTO
    {
        #region data members
        public int Id { get; set; }
        public string IdNumber { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }

        #endregion
    }
}
