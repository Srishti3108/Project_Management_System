using System;

namespace ProjectManagementSystem.entity
{
    public class Project
    {
        
        private int id;               
        private string projectName;    
        private string description;    
        private DateTime startDate;    
        private string status;         
        public Project() { }
        public Project(int id, string projectName, string description, DateTime startDate, string status)
        {
            this.id = id;
            this.projectName = projectName;
            this.description = description;
            this.startDate = startDate;
            this.status = status;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string ProjectName
        {
            get { return projectName; }
            set { projectName = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public override string ToString()
        {
            return $"ID: {id}, Project Name: {projectName}, Description: {description}, Start Date: {startDate.ToShortDateString()}, Status: {status}";
        }
    }
}
