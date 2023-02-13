using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients.Repository.Entities
{
    public enum EGender { Male=0, Female=1 }
    public class Client 
    {
        #region data members
        public string Id { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public bool ToAdvertise { get; set; }
        public EGender EGender { get; set; }
        public string MyImpression { get; set; }
        public HMO HMO { get; set; }
        public int HmoId { get; set; }
        public List<Child> Children { get; set; }


        #endregion


    }
}
