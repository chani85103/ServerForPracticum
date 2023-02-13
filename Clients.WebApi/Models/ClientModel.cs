﻿using Clients.Common.DTO_s;
using Clients.Repository.Entities;

namespace Clients.WebApi.Models
{
    public class ClientModel
    {
        #region data members
        public string Id { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public bool ToAdvertise { get; set; }
        public int EGender { get; set; }
        public int HmoId { get; set; }
        public string MyImpression { get; set; } = default;


        #endregion
    }
}
