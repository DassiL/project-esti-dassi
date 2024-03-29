﻿using Bl.BlObject;
using Dal.DalObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.BlApi
{
    public interface IRepo<T>
    {
        List<T> GetAll();
        T GetById(int id);
        T Add(T t);
        T Update(int id, T t, string street, string apartment);
        T Delete(int id);
    }
}