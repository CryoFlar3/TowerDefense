using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Tower
    {
        private readonly MapLocation _location;

        public Tower(MapLocation location) {
            _location = location;
        }

        public void FireOnInvaders(Invader[] invaders) {
            int index = 0;

            while(index < invaders.Length) {
                Invader invader = invaders[index];
                // Do stuff with invader

                index++;
            }
        }
    }
}
