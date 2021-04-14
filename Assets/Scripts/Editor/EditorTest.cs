using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using jsFramework;

[CustomEditor(typeof(BallProperty))]
//[CustomEditor(typeof(Icolorable))]

[CustomPropertyDrawer(typeof(BallProperty))] //deve essere incluso nella cartella editor se no non builda
public class EditorTest : Editor
{
    
    public string example = "exp";

    /*
    public override void OnInspectorGUI()
    {
        BallProperty ballProp = (BallProperty)target;
       //Icolorable colorable = (Icolorable)target;

        DrawDefaultInspector();

        if(GUILayout.Button("Genera Colore"))
        {
            ballProp.ChangeColor();
        }

        if(GUILayout.Button("Reset Colore"))
        {
            ballProp.ResetColorToOriginal();
        }

        if(GUILayout.Button("Green")) // cambiare con il nome del colore 
        {
            ballProp.AssignMaterial();
        }

        if (GUILayout.Button("Blue"))
        {
            ballProp.AssignMaterial();
        }


        //colorable.ColorChange

        if (!ballProp.AssegnedColor)
        {
            Debug.Log("Non hai assegnato alcun materiale");
        }

    }
    */

    private void OnDestroy()
    {
        
    }
}
