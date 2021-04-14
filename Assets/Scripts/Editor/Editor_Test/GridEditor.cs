using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using jsFramework;

[CustomEditor(typeof(GridGame))]
public class GridEditor : Editor
{

    public override void OnInspectorGUI()
    {
        GridGame gridGame = (GridGame)target;

        if (GUILayout.Button("GeneraMappa"))
        {
            gridGame.GenerateMap();
        }

        if(GUILayout.Button("Distruggi Mappa"))
        {
            DestroyImmediate(this);
        }
        DrawDefaultInspector();
    }

    private void OnSceneGUI()
    {
        
    }

}
