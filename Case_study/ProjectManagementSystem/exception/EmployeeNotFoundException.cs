using System;

namespace ProjectManagementSystem.exception
{
    public class EmployeeNotFoundException : Exception
    {
        
        public EmployeeNotFoundException() : base("Employee not found.")
        {
        }
        public EmployeeNotFoundException(string message) : base(message)
        {
        }
        public EmployeeNotFoundException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}