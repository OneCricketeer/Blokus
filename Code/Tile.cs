using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApplications.Blokus
{
    public class Tile
    {
        // A comparer used to sort the tiles by score

        #region Compare Methods

        private class TileComparerHelper : IComparer
        {
            public TileComparerHelper() { }

            /// <summary>
            /// Compares the two states. Used to sort them in the FSM
            /// </summary>
            /// <param name="obj1">State 1</param>
            /// <param name="obj2">State 2</param>
            /// <returns></returns>
            public int Compare(object obj1, object obj2)
            {
                //                n++;
                Tile t1 = (Tile)obj1;
                Tile t2 = (Tile)obj2;
                return t1.score - t2.score;
            }
        }

        /// <summary>
        /// Sorts the states by name
        /// </summary>
        public static IComparer SortByScore
        {
            get { return (IComparer)new TileComparerHelper(); }
        }

        #endregion Compare Methods

        #region Fields
        public List<int[]> tile { get; set; }

        public int width { get { try { return tile[0].Length; } catch { return 0; } } }
        public int height { get { return tile.Count; } }
        public int score
        {
            get
            {
                int i = 0;
                foreach (int[] row in this.tile)
                {
                    foreach (int col in row)
                    {
                        if (col != 0) i++;
                    }
                }
                return i;
            }
        }

        #endregion Fields

        #region Constructors

        public Tile()
        {
            tile = new List<int[]>(5);
        }

        public Tile(int row, int col)
        {
            tile = new List<int[]>();
            List<int> r = new List<int>();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    r.Add(0);
                }
                tile.Add(r.ToArray());
                r = new List<int>();
            }
        }

        public Tile(int[][] tileMatr)
            : this()
        {
            for (int i = 0; i < tileMatr.Length; i++)
            {
                tile.Add(tileMatr[i]);
            }
        }

        #endregion Constructors

        public int[] this[int row]
        {
            get
            {
                try
                {
                    return tile[row];
                }
                catch { return null; }

            }
        }

        // Transposes the matrix
        public void transpose()
        {
            if (height == width)
            {
                int temp;

                // Swaps values over left diagonal
                for (int i = 0; i < tile.Count; i++)
                {
                    for (int j = i + 1; j < tile.Count; j++)
                    {
                        temp = tile[i][j];
                        tile[i][j] = tile[j][i];
                        tile[j][i] = temp;
                        //                    board[i][j] = board[j][board.Count - i - 1];
                        //                    board[j][board.Count - i - 1] = temp;
                    }
                }
            }
            else
            {
                Tile newtile = new Tile(this.width, this.height);

                for (int r = 0; r < height; r++)
                {
                    for (int c = 0; c < width; c++)
                    {
                        newtile.tile[c][r] = tile[r][c];
                    }
                }
                tile = newtile.tile;
            }
        }

        #region Rotate

        // "Rotate" the tile 90 deg clockwise
        public void rotateCW(bool rotate = true)
        {
            if (rotate)
                transpose();
            int temp;
            int maxdim = width < height ? width : height;
            // Swap columms
            foreach (int[] row in tile)
            {
                for (int j = 0; j < Math.Floor(width / 2.0); j++)
                {
                    temp = row[j];
                    row[j] = row[Math.Abs(j - (width - 1))];
                    row[Math.Abs(j - (width - 1))] = temp;
                }
            }
        }

        // "Rotate" the tile 90 deg counter-clockwise
        public void rotateCCW(bool rotate = true)
        {
            if (rotate)
                transpose();

            // Swap rows
            for (int i = 0; i < Math.Floor(height / 2.0); i++)
            {
                var temp = tile[i];
                tile[i] = tile[Math.Abs(i - (height - 1))];
                tile[Math.Abs(i - (height - 1))] = temp;
            }
        }

        // Rotate the tile 90*rot deg clockwise
        public void rotateCW(int rot)
        {
            rot %= 4;
            if (rot < 0)
                rotateCCW(-rot);
            else
                for (int i = 0; i < rot; i++)
                {
                    rotateCW();
                }
        }

        // Rotate the tile 90*rot deg counter-clockwise
        public void rotateCCW(int rot)
        {
            rot %= 4;
            if (rot < 0)
                rotateCW(-rot);
            else
                for (int i = 0; i < rot; i++)
                {
                    rotateCCW();
                }
        }

        #endregion Rotate

        #region Flip
        public void flipVert()
        {
            rotateCCW(false); // Reduces duplicate code
        }

        public void flipHor()
        {
            rotateCW(false); // Reduces duplicate code
        }
        #endregion Flip


        public int getOffset()
        {
            int i = 0;
            while (tile[height -1][i] == 0)
            {
                i++;
            }
            return i;
        }
        public override string ToString()
        {
            if (this.width == 0)
                return "Empty";
            return RookPolynomial.RookPoly.printBoard(tile.ToArray());
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(Tile)) return false;

            Tile t = (Tile)obj;
            bool b = false;
            if (this.width != t.width || this.height != t.height) // Not the same size
                return b;
            else if (this.width + t.width == 0) // Both are empty
                return !b;

            for (int i = 0; i < this.height; i++)
            {
                for (int j = 0; j < this.width; j++)
                {
                    b = this[i][j] == t[i][j];
                    if (!b) return b;
                }
            }
            return b;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}