using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Game
    {
        static void Main(string[] args)
        {
            Map map = new Map(8, 5);
            Console.WriteLine(map.Width * map.Height);
            try
            {
                Path path = new Path(
                    new [] {
                        new MapLocation(0, 2, map),
                        new MapLocation(1, 2, map),
                        new MapLocation(2, 2, map),
                        new MapLocation(3, 2, map),
                        new MapLocation(4, 2, map),
                        new MapLocation(5, 2, map),
                        new MapLocation(6, 2, map),
                        new MapLocation(7, 2, map)
                    }
                );
                MapLocation location = path.GetLocationAt(0);
                Console.WriteLine(location.X + " , " + location.Y);
            }
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(TowerDefenseExceptions ex)
            {
                Console.WriteLine("Unhandled TowerDefenseException");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unhandled Exception");
            }

            Console.Read();
        }
    }
}
