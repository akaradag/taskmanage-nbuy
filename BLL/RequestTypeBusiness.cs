using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RequestTypeBusiness : IBusiness<RequestType>
    {
        UnitOfWork _uof;
        Employee _user;

        public RequestTypeBusiness(Employee user)
        {
            _uof = new UnitOfWork();
            _user = user;
        }

        public bool Add(RequestType item)
        { // Employee Role takım lideri veya iş analisti ise
            if(_user.RoleID == 2 || _user.RoleID == 3)
            {
                if (!string.IsNullOrEmpty(item.Name))
                {
                    _uof.RequestTypeRepository.Add(item);
                    return _uof.ApplyChanges();
                }
                else
                {
                    throw new Exception("Lütfen istek çeşit ismini giriniz.");
                }
            }
            
            return false;
        }

        public RequestType Get(int id)
        {
            if (id > 0)
            {
                // Employee Role takım lideri veya iş analisti ise
                if (_user.RoleID == 2 || _user.RoleID == 3)
                    return _uof.RequestTypeRepository.Get(id);
                else
                    throw new Exception("Bu istek tipini görme yetkiniz yok.");
            }
            else
                throw new Exception("İstek tipi numarası pozitif tam sayı değeri seçilmelidir.");
            

        }

        public List<RequestType> GetAll()
        {
            // Employee Role takım lideri veya iş analisti ise
            if (_user.RoleID == 2 || _user.RoleID == 3)
                return _uof.RequestTypeRepository.GetAll();
            else
                throw new Exception("İstek tiplerini görme yetkiniz yok.");
        }

        public bool Remove(RequestType item)
        {
            if (item != null)
            {
                // Employee Role takım lideri veya iş analisti ise
                if (_user.RoleID == 2 || _user.RoleID == 3)
                {
                    _uof.RequestTypeRepository.Delete(item);
                    return _uof.ApplyChanges();
                }
                else
                    throw new Exception("İstek tipi silme yetkiniz yok.");
            }
            else
                throw new Exception("Lütfen silmek istediğiniz istek tipini seçiniz.");

        }

        public bool Update(RequestType item)
        {
            // Employee Role takım lideri veya iş analisti ise
            if (item != null)
            {
                if (_user.RoleID == 2 || _user.RoleID == 3)
                {
                    _uof.RequestTypeRepository.Update(item);
                    return _uof.ApplyChanges();
                }
                else
                    throw new Exception("Talep tipi güncelleme yetkiniz yok.");
            }
            else
                throw new Exception("Lütfen güncellenecek istek tipini seçin.");
                
          }
    }
}
