using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
   abstract class Fruit
    {
        public string _name;
        public int _calories;
        public abstract bool IsThisMyFavorite();

        public override string ToString()
        {
            return $"{base.ToString()} name : {_name} calories : {_calories} my favorite fruit : {IsThisMyFavorite()}";
        }

    }
}

