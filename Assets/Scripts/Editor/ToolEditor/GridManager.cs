using System.Collections.Generic;
using UnityEngine;

namespace jsToolGrid
{
    [ExecuteInEditMode]

    public static class GridManager
    {
        static List<Itile[,]> data = new List<Itile[,]>();

        public static void RegisterGrid(ref Itile[,] grid) => data.Add(grid);
    }
}
