using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class ProjectBusiness : IBusiness<Project>
    {
        UnitOfWork _uof;
        Employee _user;
        public ProjectBusiness(Employee user)
        {
            this._user = user;
            _uof = new UnitOfWork();
        }
        //Proje ekleme ve silme işlemini sadece proje yöneticisi yapabiliyor
        public bool Add(Project item)
        {
            bool result = false;
            if (_user.RoleID==1)
            {
                if (item != null)

                {
                    if (item.Name == null)
                    {
                        throw new Exception("Projenizin Bir ismi olmalı");
                    }
                    if (item.EndDate == null)
                    {
                        throw new Exception("Proje Bitiş Tarihi secmediniz");
                    }
                    if (item.StartDate == null)
                    {
                        item.StartDate = DateTime.Now;
                    }
                    if (item.CustomerID == null)
                    {
                        throw new Exception("CustomerID kısmı boç bırakılamaz");
                    }
                    _uof.ProjectRepository.Add(item);
                    return _uof.ApplyChanges();
                }
                else
                {
                    return result;

                }
            }
            else
            {
                throw new Exception("İşlemi yapabilmek için yetkiniz yok");
            }    
                      
        }

        public Project Get(int id)
        {
            if (_user.RoleID==1 || _user.RoleID==2 || _user.RoleID==3)
            {
                if (id < 0)
                {
                    throw new Exception("ID degeri 0 dan kucuk olamaz");


                }
                else
                {
                    return _uof.ProjectRepository.Get(id);
                }
            }
            else
            {
                throw new Exception("Yetkiniz bulunmamaktadır");
            }
         
            
        }

        public List<Project> GetAll()
        {
            if (_user.RoleID==1 || _user.RoleID==2 || _user.RoleID==3)
            {

                return _uof.ProjectRepository.GetAll();
            }
            else
            {
                throw new Exception("Yetkiniz Bulunmamaktadır");
            }
        }

        public  List<Project> GetAllFiltered(string filter)
        {
            if (_user.RoleID == 1 || _user.RoleID == 2 || _user.RoleID == 3)
            {
                List<Project> allProjects = _uof.ProjectRepository.GetAll();
                List<Project> filteredProjects = (from p in allProjects
                                                      where p.Name.Contains(filter) || 
                                                      p.Customer.CompanyName.Contains(filter) || 
                                                      p.Customer.Country.Contains(filter) ||                                                  
                                                      p.Customer.City.Contains(filter)                                                     
                                                      select p).ToList();
                return filteredProjects;
            }
            else
            {
                throw new Exception("Yetkiniz Bulunmamaktadır");
            }
        }
        
        public bool Remove(Project item)
        {
            if (_user.RoleID==1)
            {
                if (item == null)
                {
                    throw new Exception("Bos bir veriyi silemezsin");
                }
                else
                {

                    _uof.ProjectRepository.Delete(item);
                    return _uof.ApplyChanges();
                }
            }
            else
            {
                throw new Exception("İşlemi Yapabilmek için yetkiniz yok");
            }
         
        }

        public bool Update(Project item)
        {
            if (_user.RoleID==1)
            {

                if (item != null)
                {
                    if (item.StartDate == null)
                    {
                        item.StartDate = DateTime.Now;
                    }
                    if (item.ID <= 0)
                    {
                        throw new Exception("hatalı veri seçtiniz");

                    }
                    _uof.ProjectRepository.Update(item);
                    return _uof.ApplyChanges();
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new Exception("Yetkiniz Bulunmamaktadır");
            }



        }
    }
}

