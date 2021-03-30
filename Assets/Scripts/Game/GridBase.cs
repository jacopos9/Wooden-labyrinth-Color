using UnityEngine;

namespace jsFramework
{
    public class GridBase : MonoBehaviour
    {
        #region Variables grid data
        public int width = 0;
        public int height = 0;
        public Vector3 origin = new Vector3(0, 0, 0);
        public Vector3 offset = new Vector3(0, 0, 0);
        public ObjectDataBase objectDataBase;
        #endregion

        public GameObject[,] content;

        public void Start()
        {
            content = new GameObject[width, height];
            GenerateMap();


        }
        /// <summary>
        /// Map Generator base
        /// </summary>
        public virtual void GenerateMap()
        {
            for (int w = 0; w < width; w++)
            {
                for (int h = 0; h < height; h++)
                {
                    content[w, h] = Instantiate(objectDataBase.floor[0]);
                    content[w, h].transform.position = origin + offset + new Vector3(w, 0, h) + content[w, h].GetComponent<TileController>().TileData.size / 2;
                    content[w, h].transform.SetParent(gameObject.transform);
                }
            }
        }
    }
}