using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Orange : Fruit
    {
        public string _shape;
        public bool _isSweet;
        public override bool IsThisMyFavorite()
        {
            return false;
        }
        public override string ToString()
        {
            return $"{base.ToString()} shape : {_shape} is sweet : {_isSweet} ";
        }
    }
}

