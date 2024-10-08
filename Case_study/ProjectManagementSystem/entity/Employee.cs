﻿using System;

namespace ProjectManagementSystem.entity
{
    public class Employee
    {
        
        private int id;
        private string name;
        private string? designation;
        private string? gender;
        private double salary;
        private int projectId; 

        
        public Employee() { }

       
        public Employee(int id, string name, string designation, string gender, double salary, int projectId)
        {
            this.id = id;
            this.name = name;
            this.designation = designation;
            this.gender = gender;
            this.salary = salary;
            this.projectId = projectId;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public int ProjectId
        {
            get { return projectId; }
            set { projectId = value; }
        }

        
        public override string ToString()
        {
            return $"ID: {id}, Name: {name}, Designation: {designation}, Gender: {gender}, Salary: {salary}, ProjectID: {projectId}";
        }
    }
}
