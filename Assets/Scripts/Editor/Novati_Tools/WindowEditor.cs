using UnityEngine;
using UnityEditor;


public class WindowEditor : EditorWindow
{
    public Object Wall;
    public Object Floor;
    public Object hole;
    public Object source;
    public Object second;

    public  new Vector3  position;
    
    
    public string text = "finestra peronalizzata";

    [MenuItem("Tools/Windows/TileEditor")]
    public static void WindowEdit()
    {
        var Rect = new Rect(0, 0, 1000, 1000);
        var window = GetWindow<WindowEditor>();
        window.Show();
    }

    void OnGUI()
    {
        /*
        EditorGUILayout.BeginVertical();
        source = EditorGUILayout.ObjectField(source, typeof(Object), true);
        EditorGUILayout.BeginVertical();
        */
        //
        EditorGUILayout.Space(20f);                                             // distanziamento dall'alto

        
        GUILayout.Label("Editor Custom", EditorStyles.boldLabel);
        EditorGUILayout.Space(80f);
        
        
        
       // position = EditorGUILayout.Vector3Field()

            // vector3 field

        EditorGUILayout.BeginHorizontal();
        GUILayout.Label("Wall", EditorStyles.boldLabel);
        Wall = EditorGUILayout.ObjectField(Wall, typeof(object), true);

        if (Wall == null)
        {
            EditorGUILayout.HelpBox("Inserire Un Elemento", MessageType.Info);
        }

        EditorGUILayout.Space(200f);
        Floor = EditorGUILayout.ObjectField(Floor, typeof(object), true);
        
        if (Floor == null)
        {
            EditorGUILayout.HelpBox("Inserire Un Elemento", MessageType.Info);
        }

        EditorGUILayout.Space(200f);
        hole = EditorGUILayout.ObjectField(hole, typeof(object), true);

        if(hole == null)
        {
            EditorGUILayout.HelpBox("Inserire Un Elemento", MessageType.Info);
        }

        /*
        if (GUILayout.Button("Search!"))
        {
            if (source == null)
                ShowNotification(new GUIContent("No object selected for searching"));
            else if (Help.HasHelpForObject(source))
                Help.ShowHelpForObject(source);
            else
                Help.BrowseURL("http://forum.unity3d.com/search.php");
        }
        */

    }
}
