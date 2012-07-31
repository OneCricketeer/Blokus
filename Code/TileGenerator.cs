using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplications.Blokus
{
    internal class TileGenerator
    {
        public ArrayList hand = new ArrayList(21);

//        public int[][] tile = new int[5][];

//        public bool borders(int row, int col)
//        {
//            bool b = false;
//
//            for (int i = -1; i < 2; i++)
//            {
//                for (int j = -1; j < 2; j++)
//                {
//                    try
//                    {
//                        if ((i + j) % 2 == 0) // ignore the 4 corners and the center
//                            continue;
//                        else
//                        {
//                            if (tile[row + i][col + j] == 1)
//                                b = true;
//                            else b = false;
//                            if (b) return b;
//                        }
//                    }
//                    catch (IndexOutOfRangeException)
//                    {
//                        continue;
//                    }
//                }
//            }
//            return b;
//        }

        // create a hand of the 21 blokus pieces
        // Sorted in the order from greatest points to least
        public void generate()
        {

            // 1
            hand.Add(new int[][] 
            {
                new int [] {1},
            });
            // 2 
            hand.Add(new int[][] 
            {
                new int [] {1, 1},
            });
            // 3 
            hand.Add(new int[][] 
            {
                new int [] {1, 1},
                new int [] {1, 0},
            });
            // 4
            hand.Add(new int[][] 
            {
                new int [] {1, 1, 1},
            });
            // 5
            hand.Add(new int[][] 
            {
                new int [] {1, 1},
                new int [] {1, 1},
            });
            // 6
            hand.Add(new int[][] 
            {
                new int [] {1, 1, 1},
                new int [] {0, 1, 0},
            });
            // 7
            hand.Add(new int[][] 
            {
                new int [] {1, 1, 1, 1},
            });
            // 8
            hand.Add(new int[][] 
            {
                new int [] {1, 1, 1},
                new int [] {1, 0, 0}
            });
            // 9
            hand.Add(new int[][] 
            {
                new int [] {1, 1, 0},
                new int [] {0, 1, 1},
            });
            // 10
            hand.Add(new int[][] 
            {
                new int [] {1, 1, 1, 1},
                new int [] {1, 0, 0, 0},
            });
            // 11
            hand.Add(new int[][] 
            {
                new int [] {1, 0, 0},
                new int [] {1, 1, 1},
                new int [] {1, 0, 0},
            });
            // 12
            hand.Add(new int[][] 
            {
                new int [] {1, 1, 1},
                new int [] {1, 0, 0},
                new int [] {1, 0, 0},
            });
            // 13
            hand.Add(new int[][] 
            {
                new int [] {1, 1, 1, 0},
                new int [] {0, 0, 1, 1},
            });
            // 14
            hand.Add(new int[][] 
            {
                new int [] {1, 0, 0},
                new int [] {1, 1, 1},
                new int [] {0, 0, 1},
            });
            // 15
            hand.Add(new int[][] 
            {
                new int [] {1, 1, 1, 1, 1},
            });
            // 16
            hand.Add(new int[][] 
            {
                new int [] {1, 1, 1},
                new int [] {1, 1, 0},
            });
            // 17
            hand.Add(new int[][] 
            {
                new int [] {1, 1, 0},
                new int [] {0, 1, 1},
                new int [] {0, 0, 1},
            });
            // 18
            hand.Add(new int[][] 
            {
                new int [] {1, 1, 1},
                new int [] {1, 0, 1},
            });
            // 19
            hand.Add(new int[][] 
            {
                new int [] {1, 0, 0},
                new int [] {1, 1, 1},
                new int [] {0, 1, 0},
            });
            // 20
            hand.Add(new int[][] 
            {
                new int [] {0, 1, 0},
                new int [] {1, 1, 1},
                new int [] {0, 1, 0},
            });
            // 21
            hand.Add(new int[][] 
            {
                new int [] {1, 1, 1, 1},
                new int [] {0, 1, 0, 0},
            });

            

            for (int i = 0; i < hand.Count; i++)
            {
                hand[i] = new Tile((int[][])hand[i]);
            }
            
            hand.Sort(Tile.SortByScore);
            hand.Reverse();
        }
    }
}