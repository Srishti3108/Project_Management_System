using ProjectManagementSystem.entity;
using System.Collections.Generic;
using EntityTask = ProjectManagementSystem.entity.Task;



namespace ProjectManagementSystem.dao
{
    internal interface IProjectRepository
    {
        
        bool CreateEmployee(Employee emp);  
        bool DeleteEmployee(int employeeId);  
        bool CreateProject(Project project);  
        bool DeleteProject(int projectId);  
        bool CreateTask(ProjectManagementSystem.entity.Task task);  
        bool DeleteTask(int taskId);  
       
        bool AssignProjectToEmployee(int projectId, int employeeId);  
        bool AssignTaskInProjectToEmployee(int taskId, int projectId, int employeeId); 
        List<EntityTask> GetAllTasksForEmployeeInProject(int employeeId, int projectId);  
    }
}