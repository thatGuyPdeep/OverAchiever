using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class FileManager : MonoBehaviour
{
    string path;
    public void OpenExplorer(){
        path = EditorUtility.OpenFilePanel("","","");
    }
}
