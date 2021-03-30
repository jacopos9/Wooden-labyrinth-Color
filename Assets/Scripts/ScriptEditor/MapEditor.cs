using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using jsFramework;

[CustomEditor(typeof(GridGame))]
public class MapEditor : Editor
{
    private SerializedObject objectSerialize;
    private SerializedProperty prop;

    //public GameObject cube;

    private void OnSceneGUI()
    {
        objectSerialize = new SerializedObject(target);

    }


    public override void OnInspectorGUI()
    {
        GridGame gridGame = (GridGame)target;

        DrawDefaultInspector();

        if(GUILayout.Button("Genera Mappa"))
        {
            gridGame.GenerateMap();
        }

        objectSerialize.Update();

        prop = objectSerialize.FindProperty("GenerateMap");
        EditorGUILayout.PropertyField(prop); // la assegna

        objectSerialize.ApplyModifiedProperties(); // app

    }

    public void OnDestroy()
    {
       
    }


}
