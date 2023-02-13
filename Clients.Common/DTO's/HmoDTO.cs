using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients.Common.DTO_s
{
    public class HmoDTO
    {
        public HmoDTO( string name)
        {
            Name = name;
        }

        public HmoDTO(int id, string name)
        {
            Id = id;
            Name = name;
        }
        #region data members
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion
    }
}
