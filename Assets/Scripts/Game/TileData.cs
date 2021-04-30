using UnityEngine;

namespace jsFramework
{
    [CreateAssetMenu(fileName = "TileData", menuName = "GridFramework/Data/TileData")]
   
    public class TileData : ScriptableObject
    {
        public Vector3 size;
        public Color newColor;
        public int id;
    }
}
