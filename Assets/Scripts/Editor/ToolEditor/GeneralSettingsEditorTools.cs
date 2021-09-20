using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using jsFramework;
using jsToolGrid;

namespace jsToolGrid
{
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



        [MenuItem("Js/External Tools")]   //controllare bene + shortcut
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
            GUILayout.Label("Custom Grid Tool", EditorStyles.boldLabel);
            GUILayout.Space(40);

            if (GUILayout.Button("GridTools", GUILayout.Height(30), GUILayout.Width(150)))
            {
                OptionGridArea.OpenWindows();
            }

            GUILayout.EndArea();
        }

        public void SecondArea()
        {
            GUILayout.BeginArea(secondAreaRect);
            GUILayout.Label("Just For Fun", EditorStyles.boldLabel);
            GUILayout.Space(40);

            if (GUILayout.Button("avvia!", GUILayout.Height(30), GUILayout.Width(150)))
            {
                OptionJustForFunArea.OpenWindows();
            }

            GUILayout.EndArea();
        }

        public void ThirdArea()
        {
            GUILayout.BeginArea(thirdAreaRect);
            GUILayout.Label("Coming Soon!", EditorStyles.boldLabel);
            GUILayout.EndArea();

        }

        // disegna la texture
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

            firstAreaRect.y = 100;
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

    public class OptionGridArea : EditorWindow
    {
        static OptionGridArea windows;
        Texture2D title;
        Rect rectTitle;
        public TileData tileData;

        float unitSize = 0.1f;
        Vector3 origin;
        Vector3 offset;
        Vector2 size;

        public static void OpenWindows()
        {
            windows = (OptionGridArea)GetWindow(typeof(OptionGridArea));
            windows.minSize = new Vector3(200, 250);
            windows.Show();
        }

        private void OnEnable()
        {
            DrawTextureOnEnable();
        }

        private void OnGUI()
        {

            EditorGUILayout.BeginVertical();

            origin = EditorGUILayout.Vector3Field("Spawn Point", origin);
            offset = EditorGUILayout.Vector3Field("Grid Offeset", origin);
            unitSize = EditorGUILayout.Slider("Tile Size: ", unitSize, 0, 100);
            size = EditorGUILayout.Vector2Field("Grid Dimension:", size);
            

            if(GUILayout.Button("Generate Grid"))
            {

                var grid = MapGenerator.CreateGrid(origin, offset, 0.1f, size, (GameObject)Resources.Load("Prefabs/DefaultTile"));
                GridManager.RegisterGrid(ref grid);

                var data = ScriptableObject.CreateInstance<GridLayout>();
                data.origin = origin;
                data.offset = offset;
                data.size = size;
                data.name = name = "Test Grid";


                AssetDatabase.CreateAsset(data,"ToolEditor/New Grid.asset");
                AssetDatabase.SaveAssets();
                EditorUtility.FocusProjectWindow();
            }
            EditorGUILayout.EndVertical();

            LayoutWindow();
            TitleArea();
        }

        void LayoutWindow()
        {
            rectTitle.x = 0;
            rectTitle.y = 10;
            rectTitle.width = Screen.width;
            rectTitle.height = Screen.height / 4f;
           // GUI.DrawTexture(rectTitle, title);
        }

        void DrawTextureOnEnable()
        {
            title = Resources.Load<Texture2D>("Tex/White");
        }

        void TitleArea()
        {
            GUILayout.BeginArea(rectTitle);
            GUILayout.Label("Grid Editor", EditorStyles.boldLabel);
            GUILayout.EndArea();
        }
    }

    public class OptionJustForFunArea : EditorWindow
    {
        static OptionJustForFunArea windows;

        public static void OpenWindows()
        {
            windows = (OptionJustForFunArea)GetWindow(typeof(OptionJustForFunArea));
            windows.minSize = new Vector3(200, 250);
            windows.Show();
        }
    }
}
