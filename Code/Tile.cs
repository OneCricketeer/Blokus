using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplications.Blokus
{
    public class Tile
    {
        #region Fields
        public List<int[]> tile { get; set; }

        private int width { get { return tile[0].Length; } }
        private int height { get { return tile.Count; } }
        #endregion Fields

        #region Constructors

        public Tile()
        {
            tile = new List<int[]>(5);
        }

        public Tile(int row, int col)
            : this()
        {
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
        // Assumes an nxn board
        public void rotateCW(bool rotate = true)
        {
            if (rotate)
                transpose();
            //            Console.WriteLine("Transpose\n" + this);
            int temp;
            int maxdim = width < height ? width : height;
            // Swap columms
            foreach (int[] row in tile)
            {
                for (int j = 0; j < Math.Floor(width / 2.0); j++)
                {
                    //                    var lhs = row[j];
                    //                    var rhs = row[Math.Abs(j - (width - 1))];
                    temp = row[j];
                    row[j] = row[Math.Abs(j - (width - 1))];
                    row[Math.Abs(j - (width - 1))] = temp;
                    //                    swap(ref lhs, ref rhs);
                }
            }
        }

        // "Rotate" the tile 90 deg counter-clockwise
        // Assumes an nxn board
        public void rotateCCW(bool rotate = true)
        {
            if (rotate)
                transpose();

            // Swap rows
            for (int i = 0; i < Math.Floor(height / 2.0); i++)
            {
                var temp = tile[i];
                //                var bottom = board[Math.Abs(i - (height - 1))];
                tile[i] = tile[Math.Abs(i - (height - 1))];
                tile[Math.Abs(i - (height - 1))] = temp;
                //                swap(ref top, ref bottom);
            }

        }

        // Rotate the tile 90*rot deg clockwise
        // Assumes an nxn board
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
        // Assumes an nxn board
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

        public override string ToString()
        {
            return RookPolynomial.RookPoly.printBoard(tile.ToArray());
        }
    }
}