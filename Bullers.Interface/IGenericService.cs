﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bullers.Interface
{
    public interface IGenericService<T>
    {
        void UpdateData(T t);
        void DeleteData(T t);
        void RemoveData(T t);
        void AddData(T t);
    }
}
