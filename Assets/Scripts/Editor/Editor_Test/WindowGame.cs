using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using jsFramework;

//[CustomPropertyDrawer(typeof(GridBase))]
public class WindowGame : EditorWindow
{
    public Object Ob;
    public string password = "";
    public int maxCharacters = 4;
    public Object oop;
    public bool validation;
    public bool startGame;
    public bool correctPassword = false;
    public GameObject spawnObject;
    public Vector3 pos;
    
  


    [MenuItem("Tools/Windows/Game")]
    public static void GameWindow()
    {
        //var window = GetWindow<WindowGame>();
        //window.Show();
        GetWindow<WindowGame>();
    }

    [MenuItem("Examples/Instantiate Selected")]
    static void InstantiatePrefab()
    {
        Selection.activeObject = PrefabUtility.InstantiatePrefab(Selection.activeObject as GameObject);
    }

    [MenuItem("Examples/Instantiate Selected", true)]
    static bool ValidateInstantiatePrefab()
    {
        GameObject go = Selection.activeObject as GameObject;
        if (go == null)
            return false;

        return PrefabUtility.IsPartOfPrefabAsset(go);
    }


    void OnGUI()
    {
        Title();
        /*
         * implementazione del titolo
         * 
         * 
         * 
         * 
        */

        PrefabUtility.InstantiatePrefab(spawnObject);

        //ObjectSpawn = EditorGUILayout.ObjectField("oggetto da spawnare",ObjectSpawn, typeof(GameObject), false) as GameObject;
        OnValidation();

        //val = EditorGUILayout.Toggle("Schiaccia Qua Per Inizire", val,EditorStyles.toggle);


    }

    public void Title()
    {
        GUILayout.Space(5);
        GUILayout.Label("Editor Game", EditorStyles.boldLabel);
        GUILayout.Space(20);
    }

    public void OnValidation()
    {
        password = EditorGUILayout.PasswordField("Inserisci la password", password);

        if (password == "1234")
        {
            correctPassword = true;

            if (correctPassword)
            {
                correctPassword = EditorGUILayout.Toggle("Password Corretta", correctPassword, EditorStyles.toggle);
            }

            startGame = EditorGUILayout.Toggle("Avvia gioco", startGame, EditorStyles.toggle);
        }

        /*
        if (startGame)
        {
            // aggiungere qua la logica per implementare i pulsanti o resto
            GUILayout.Label("bottone bello", EditorStyles.toggle);
        }
        */

       

        if (startGame)
        {
           
           
            
        }

        if (password.Length > maxCharacters)
        {
            EditorGUILayout.HelpBox("Attenzione, la password può contenere massimo quattro caratteri", MessageType.Warning);
        }

        if (password.Length < maxCharacters)
        {
            EditorGUILayout.HelpBox("La password deve contenere almeno quattro caratteri", MessageType.Warning);
        }

    }



    private void OnDestroy()
    {
        PlayerPrefs.Save();
    }

    private void OnEnable()
    {
        
    }
}
