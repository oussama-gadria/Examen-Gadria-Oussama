﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        int Save();
        IGenericRepository<T> Repository<T>() where T : class;
    }
}
