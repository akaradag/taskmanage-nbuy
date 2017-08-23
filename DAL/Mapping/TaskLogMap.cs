using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping
{
    class TaskLogMap : EntityTypeConfiguration<TaskLog>
    {
        public TaskLogMap()
        {
            Property(tl => tl.EmployeeID)
                .IsOptional();

            HasOptional(tl => tl.Employee)
                .WithMany(e => e.TaskLogs)
                .HasForeignKey(tl => tl.EmployeeID);

            HasRequired(tl => tl.TaskStatus)
                .WithMany(ts => ts.TaskLogs)
                .HasForeignKey(tl => tl.TaskStatusID);

            HasRequired(tl => tl.Task)
                .WithMany(t => t.TaskLogs)
                .HasForeignKey(tl => tl.TaskID);
        }
    }
}
