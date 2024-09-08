﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Mediator
{
    public interface IMediator
    {
        void Notify(object sender, string ev);
    }
}
