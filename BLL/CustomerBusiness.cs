using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CustomerBusiness : IBusiness<Customer>
    {
        UnitOfWork _ouf;
        Employee _user;

        public CustomerBusiness()
        {
        }

        public CustomerBusiness(Employee user)
        {
            _ouf= new UnitOfWork();
            this._user = user;
        }
        public List<Customer> GetFilteredCustomer(string filter)
        {
            if (_user.RoleID == 1 || _user.RoleID == 2 || _user.RoleID == 3)
            {
                List<Customer> allCustomer = _ouf.CustomerRepository.GetAll();
                List<Customer> filteredCustomer = (from c in allCustomer
                                                   select c).ToList();
                return filteredCustomer;

            }
            else
            {
                throw new Exception("Yetkiniz Bulunmamakta");
            }





        }

        public bool Add(Customer item)
        {
            bool result = false;
            if (_user.RoleID == 1 )
            {
                if (item != null)
                {
                    if (string.IsNullOrEmpty(item.CompanyName.Trim()))
                    {
                        throw new Exception("Müşterinin Şirketi seçilmek zorundadır");

                    }
                    if (string.IsNullOrEmpty(item.Country.Trim()))
                    {
                        throw new Exception("Müşterinin Ülkesi boş geçilemez");
                    }
                    if (string.IsNullOrEmpty(item.City.Trim()))
                    {
                        throw new Exception("Müşterinin Şehri boş geçilemez");
                    }
                    if (item.Contacts == null)
                    {
                        throw new Exception("Contact kısmını boş geçtiniz");
                    }
                    if (item.Projects == null)
                    {
                        throw new Exception("Müşterinin Proje kısmını boş bıraktınız");
                    }
                    _ouf.CustomerRepository.Add(item);
                    return _ouf.ApplyChanges();
                }
            }
            return result;

        }

        public Customer Get(int id)
        {           
            if (_user.RoleID==1 || _user.RoleID==3 || _user.RoleID==2)
            {
                if (id < 0)
                {
                    throw new Exception("Hatalı ID degeri giridniz");
                }
                return _ouf.CustomerRepository.Get(id);
            }
            else
            {
                throw new Exception("Bu İşlemi yapmaya yetkiniz yok");
            }           
        }
           
        public List<Customer> GetAll()
        {
            if (_user.RoleID == 1 || _user.RoleID == 3 || _user.RoleID == 2)
            {

                return _ouf.CustomerRepository.GetAll();
            }
            else
            {
                throw new Exception("Bu İşlemi yapmak için yetkiniz yok");
            }
        }

        public bool Remove(Customer item)
        {
            if (_user.RoleID==1 )
            {

                if (item != null)
                {
                    _ouf.CustomerRepository.Delete(item);
                }
                return _ouf.ApplyChanges();
            }
            else
            {
                throw new Exception("Bu İşlemi Yapabilmek için yetkiniz bulunmamaktadır");
            }

        }

        public bool Update(Customer item)
        {
            if (_user.RoleID==1 )
            {
                if (item == null)
                {
                    throw new Exception("Bos ID li deger seçtiniz");

                }
                else
                {
                    if (item.ID <= 0)
                    {
                        throw new Exception("Girilen ID degeri hatalıdır");
                    }
                    _ouf.CustomerRepository.Update(item);
                    return _ouf.ApplyChanges();

                }

            }
            else
            {
                throw new Exception("Bu İşlemi Yapabilmek için Yetkiniz yok");
            }        
            
        }      
    }
}
