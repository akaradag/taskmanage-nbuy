using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BLL
{
    public class TaskStatusBusiness : IBusiness<TaskStatus>
    {
        UnitOfWork _uof;

        public TaskStatusBusiness()
        {
            _uof = new UnitOfWork();
        } 

        public bool Add(TaskStatus item)
        {
            // Employee Role Proje Yöneticisi
            if (!string.IsNullOrEmpty(item.Name))
            {
                _uof.TaskStatusRepository.Add(item);
                return _uof.ApplyChanges();
            }
            return false;
        }

        public TaskStatus Get(int id)
        {
            // Employee Role Proje Yöneticisi
            return _uof.TaskStatusRepository.Get(id);
        }

        /// <summary>
        /// Task'ın son durumu
        /// </summary>
        /// <param name="taskId"></param>
        /// <returns></returns>
        public TaskStatus GetLastStatusOfTask(int taskId)
        {
            return _uof.TaskStatusRepository.GetLastStatusOfTask(taskId);
        }

        public List<TaskStatus> GetAll()
        {
            // Employee Role Proje Yöneticisi
            return _uof.TaskStatusRepository.GetAll();
        }

        public bool Remove(TaskStatus item)
        {
            // Employee Role Proje Yöneticisi
            _uof.TaskStatusRepository.Delete(item);
            return _uof.ApplyChanges();

        }

        public bool Update(TaskStatus item)
        {
            // Employee Role Proje Yöneticisi
            _uof.TaskStatusRepository.Update(item);
            return _uof.ApplyChanges();
        }
    }
}
