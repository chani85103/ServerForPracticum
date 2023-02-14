using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients.Repository.Entities
{
    public enum EGender { Male=0, Female=1 }
    public class Client 
    {
        #region data members
        public int Id { get; set; }
        [Required]
        public string IdNumber { get; set; } = string.Empty;
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public DateTime BirthDate { get; set; }
        public bool ToAdvertise { get; set; }
        [Required]
        public EGender EGender { get; set; }
        public string MyImpression { get; set; }
        public HMO HMO { get; set; }
        [Required]
        public int HmoId { get; set; }
        public List<Child> Children { get; set; }


        #endregion


    }
}
