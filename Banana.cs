using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Banana : Fruit
    {
        public bool _hasBalackSpots;
        public bool _isGreen;
        public float _size;
        public override bool IsThisMyFavorite()
        {
            return false;
        }
        public override string ToString()
        {
            return $"{base.ToString()} has black spots : {_hasBalackSpots} is green : {_isGreen} size: {_size}";
        }

        internal void PrintSize()
        {
            throw new NotImplementedException();
        }
    }
}

