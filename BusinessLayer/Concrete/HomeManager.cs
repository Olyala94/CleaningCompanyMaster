﻿using BusinessLayer.Aabstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HomeManager : IHomeService
    {
        IHomeDal _homeDal;

        public HomeManager(IHomeDal homeDal)
        {
            _homeDal = homeDal;
        }

        public List<Home> GetList()
        {
            return _homeDal.GetList();  
        }

        public void TAdd(Home t)
        {
            _homeDal.Insert(t); 
        }

        public Home TGetById(int id)
        {
            return _homeDal.GetByID(id);    
        }

        public void TRemove(Home t)
        {
            _homeDal.Delete(t);
        }

        public void TUpdate(Home t)
        {
            _homeDal.Update(t);
        }
    }
}
