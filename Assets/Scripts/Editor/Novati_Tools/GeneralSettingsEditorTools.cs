using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class GeneralSettingsEditorTools : EditorWindow
{
    
    public Texture2D title;
    Rect titleRect;

    public Texture2D firstAreaTexture;
    Rect firstAreaRect;

    public Texture2D secondAreaTexture;
    Rect secondAreaRect;

    public Texture2D thirdAreaTexture;
    Rect thirdAreaRect;



    [MenuItem("Js/External Tools")]
    public static void OpenWindowsTool()
    {
        GetWindow<GeneralSettingsEditorTools>();
    }

    private void OnGUI()
    {
        LayoutWindow();
        TitleArea();
        FirstArea();
        SecondArea();
        ThirdArea();
    }

    private void OnEnable()
    {
        DrawOnEnable();
    }

    public void TitleArea()
    {
        GUILayout.BeginArea(titleRect);
        GUILayout.Label("Externals Tools", EditorStyles.boldLabel);
        GUILayout.EndArea();
    }
    public void FirstArea()
    {
        GUILayout.BeginArea(firstAreaRect);
        GUILayout.Label("Custom Grid Tool",EditorStyles.boldLabel);
        GUILayout.EndArea();
    }

    public void SecondArea()
    {
        GUILayout.BeginArea(secondAreaRect);
        GUILayout.Label("Just For Fun", EditorStyles.boldLabel);
        GUILayout.EndArea();
    }
    
    public void ThirdArea()
    {
        GUILayout.BeginArea(thirdAreaRect);
        GUILayout.Label("Coming Soon!", EditorStyles.boldLabel);
        GUILayout.EndArea();

    }

    // disegna la tex
    public void DrawOnEnable()
    {
        title = Resources.Load<Texture2D>("Tex/White");
        firstAreaTexture = Resources.Load<Texture2D>("Tex/Yellow");
        secondAreaTexture = Resources.Load<Texture2D>("Tex/Orange");
        thirdAreaTexture = Resources.Load<Texture2D>("Tex/Red");

    }

    // disegno le dimensioni delle finestre
    public void LayoutWindow()
    {

        titleRect.y = 0;
        titleRect.x = 0;
        titleRect.width = Screen.width;
        titleRect.height = 100;
        GUI.DrawTexture(titleRect, title);

        firstAreaRect.y = 100; //altezza
        firstAreaRect.x = 0;
        firstAreaRect.width = Screen.width;
        firstAreaRect.height = 150;
        GUI.DrawTexture(firstAreaRect, firstAreaTexture);

        secondAreaRect.y = 250;
        secondAreaRect.x = 0;
        secondAreaRect.width = Screen.width;
        secondAreaRect.height = 150;
        GUI.DrawTexture(secondAreaRect, secondAreaTexture);

        thirdAreaRect.y = 400;
        thirdAreaRect.x = 0;
        thirdAreaRect.width = Screen.width;
        thirdAreaRect.height = 150;
        GUI.DrawTexture(thirdAreaRect, thirdAreaTexture);
    }
}
