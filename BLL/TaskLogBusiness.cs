using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TaskLogBusiness : IBusiness<TaskLog>
    {
        // Ara tablo değişiklik yapılmayacak.
        UnitOfWork _uof;

        public TaskLogBusiness()
        {
            _uof = new UnitOfWork();
        }

        public bool Add(TaskLog item)
        {
            
                _uof.TaskLogRepository.Add(item);
                return _uof.ApplyChanges();
            
            
        }

        public TaskLog Get(int id)
        {
            return _uof.TaskLogRepository.Get(id);
        }

        public List<TaskLog> GetAll()
        {
            return _uof.TaskLogRepository.GetAll();
        }

        public List<Entity.TaskLog> GetAllByProject(int projectId)
        {
            //if (_user.RoleID == 1 || _user.RoleID == 2 || _user.RoleID == 3)
                return _uof.TaskLogRepository.GetAllByProject(projectId);
            //else
            //    throw new Exception("İşleri görme yetkiniz yok.");
        }

        public List<Entity.TaskLog> GetAllFiltered(string filter)
        {
            //if (_user.RoleID == 1 || _user.RoleID == 2 || _user.RoleID == 3)
                return _uof.TaskLogRepository.GetAllFiltered(filter);
            //else
            //    throw new Exception("İşleri görme yetkiniz yok.");
        }
        /// <summary>
        /// parametre olarak -1 girersen null olanları döndürür.
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public List<Entity.TaskLog> GetAllByEmployeeId(int employeeId)
        {
            return _uof.TaskLogRepository.GetAllByEmployeeID(employeeId);
        }

        public bool Remove(TaskLog item)
        {
            _uof.TaskLogRepository.Delete(item);
            return _uof.ApplyChanges();
        }

        public bool Update(TaskLog item)
        {
            _uof.TaskLogRepository.Update(item);
            return _uof.ApplyChanges();
        }
    }
}
