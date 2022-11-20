using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class TowerDefenseExceptions : Exception
    {
        public TowerDefenseExceptions()
        {

        }

        public TowerDefenseExceptions(string message) : base(message)
        {

        }
    }

    class OutOfBoundsException : TowerDefenseExceptions
    {
        public OutOfBoundsException()
        {

        }

        public OutOfBoundsException(string message) : base(message)
        {

        }
    }
}
