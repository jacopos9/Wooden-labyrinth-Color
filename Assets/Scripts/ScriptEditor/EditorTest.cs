using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(BallProperty))]
public class EditorTest : Editor
{

    public override void OnInspectorGUI()
    {
        BallProperty ballProp = (BallProperty)target;

        DrawDefaultInspector();

        if(GUILayout.Button("Genera Colore"))
        {
            ballProp.ChangeColor();
        }

        if(GUILayout.Button("Reset Colore"))
        {
            ballProp.ResetColorToOriginal();
        }
        
    }




}
