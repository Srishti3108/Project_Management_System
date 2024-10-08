using ProjectManagementSystem.dao;
using ProjectManagementSystem.main;
using ProjectManagementSystem.exception;
using ProjectManagementSystem.entity;

namespace ProjectManagementSystem.Tests
{
    public class EmployeeProjecttask_test
    {
        [Test]
        public void EmployeeNotFoundExceptionThrown_Test()
        {
            var repository = new ProjectRepositoryImpl();
            var nonexistentEmployeeTd = -1;
            Assert.Throws<EmployeeNotFoundException>(() => repository.AssignProjectToEmployee(nonexistentEmployeeTd, 1));
        }
        [Test]
        public void ProjectNotFoundExceptionThrown_Test()
        {
            var repository = new ProjectRepositoryImpl();
            var nonexistentEmployeeTd = -1;
            Assert.Throws<ProjectNotFoundException>(() => repository.AssignProjectToEmployee(1, nonexistentEmployeeTd));
        }
    }
    public class Employee_tests
    {
        [Test]
        public void EmployeeCreatedSuccessfully()
        {
            var repository = new ProjectRepositoryImpl();
            var employee = new Employee
            {
                Id = 1,
                Name = "Suman Mishra",
                Designation = "Consultant",
                Gender = "F",
                Salary = 30000,
                ProjectId = 4,
            };
            var result = repository.CreateEmployee(employee);
            Assert.IsTrue(result, "Employee should be created successfully");
        }
        

    }
    [TestFixture]
    public class Test_Tasks
    {
        [Test]
        public void TaskCreatedSuccessfully_test()
        {
            var repository = new ProjectRepositoryImpl();
            var task = new ProjectManagementSystem.entity.Task
            {
                TaskId = 1,
                TaskName = "Debugging",
                ProjectId = 2,
                EmployeeId=3,
                Status="Assigned",
            };
            var result = repository.CreateTask(task);
            Assert.IsTrue(result, "Task should be created successfully.");

        }
    }
}