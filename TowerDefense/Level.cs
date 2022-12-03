using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    internal class Level
    {
        private readonly Invader[] _invaders;
        public Tower[] Towers { get; private set; }
        public Level(Invader[] invaders) {
            _invaders= invaders;
        }

        // Returns true if the player wins otherwise false
        public bool Play() {
            // Run until all invaders are neutralized or an invader reaches the end of the path
            int remainingInvaders = _invaders.Length;
            while(remainingInvaders > 0) {
                // Each tower has an oppretunity to fire on invaders
                foreach (Tower tower in Towers) {
                    tower.FireOnInvaders(_invaders);
                }

                // Count and move the invaders hat are still active
                remainingInvaders = 0;
                foreach (Invader invader in _invaders) {
                    if (invader.IsActive) {
                        invader.Move();

                        if(invader.HasScored) {
                            return false;
                        }

                        remainingInvaders++;
                    }
                }
            }
            return true;

        }
    }
}
