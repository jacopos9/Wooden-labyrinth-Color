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

}