﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class EntidadBase<T>
    {
        public virtual T Id { get; set; }
    }
}
