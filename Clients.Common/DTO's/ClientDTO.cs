using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients.Common.DTO_s
{
    public enum EGenderDTO { Male=0, Female=1 }
    public class ClientDTO
    {

        #region data members
        public int Id { get; set; }
        public string IdNumber { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public bool ToAdvertise { get; set; }
        public EGenderDTO EGender { get; set; }
        public string MyImpression { get; set; }
        public HmoDTO HMO { get; set; }
        public int HmoId { get; set; }
        public List<ChildDTO> Children { get; set; }

       

        public ClientDTO()
        {

        }

        public ClientDTO( string idNumber, string firstName, string lastName, DateTime birthDate, bool toAdvertise, EGenderDTO eGender, string myImpression, int hmoId, List<ChildDTO> children)
        {
            IdNumber = idNumber;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            ToAdvertise = toAdvertise;
            EGender = eGender;
            MyImpression = myImpression;
            HmoId = hmoId;
            Children = children;
        }

        #endregion

    }
}
