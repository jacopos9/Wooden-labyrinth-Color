using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using jsFramework;


public class TileEditorWindow : EditorWindow
{
   public GridBase gridBase;

    

    [MenuItem("Tools/Window/Tile Editor Window")]
    public static  void TileEditor()
    {
        var Rect = new Rect(0, 0, 1000, 1000);
        var window = GetWindow<TileEditorWindow>();
        window.Show();
    }

    private void OnGUI()
    {
        if (GUILayout.Button("GenerateMap"))
        {
            gridBase.GenerateMap();
        }
    }

  


}
