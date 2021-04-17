using UnityEngine;
using UnityEditor;
using jsFramework;

[CustomEditor(typeof(GridBase))]
public class WindowEditor : EditorWindow
{
    public Object Wall;
    public Object Floor;
    public Object hole;
    public Object source;
    public Object second;
    public GameObject ObjectSpawn;
    public bool apparition;
    public Editor GgameObject;
    public GameObject gameObject;
    public Vector3 position;


    GridBase gridBase;
    
    
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
        gridBase.GenerateMap();
        
        
        
        
        /*
        EditorGUILayout.BeginVertical();
        source = EditorGUILayout.ObjectField(source, typeof(Object), true);
        EditorGUILayout.BeginVertical();
        */
        //
        EditorGUILayout.Space(20f);                                             // distanziamento dall'alto

        
        GUILayout.Label("Editor Custom", EditorStyles.boldLabel);
        EditorGUILayout.Space(80f);



        position = EditorGUILayout.Vector3Field("GameObject 1:", position);

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

        gameObject = (GameObject)EditorGUILayout.ObjectField(gameObject, typeof(GameObject), true);

        if (gameObject != null)
        {
            if (GgameObject == null)
                GgameObject = Editor.CreateEditor(gameObject);

            GgameObject.OnPreviewGUI(GUILayoutUtility.GetRect(500, 500), EditorStyles.whiteLabel);
        }
    }
     

    
}
