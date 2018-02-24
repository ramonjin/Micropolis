﻿namespace MicropolisCore
{
    /// <summary>
    /// Another direction enumeration class, with 8 possible directions.
    /// TODO Eliminate #Direction.
    /// TODO After eliminating #Direction, rename this enum to Direction.
    /// </summary>
    public enum Direction2
    {
        DIR2_INVALID,    // Invalid direction.
        DIR2_NORTH,      // Direction pointing north.
        DIR2_NORTH_EAST, // Direction pointing north-east.
        DIR2_EAST,       // Direction pointing east.
        DIR2_SOUTH_EAST, // Direction pointing south-east.
        DIR2_SOUTH,      // Direction pointing south.
        DIR2_SOUTH_WEST, // Direction pointing south-west.
        DIR2_WEST,       // Direction pointing west.
        DIR2_NORTH_WEST, // Direction pointing north-west.

        DIR2_BEGIN = DIR2_NORTH,        // First valid direction.
        DIR2_END = DIR2_NORTH_WEST + 1, // End-condition for directions  
    }

    public class DirectionUtils
    {
        public static Direction2 rotate180(Direction2 dir)
        {
            return rotate45(dir, 4);
        }

        public static Direction2 rotate45(Direction2 dir, int count = 1)
        {
            return ((dir - Direction2.DIR2_NORTH + count) & 7) + Direction2.DIR2_NORTH;
        }

        public static Direction2 increment90(Direction2 dir)
        {
            return increment45(dir, 2);
        }

        public static Direction2 increment45(Direction2 dir, int count = 1)
        {
            return dir + count;
        }
    }
}