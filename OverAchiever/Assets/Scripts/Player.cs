using UnityEngine;

public class Player: MonoBehaviour{
    public void ButtonPressed(){
        XPManager.instance.AddXP(10);
    }

    public void QuitGame(){
        Application.Quit();
        Debug.Log("QUIT GAME!!!");
    }

}