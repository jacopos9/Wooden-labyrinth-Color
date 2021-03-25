using UnityEngine;

namespace jsFramework
{
    [CreateAssetMenu(fileName = "TileData", menuName = "GridFramework/Data/TileData")]
    // file name è il nome del file quando verra creato, menuname è il path --> andare a vedere cliccando con il tasto destro su asset

    //questo è come se fosse un magazzino dove ci sono gli oggetti che stanno sempre nel gioco, dati persistenti
    //quando si parla di oggetti editabili da engine parliamo di scriptableObject
    // si crea uno scriptableobject per ogni oggetto, quandi 1 wall, 1 floor

    public class TileData : ScriptableObject
    {
        public Vector3 size;
        public Color newColor;
        public int id;
    }
}
