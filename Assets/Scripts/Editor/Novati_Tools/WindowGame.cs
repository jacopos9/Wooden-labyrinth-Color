using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class WindowGame : WindowEditor
{
    public Object Ob;
    public string password = "";
    public int maxCharacters = 4;
    public Object oop;
    
    
    [MenuItem("Tools/Windows/Game")]
    public static void GameWindow()
    {
        var window = GetWindow<WindowGame>();
        window.Show();
    }



    void OnGUI()
    {
        
        /*
         * implementazione del titolo
         * 
         * 
         * 
         * 
        */
        
        password = EditorGUILayout.PasswordField("Inserisci la password",password);

        if (password == "1234")
        {
            if (GUILayout.Button("Vai"))
            {

              
            }
        }

        if (password.Length > maxCharacters)
        {
            EditorGUILayout.HelpBox("Attenzione, la password può contenere massimo quattro caratteri", MessageType.Warning);
        }

        if (password.Length < maxCharacters)
        {
            EditorGUILayout.HelpBox("La password deve contenere almeno quattro caratteri", MessageType.Warning);
        }

       
        // Ob = EditorGUILayout.ObjectField(Ob, typeof(object), true);


    }


    void Appair()
    {
       
    }
    

    private void OnDestroy()
    {
       
    }

    private void OnEnable()
    {
        
    }

   

    
}
