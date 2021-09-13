using UnityEngine;
using jsFramework;

[CreateAssetMenu(fileName = "ObjectDataBase", menuName = "GridFramework/Data/ObjectDataBase")]

public class ObjectDataBase : ScriptableObject
{
    public GameObject[] floor;
    public GameObject wall;
    //-----------------------
    public int x;
    public int y;

    //creare poi nell ispector lo scriptbleobject di questo script, e assegnare ad ogni campo il suo prefabs

}