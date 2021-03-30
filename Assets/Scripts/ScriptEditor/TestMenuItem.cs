using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class TestMenuItem : Editor
{
    [MenuItem("Cesto/Rigidbody/MyMenu")]
   private static void NewOption(MenuCommand menuCommand)
   {
        Rigidbody rb = menuCommand.context as Rigidbody;
   }


}
