using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CustomerEmployeeBusiness : IBusiness<CustomerEmployee>
    {
        Employee _user;
        UnitOfWork _uof;

        public CustomerEmployeeBusiness(Employee user)
        {
            _uof = new UnitOfWork();
            this._user = user;
        }

        public bool Add(CustomerEmployee item)
        {
           bool result = false;

            if (_user.RoleID == 1)
            {
                if (item!=null)
                {
                    if(string.IsNullOrEmpty(item.FirstName.Trim()))
                    {
                        throw new Exception("İsim olmadan kayıt yapılamaz!");
                    }
                    if (string.IsNullOrEmpty(item.LastName.Trim()))
                    {
                        throw new Exception("Soyisim olmadan kayıt oluşturulamaz!");
                    }
                    if (string.IsNullOrEmpty(item.Phone.Trim()))
                    {
                        throw new Exception("Telefon bilgisi olmadan kayıt oluşturulamaz.");
                    }
                    _uof.CustomerEmployeeRepository.Add(item);
                    return _uof.ApplyChanges();
                    
                }
            }
            else
            {
                throw new Exception("Bu işlemi yapmaya yetkiniz yok!");
            }
            return result;
        }

        public CustomerEmployee Get(int id)
        {
            if (_user.RoleID==1 || _user.RoleID==2 || _user.RoleID==3)
            {
                if (id<0)
                {
                    throw new Exception("Hatalı id değeri");
                }
                return _uof.CustomerEmployeeRepository.Get(id);
            }
            else
            {
                throw new Exception("Bu işlemi yapmaya yetkiniz yok!");
            }
        }

        public List<CustomerEmployee> GetAll()
        {
            if (_user.RoleID == 1 || _user.RoleID == 2 || _user.RoleID == 3)
            {
                return _uof.CustomerEmployeeRepository.GetAll();
            }
            else
            {
                throw new Exception("Bu işlem için yetkiniz yok!");
            }
        }

        public bool Remove(CustomerEmployee item)
        {
            bool result = false;

            if (_user.RoleID == 1)
            {
                if (item!=null)
                {
                    _uof.CustomerEmployeeRepository.Delete(item);
                    result = _uof.ApplyChanges();
                }
                else
                {
                    throw new Exception("Silinecek kayıt bulunamadı.");
                }
            }
            else
            {
                throw new Exception("Bu işlem için yetkiniz yok!"); 
            }

            return result;
        }

        public bool Update(CustomerEmployee item)
        {
            bool result = false;

            if (_user.RoleID == 1)
            {
                if (item != null)
                {
                    if (string.IsNullOrEmpty(item.FirstName.Trim()))
                    {
                        throw new Exception("İsim olmadan kayıt yapılamaz!");
                    }
                    if (string.IsNullOrEmpty(item.LastName.Trim()))
                    {
                        throw new Exception("Soyisim olmadan kayıt oluşturulamaz!");
                    }
                    if (string.IsNullOrEmpty(item.Phone.Trim()))
                    {
                        throw new Exception("Telefon bilgisi olmadan kayıt oluşturulamaz.");
                    }
                    _uof.CustomerEmployeeRepository.Add(item);
                    result = _uof.ApplyChanges();
                }
            }
            else
            {
                throw new Exception("Bu işlemi yapmaya yetkiniz yok!");
            }
            return result;
        }

        public List<CustomerEmployee> GetCusEmpByCustomer(int customerId)
        {
            return _uof.CustomerEmployeeRepository.GetCusEmpByCustomerId(customerId);
        }
    }
}
