﻿using System.ComponentModel.DataAnnotations;

namespace Autumn.Mvc.Data.EF.Npgsql.Samples.Models
{
    public abstract class AbstractEntityWithAddress : AbstractEntity
    {
        [MaxLength(70)]
        public string Address { get; set; }

        [MaxLength(40)]
        public string City { get; set; }

        [MaxLength(40)]
        public string State { get; set; }

        [MaxLength(40)]
        public string Country { get; set; }

        [MaxLength(10)]
        public string PostalCode { get; set; }

        [MaxLength(24)]
        public string Phone { get; set; }

        [MaxLength(24)]
        public string Fax { get; set; }

        [MaxLength(60)]
        [EmailAddress]
        public string Email { get; set; }
    }
}