using UnityEngine;

namespace jsToolGrid
{
    public class MapGenerator : MonoBehaviour
    {
        public static Itile[,] CreateGrid (Vector3 origin,Vector3 offset, float space, Vector2 size, GameObject asset)
        {
            Itile[,] result = new Itile[(uint)size.x, (uint)size.y];

            for (int i = 0; i < size.x; i++)
            {
                for (int j = 0; j  < size.y; j ++)
                {
                    var tile = Instantiate(asset, origin + offset + new Vector3(i, 0, j), Quaternion.identity);
                    result[i, j] = tile.GetComponent<Itile>();
                }
            }

            return result;
        }

        
    }
}