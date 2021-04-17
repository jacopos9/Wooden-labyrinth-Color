using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using jsFramework;

[CustomEditor(typeof(GridGame))]
public class InspectorTileEditor : Editor
{
    public override void OnInspectorGUI()
    {
        GridGame  gridGame= (GridGame)target;
        DrawDefaultInspector();

        if(GUILayout.Button("Genera Mappa"))
        {
            
        }

        
    }
}

