﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess.Contracts;
using DataAccess.Entities;
using DataAccess.Repositories;
using Domain.ValueObjects;

using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class EmployeeModel
    {
        private int idPK;
        private string idNumber;
        private string name;
        private string mail;
        private DateTime birthday;
        private int age;

        private IEmployeeRepository employeeRepository;
        public EntityState State { private get; set; }

        //Propiedades / Modelo de Vista / Validar Datos
        public int IdPK { get => idPK; set => idPK = value; }

        [Required(ErrorMessage = "The field identification number is required.")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Identification number must be only numbers.")]
        [StringLength(maximumLength: 10, MinimumLength = 10, ErrorMessage = "Identification number must be 10 digits.")]
        public string IdNumber { get => idNumber; set => idNumber = value; }

        [Required]
        [RegularExpression("^[a-zA-Z+$", ErrorMessage = "The field must be only letters.")]
        [StringLength(maximumLength: 100, MinimumLength = 3)]
        public string Name { get => name; set => name = value; }

        [Required]
        [EmailAddress]
        public string Mail { get => mail; set => mail = value; }

        public DateTime Birthday { get => birthday; set => birthday = value; }
        public int Age { get => age; private set => age = value; }

        public EmployeeModel()
        {
            employeeRepository = new EmployeeRepository();
        }

        public string SaveChanges()
        {
            string message;
            return message;
        }
    }
}
