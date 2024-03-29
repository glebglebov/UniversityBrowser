﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Univer.Interfaces
{
    interface IRepository<T> where T : class
    {
        IQueryable<T> GetList { get; }
        T Get(int id);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
        void Save();
    }
}
