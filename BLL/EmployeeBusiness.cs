using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmployeeBusiness : IBusiness<Employee>
    {
        UnitOfWork _uof;
        Employee _user;
        public EmployeeBusiness(Employee user)
        {
            _uof = new UnitOfWork();
            this._user = user;

        }
        //Kullanıcıların kontrolleri yapılmadı.
        public bool Add(Employee item)
        {
            bool result = false;

            if (_user.RoleID == 1)
            {
                if (item != null)
                {
                    if (string.IsNullOrEmpty(item.FirstName.Trim()))
                    {
                        throw new Exception("Çalışan İsmini girmediniz");
                    }
                    if (string.IsNullOrEmpty(item.LastName.Trim()))
                    {
                        throw new Exception("Çalışan Soyadını girmediniz");
                    }
                    if (string.IsNullOrEmpty(item.HireDate.ToString()))
                    {
                        throw new Exception("Hiredate bölümü boş bırakılamaz");
                    }
                    if (string.IsNullOrEmpty(item.Email.Trim()))
                    {
                        throw new Exception("Email kısmı boş Bırakılamaz");
                    }
                    if (string.IsNullOrEmpty(item.Password.Trim()))
                    {
                        throw new Exception("Şifrenizi Secmediniz");

                    }
                    if (item.Password.Length < 8 && item.Password.Length > 20)
                    {
                        throw new Exception("Şifreniniz 8 ila 20 karakter arasında olmalıdır");
                    }
                    if (item.RoleID == null)
                    {
                        throw new Exception("RolID kısmı bos bırakılamaz");
                    }
                    _uof.EmployeeRepository.Add(item);
                    return _uof.ApplyChanges();
                }
                else
                {
                    return result;
                }
                
            }
            else
            {
                throw new Exception("İşlemi yapma yetkiniz yok.");
            }
        }

        public Employee Get(int id)
        {
            if (_user.RoleID == 1)
            {
                if (id <= 0)
                {
                    throw new Exception("Hatalı ID degeri girdiniz");
                }
                return _uof.EmployeeRepository.Get(id);

            }
            else
            {
                throw new Exception("Bu işlemi yapmaya yetkiniz yok");
            }
        }

        public Employee GetByTaskId(int taskId)
        {
            if (_user.RoleID==1|| _user.RoleID==2 || _user.RoleID==3)
            {
                if (taskId>0)
                {
                    //Entity.TaskLog tl = _uof.TaskLogRepository.GetLastByTaskId(taskId);
                    //int empId = 0;
                    //Employee emp = new Employee();
                    //if (int.TryParse(tl.EmployeeID.ToString(),out empId))
                    //{
                    //    emp = _uof.EmployeeRepository.Get(empId);
                    //}

                    //return emp;
                    return _uof.EmployeeRepository.GetByTaskId(taskId);
                }
                else
                {
                    throw new Exception("Hatalı TaskId");
                }
            }
            else
            {
                throw new Exception("Bu işlem için yetkiniz yok!");
            }
        }

        public List<Employee> GetByRole(int roleId)
        {
            if (_user.RoleID == 1 || _user.RoleID == 2 || _user.RoleID == 3)
            {
                if (roleId > 0)
                {
                    List<Employee> empList = _uof.EmployeeRepository.GetByRole(roleId);
                    return empList;
                }
                else
                {
                    throw new Exception("Uygun olmayan RoleId!");
                }
            }
            else
            {
                throw new Exception("Bu işlem için yetkiniz yok!");
            }
        }

        public Employee GetByLogIn(string email, string password)
        {
            if (!string.IsNullOrEmpty(email.Trim()) && !string.IsNullOrEmpty(password.Trim()))
            {
                Employee employee = _uof.EmployeeRepository.GetByLogIn(email, password);

                if (employee != null)
                {
                    return employee;
                }
                else
                {
                    throw new Exception("Hatalı kullanıcı adı veya şifre!");
                }
            }
            else
            {
                throw new Exception("Log In bilgileri alınamıyor.");
            }
        }

        public List<Employee> GetAll()
        {
            if (_user.RoleID == 1)
            {
                return _uof.EmployeeRepository.GetAll();
            }
            else
            {
                throw new Exception("Bu İşlemi yapmaya yetkiniz yok");
            }
        }


        public bool Remove(Employee item)
        {

            if (_user.RoleID == 1)
            {

                _uof.EmployeeRepository.Delete(item);
                return _uof.ApplyChanges();

            }
            else
            {
                throw new Exception("Bu işlemi yapmaya yetkiniz yok");
            }



        }

        public bool Update(Employee item)
        {

            if (_user.RoleID == 1)
            {
                _uof.EmployeeRepository.Update(item);

                return _uof.ApplyChanges();

            }
            else
            {
                throw new Exception("Bu işlemi yapmaya yetkiniz yok");
            }


        }
    }
}

