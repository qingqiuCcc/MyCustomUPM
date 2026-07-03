using UnityEditor;
using UnityEngine;

public class MyEditor: EditorWindow
{
   [MenuItem("MyTools/MyEditor")]
   public static void ShowWindow()
   {
      GetWindow(typeof(MyEditor));
   }

   private void OnGUI()
   {
      if (GUILayout.Button("Print"))
      {
         Debug.Log("Button clicked! Hello from MyEditor.");
      }
   }
}
