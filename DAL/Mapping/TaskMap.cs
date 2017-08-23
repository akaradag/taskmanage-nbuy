using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping
{
    class TaskMap : EntityTypeConfiguration<Entity.Task>
    {
        public TaskMap()
        {
            Property(t => t.Description)
                .HasMaxLength(500);

            HasRequired(t => t.Project)
                .WithMany(p => p.Tasks)
                .HasForeignKey(t => t.ProjectID);

            HasMany(t => t.TaskLogs)
                .WithRequired(tl => tl.Task)
                .HasForeignKey(tl => tl.TaskID);
        }
    }
}
