﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public ConcreteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._product = new Product();
        }
        public void BuildPartA()
        {
            this._product.Add("PartA1");
        }

        public void BuildPartB()
        {
            this._product.Add("PartB1");
        }

        public void BuildPartC()
        {
            this._product.Add("PartC1");
        }
        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }   
    }
}
