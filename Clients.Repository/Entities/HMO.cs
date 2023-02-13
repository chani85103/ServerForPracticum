using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients.Repository.Entities
{
    public class HMO
    {
        #region data members
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion
        #region c'tors
        public HMO()
        {

        }

        public HMO( string name)
        {
            Name = name;
        }

        #endregion

    }
}
