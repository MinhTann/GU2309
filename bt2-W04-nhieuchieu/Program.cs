string[,] map = {
     {"*", ".", ".", "."},
      {".", ".", ".", "."},
      {".", "*", ".", "."},
      {".", ".", ".", "."}
 };
int MAP_HEIGHT = map.GetLength(0);
int MAP_WIDTH = map.GetLength(1);
string[,] mapReport = new string[MAP_HEIGHT, MAP_WIDTH];
for (int yOrdinate = 0; yOrdinate < MAP_HEIGHT; yOrdinate++)
{
    for (int xOrdinate = 0; xOrdinate < map.GetLength(1); xOrdinate++)
    {
        String curentCell = map[yOrdinate, xOrdinate];
        if (curentCell.Equals("*"))
        {
            mapReport[yOrdinate, xOrdinate] = "*";
        }
        else
        {
            int[,] NEIGHBOURS_ORDINATE = { { yOrdinate, xOrdinate - 1 }, { yOrdinate, xOrdinate + 1 } };

            int minesAround = 0;
            for (int i = 0; i < NEIGHBOURS_ORDINATE.GetLength(0); i++)
            {
                int xOrdinateOfNeighbour = NEIGHBOURS_ORDINATE[i, 1];
                int yOrdinateOfNeighbour = NEIGHBOURS_ORDINATE[i, 0];

                bool isOutOfMapNeighbour = xOrdinateOfNeighbour < 0 || xOrdinateOfNeighbour == MAP_WIDTH;
                if (isOutOfMapNeighbour) continue;

                bool isMineOwnerNeighbour = map[yOrdinateOfNeighbour, xOrdinateOfNeighbour].Equals("*");
                if (isMineOwnerNeighbour) minesAround++;
            }

            mapReport[yOrdinate, xOrdinate] = minesAround.ToString();
        }
    }
}