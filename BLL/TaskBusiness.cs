using System;
using Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class TaskBusiness : IBusiness<Task>
    {
        UnitOfWork _uof;
        Employee _user;

        public TaskBusiness(Employee user)
        {
            _uof = new UnitOfWork();
            _user = user;
        }

        public bool Add(Task item)
        {
             // İş analisti müşteri isteğini(request) işe çevirdiyse
            if (!string.IsNullOrEmpty(item.Description))
            {
                // Takım Lideri, Proje Yöneticisi, İş Analisti
                if (_user.RoleID == 1 || _user.RoleID == 2 || _user.RoleID == 3)
                {
                    _uof.TaskRepository.Add(item);
                    return _uof.ApplyChanges();
                }
                else
                    throw new Exception("İş ekleme yetkiniz yok. ");

            }
            else
                throw new Exception("Lütfen açıklama kısmını doldurunuz.");
        }

        public Task Get(int id)
        {
            // Takım lideri, proje yöneticisi
            // Yazılımcının id'si taskteki employee id ise
            // Tester id'si taskteki employee id ise
            // Takım Lideri, Proje Yöneticisi, İş Analisti
            if (_user.RoleID == 1 || _user.RoleID == 2 || _user.RoleID == 3)
                return _uof.TaskRepository.Get(id);
            else
                throw new Exception("Bu işi görme yetkiniz yok.");
        }

        public List<Task> GetAll()
        {
            // Takım lideri ve proje yöneticisi
            // İş analisti ??? --> Takım liderinin yeni oluşturduğu "Başlanmadı" iş durumunda değerlendirme için
            if (_user.RoleID == 1 || _user.RoleID == 2 || _user.RoleID == 3)
                return _uof.TaskRepository.GetAll();
            else
                throw new Exception("İşleri görme yetkiniz yok.");
        }

        public List<Entity.Task> GetAllByProject(int projectId)
        {
            if (_user.RoleID == 1 || _user.RoleID == 2 || _user.RoleID == 3)
                return _uof.TaskRepository.GetAllByProject(projectId);
            else
                throw new Exception("İşleri görme yetkiniz yok.");
        }

        public List<Entity.Task> GetAllFiltered(string filter)
        {
            if (_user.RoleID == 1 || _user.RoleID == 2 || _user.RoleID == 3)
                return _uof.TaskRepository.GetAllFiltered(filter);
            else
                throw new Exception("İşleri görme yetkiniz yok.");
        }

        public bool Remove(Task item)
        {
            if (item != null)
            {
                // Takım lideri ve proje yöneticisi
                if (_user.RoleID == 1 || _user.RoleID == 2)
                {
                    _uof.TaskRepository.Delete(item);
                    return _uof.ApplyChanges();
                }
                else
                    throw new Exception("İş silme yetkiniz yok.");
            }
            else
                throw new Exception("Lütfen silmek istediğiniz işi seçiniz.");
            
        }

        public bool Update(Task item)
        {
            // Takım lideri ve proje yöneticisi
            // İş analisti ??? --> Sadece yazılımcı ve tester'a yönlendirmek için
            // Yazılımcı iş bitiminde
            // Tester test bitiminde sadece task durumunu (done ,tested) değiştirebilir.

            if (item != null)
            {
                if (_user.RoleID == 1 || _user.RoleID == 2 || _user.RoleID == 3)
                {
                    _uof.TaskRepository.Update(item);
                    return _uof.ApplyChanges();
                }
                else
                    throw new Exception("İş güncelleme yetkiniz yok.");
            }
            else
                throw new Exception("Lütfen güncellenecek işi seçin.");
            
        }
    }
}
