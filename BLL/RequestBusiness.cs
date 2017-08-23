using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RequestBusiness : IBusiness<Request>
    {
        UnitOfWork _uof;
        Employee _user;

        // Takım Lideri talepleri kayıt altına alabilir, değerlendirip iş olarak açabilir.
        // (İş analisti) takım liderinin yapabildiği gibi müşteriden gelen talepleri kayıt altına alabilir,
        // talepleri değerlendirip işe dönüştürebilir.
        public RequestBusiness(Employee user)
        {
            _uof = new UnitOfWork();
            _user = user;
            
            
        }
        public bool Add(Request item)
        {
                // Employee Role takım lideri veya iş analisti ise
                if (_user.RoleID == 2 || _user.RoleID == 3)
                {
                    if (string.IsNullOrEmpty(item.RequestTypeID.ToString()))
                    {
                        throw new Exception("Lütfen istek tipini seçiniz.");
                    }


                    if (string.IsNullOrEmpty(item.ProjectID.ToString()))
                    {
                        throw new Exception("Lütfen projeyi seçiniz.");
                    }

                    _uof.RequestRepository.Add(item);
                    return _uof.ApplyChanges();
                }
                else
                    throw new Exception("İstek ekleme yetkiniz yok.");
            
        }

        public Request Get(int id)
        {

            // Employee Role takım lideri veya iş analisti ise
            if (_user.RoleID == 2 || _user.RoleID == 3)
            {
                if (id > 0)
                    return _uof.RequestRepository.Get(id);

                else
                    throw new Exception("Lütfen sıfırdan büyük sayı değeri giriniz.");
            }
            else
            {
                throw new Exception("Bu talebi görme yetkiniz yok.");
            }    

        }

        public List<Request> GetAll()
        {
            // Employee Role takım lideri veya iş analisti ise
            if (_user.RoleID == 2 || _user.RoleID == 3)
                return _uof.RequestRepository.GetAll();
            else
                throw new Exception("Talep listesini görme yetkiniz yok.");
        }

        public bool Remove(Request item)
        {
            // Employee Role takım lideri veya iş analisti ise
            if(item != null)
            {
                if (_user.RoleID == 2 || _user.RoleID == 3)
                {
                    _uof.RequestRepository.Delete(item);
                    return _uof.ApplyChanges();
                }
                else
                    throw new Exception("İstek silme yetkiniz yok.");
            }

            throw new Exception("Lütfen silmek istediğiniz isteği seçin.");
           
        }

        public bool Update(Request item)
        {
            // Employee Role takım lideri veya iş analisti ise
            if (item != null)
            {
                if (_user.RoleID == 2 || _user.RoleID == 3)
                {

                    _uof.RequestRepository.Update(item);
                    return _uof.ApplyChanges();
                }
                else
                    throw new Exception("Talep güncelleme yetkiniz yok.");

            }
            else
                throw new Exception("Lütfen güncellenecek isteği seçin.");
        }

        public List<Entity.Request> GetAllByProjectID(int projectId)
        {
            if (_user.RoleID == 1 || _user.RoleID == 2 || _user.RoleID == 3)
                return _uof.RequestRepository.GetAllByProjectID(projectId);
            else
                throw new Exception("İstekleri görme yetkiniz yok.");

        }

        public List<Entity.Request> GetAllFiltered(string input)
        {
            if (_user.RoleID == 1 || _user.RoleID == 2 || _user.RoleID == 3)
                return _uof.RequestRepository.GetAllFiltered(input);
            else
                throw new Exception("İstekleri görme yetkiniz yok.");
        }
    }
}
