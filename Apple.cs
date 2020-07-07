using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    
        class Apple : Fruit
        {
            public string _color;
            public bool _pinklady;
            public override bool IsThisMyFavorite()
            {
                return false;
            }

            public override string ToString()
            {
                return $"{base.ToString()} color : {_color} is pinklady : {_pinklady}";
            }

            internal void PrintColor()
            {
                throw new NotImplementedException();
            }
        }
    }

