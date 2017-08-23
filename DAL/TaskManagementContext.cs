using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DAL.Mapping;

namespace DAL
{
    public class TaskManagementContext : DbContext
    {
        public TaskManagementContext()
            : base("name=TaskManagerServerCS")
        {
            //Database.SetInitializer<TaskManagementContext>(new DropCreateDatabaseIfModelChanges<TaskManagementContext>());
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerEmployee> CustomerEmployees { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<RequestType> RequestTypes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Entity.Task> Tasks { get; set; }
        public virtual DbSet<TaskLog> TaskLogs { get; set; }
        public virtual DbSet<Entity.TaskStatus> TaskStatuses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
            modelBuilder.Configurations.Add(new CustomerEmployeeMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new ProjectMap());
            modelBuilder.Configurations.Add(new RequestMap());
            modelBuilder.Configurations.Add(new RequestTypeMap());
            modelBuilder.Configurations.Add(new RoleMap());
            modelBuilder.Configurations.Add(new TaskLogMap());
            modelBuilder.Configurations.Add(new TaskMap());
            modelBuilder.Configurations.Add(new TaskStatusMap());

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
