using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repository;

namespace DAL
{
    public class UnitOfWork
    {
        TaskManagementContext _dbContext;
        DbContextTransaction _transaction;
        public UnitOfWork()
        {
            _dbContext = new TaskManagementContext();
        }

        private CustomerEmployeeRepository  _custEmpRep;

        public CustomerEmployeeRepository  CustomerEmployeeRepository
        {
            get 
            {
                if (_custEmpRep==null)
                {
                    _custEmpRep = new CustomerEmployeeRepository(_dbContext);
                }
                return _custEmpRep;
            }
        }

        private CustomerRepository _custRep;

        public CustomerRepository CustomerRepository
        {
            get
            {
                if (_custRep == null)
                {
                    _custRep = new CustomerRepository(_dbContext);
                }
                return _custRep;
            }
        }

        private EmployeeRepository _empRep;

        public EmployeeRepository EmployeeRepository
        {
            get 
            {
                if (_empRep==null)
                {
                    _empRep = new EmployeeRepository(_dbContext);
                }
                return _empRep;
            }
        }

        private ProjectRepository _projectRep;

        public ProjectRepository ProjectRepository
        {
            get 
            {
                if (_projectRep==null)
                {
                    _projectRep = new ProjectRepository(_dbContext);
                }
                return _projectRep;
            }
        }

        private RequestRepository _requestRep;

        public RequestRepository RequestRepository
        {
            get 
            {
                if (_requestRep==null)
                {
                    _requestRep = new RequestRepository(_dbContext);
                }
                return _requestRep;
            }
        }

        private RequestTypeRepository _reqTypeRep;

        public RequestTypeRepository RequestTypeRepository
        {
            get 
            {
                if (_reqTypeRep==null)
                {
                    _reqTypeRep = new RequestTypeRepository(_dbContext);
                }
                return _reqTypeRep;
            }
        }

        private RoleRepository _roleRep;

        public RoleRepository RoleRepository
        {
            get 
            {
                if (_roleRep==null)
                {
                    _roleRep = new RoleRepository(_dbContext);
                }
                return _roleRep;
            }
        }

        private TaskLogRepository _taskLogRep;

        public TaskLogRepository TaskLogRepository
        {
            get 
            {
                if (_taskLogRep==null)
                {
                    _taskLogRep = new TaskLogRepository(_dbContext);
                }
                return _taskLogRep;
            }
        }

        private TaskRepository _taskRep;

        public TaskRepository TaskRepository
        {
            get 
            {
                if (_taskRep==null)
                {
                    _taskRep = new TaskRepository(_dbContext);
                }
                return _taskRep;
            }
        }

        private TaskStatusRepository _taskStatusRep;

        public TaskStatusRepository TaskStatusRepository
        {
            get 
            {
                if (_taskStatusRep==null)
                {
                    _taskStatusRep = new TaskStatusRepository(_dbContext);
                }
                return _taskStatusRep;
            }
        }
        
        public bool ApplyChanges()
        {
            bool isSuccess = false;

            _transaction = _dbContext.Database.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

            try
            {
                _dbContext.SaveChanges();
                _transaction.Commit();
                isSuccess = true;
            }
            catch (Exception)
            {
                _transaction.Rollback();
                isSuccess = false;
            }
            finally
            {
                _transaction.Dispose();
            }

            return isSuccess;
        }

    }
}
