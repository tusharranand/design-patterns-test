﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural.Decorator
{
    abstract class Decorator : Component
    {
        protected Component _component;

        public Decorator(Component component)
        {
            this._component = component;
        }

        public void SetComponent(Component component)
        {
            this._component = component;
        }

        public override string Operation()
        {
            if (this._component != null)
            {
                return this._component.Operation();
            }
            else
            {
                return string.Empty;
            }
        }
    }

}
