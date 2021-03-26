using UnityEngine;
using jsFramework;

[CreateAssetMenu(fileName = "ObjectDataBase", menuName = "GridFramework/Data/ObjectDataBase")]

public class ObjectDataBase : ScriptableObject//database di oggeti che possono essere spawnati dalla griglia, databaase totale di tutti gli oggetti, il colore non centra qua
{
    public GameObject[] floor;
    public GameObject wall;

    //creare poi nell ispector lo scriptbleobject di questo script, e assegnare ad ogni campo il suo prefabs

}