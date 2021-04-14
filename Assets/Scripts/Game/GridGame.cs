using UnityEngine;
using System.Linq;

namespace jsFramework
{
    public class GridGame : GridBase
    {
        public uint holesCount = 0;
        public uint currentHole = 0;

        /// <summary>
        /// complete generation of the grid
        /// </summary>
        public override void GenerateMap()
        {

            System.Collections.Generic.List<Vector3> points = new System.Collections.Generic.List<Vector3>();

            /* generate points of spawn for holes */
            for (int w = 0; w < width; w++)
            {
                for (int h = 0; h < height; h++)
                {
                    points.Add(origin + offset + new Vector3(w, 0, h));
                }
            }

            while (points.Count > 0)
            {
                Vector3 position = points[Random.Range(0, points.Count)]; //RANDOM RANGE 0

                if (currentHole < holesCount)
                {
                    var hole = Instantiate(objectDataBase.floor[1]);
                    hole.transform.position = position + hole.GetComponent<TileController>().TileData.size / 2;
                    hole.transform.SetParent(gameObject.transform);
                    currentHole++;

                    points.Remove(position);
                }
                else
                {
                    var ground = Instantiate(objectDataBase.floor[0]);
                    ground.transform.position = position + ground.GetComponent<TileController>().TileData.size / 2;
                    ground.transform.SetParent(gameObject.transform);

                    points.Remove(position);
                }

            }

            /* generate wall */
            #region Generate Wall
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (((y == 0 || y == height - 1) && x <= width - 1) ||
                        ((x == 0 || x == width - 1) && y <= height - 1))
                    {
                        var wall = Instantiate(objectDataBase.wall);
                        wall.transform.position = origin + offset + new Vector3(x, 1, y) + wall.GetComponent<TileController>().TileData.size / 2;
                        wall.transform.SetParent(gameObject.transform);
                    }

                }
            }
            #endregion

        }

        public void DestroyMap()
        {
            
        }

    }

   
}