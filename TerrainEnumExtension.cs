using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGameMap
{
    public static class TerrainEnumExtension
    {
        public static ConsoleColor GetColor( this TerrainEnum terrain)
        {
            switch(terrain)
            {
                case TerrainEnum.grass: return ConsoleColor.Green;
                case TerrainEnum.sand: return ConsoleColor.Yellow;
                case TerrainEnum.water: return ConsoleColor.Blue;
                default: return ConsoleColor.DarkGray;
            }
        }

        public static char GetChar( this TerrainEnum terrain)
        {
            switch(terrain)
            {
                case TerrainEnum.grass: return '\u201c';
                case TerrainEnum.sand: return '\u25cb';
                case TerrainEnum.water: return '\u2248';
                default: return '\u25cf';
            }
        }
    }
}
