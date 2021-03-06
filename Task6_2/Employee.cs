﻿using System;

namespace Task6_2
{
    public class Employee : Person
    {
        public string CompanyName { get; }
        public string DepartmentName { get; }

        public Employee(string name, DateTime dateOfBirth, string address, string companyName, string departmentName) 
            : base(name, dateOfBirth, address)
        {
            CompanyName = companyName;
            DepartmentName = departmentName;
        }
    }
}
