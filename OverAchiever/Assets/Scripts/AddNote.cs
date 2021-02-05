using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AddNote : MonoBehaviour {
public GameObject canvas;
public GameObject button;

    void Start () {
        GameObject newCanvas = Instantiate(canvas) as GameObject;
        GameObject newButton = Instantiate(button) as GameObject;
        newButton.transform.SetParent(newCanvas.transform, false);
    }
}