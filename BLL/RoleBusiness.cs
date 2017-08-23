using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RoleBusiness : IBusiness<Role>
    {
        UnitOfWork _uof;
        Employee _user;

        public RoleBusiness(Employee user)
        {
            _uof = new UnitOfWork();
            _user = user;
        }

        
        public bool Add(Role item)
        {

            if (!string.IsNullOrEmpty(item.Name))
            {
                // Employee Role takım lideri
                if (_user.RoleID ==1 ||_user.RoleID == 2 || _user.RoleID == 3)
                {
                    _uof.RoleRepository.Add(item);
                    return _uof.ApplyChanges();
                }
                else
                    throw new Exception("Rol ekleme yetkiniz yok.");
            }
            else
                throw new Exception("Lütfen rol adını giriniz.");

            
        }

        public Role Get(int id)
        {
            if (id > 0)
            {
                // Employeee Role takım lideri
                if (_user.RoleID == 1||_user.RoleID == 2 || _user.RoleID == 3)
                    return _uof.RoleRepository.Get(id);
                else
                    throw new Exception("Bu rolü görme yetkiniz yok.");
            }
            else
                throw new Exception("Rol numarası pozitif tam sayı değeri seçilmelidir.");
            
        }

        public List<Role> GetAll()
        {
            // Employee Role takım lideri veya iş analisti ise
            if (_user.RoleID == 1 || _user.RoleID == 2 || _user.RoleID == 3)
                return _uof.RoleRepository.GetAll();
            else
                throw new Exception("Rolleri görme yetkiniz yok.");
            
            
        }

        public bool Remove(Role item)
        {
            if (item != null)
            {
                // Employee Role takım lideri veya iş analisti ise
                if (_user.RoleID == 1 || _user.RoleID == 2 || _user.RoleID == 3)
                {
                    _uof.RoleRepository.Delete(item);
                    return _uof.ApplyChanges();
                }
                else
                    throw new Exception("Rol silme yetkiniz yok.");
            }
            else
                throw new Exception("Lütfen silmek istediğiniz rolü seçiniz.");
        }

        public bool Update(Role item)
        {
            // Employee Role takım lideri veya iş analisti ise
            if (item != null)
            {
                if (_user.RoleID == 1 || _user.RoleID == 2 || _user.RoleID == 3)
                {
                    _uof.RoleRepository.Update(item);
                    return _uof.ApplyChanges();
                }
                else
                    throw new Exception("Rol güncelleme yetkiniz yok.");
            }
            else
                throw new Exception("Lütfen güncellenecek rolü seçin.");
            
            
            
        }
    }
}
