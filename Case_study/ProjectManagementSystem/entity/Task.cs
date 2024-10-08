using System;

namespace ProjectManagementSystem.entity
{
    public class Task
    {
        
        private int taskId;            
        private string taskName;       
        private int projectId;         
        private int employeeId;        
        private string status;         

        
        public Task() { }
        public Task(int taskId, string taskName, int projectId, int employeeId, string status)
        {
            this.taskId = taskId;
            this.taskName = taskName;
            this.projectId = projectId;
            this.employeeId = employeeId;
            this.status = status;
        }

        
        public int TaskId
        {
            get { return taskId; }
            set { taskId = value; }
        }

        public string TaskName
        {
            get { return taskName; }
            set { taskName = value; }
        }

        public int ProjectId
        {
            get { return projectId; }
            set { projectId = value; }
        }

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        
        public override string ToString()
        {
            return $"Task ID: {taskId}, Task Name: {taskName}, Project ID: {projectId}, Employee ID: {employeeId}, Status: {status}";
        }
    }
}