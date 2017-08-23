using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping
{
    class TaskStatusMap : EntityTypeConfiguration<Entity.TaskStatus>
    {
        public TaskStatusMap()
        {
            Property(ts => ts.Name)
                .HasMaxLength(20);

            HasMany(ts => ts.TaskLogs)
                .WithRequired(tl => tl.TaskStatus)
                .HasForeignKey(tl => tl.TaskStatusID);
        }
    }
}
