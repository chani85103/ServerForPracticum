using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clients.Repository.Entities
{
    public class Child
    {
        #region data members
        public int Id { get; set; }
        [Required]
        public string IdNumber { get; set; } = string.Empty;
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public DateTime BirthDate { get; set; }
        #endregion


    }
}
