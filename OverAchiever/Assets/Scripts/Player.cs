using UnityEngine;

public class Player: MonoBehaviour{

    public bool fileUploaded = false;
    public bool fileUploaded2 = false;
    public bool submit = false;

    public int i=0,j=0;

    public void ButtonPressed(){
        if(fileUploaded){
            while(i<=1){
                XPManager.instance.AddXP(10);
                i++;
            }
            
        }
  
        else
            Debug.Log("Please select the file");
    }

        public void ButtonPressed2(){
        if(fileUploaded2){
            while(j<=1){
                XPManager.instance.AddXP(10);
                j++;
            }
            
        }
  
        else
            Debug.Log("Please select the file");
    }

    public void ClickedUpload(){
        fileUploaded = true;
    }
    public void ClickedUpload2(){
        fileUploaded2 = true;
    }

    public void QuitGame(){
        Application.Quit();
        Debug.Log("QUIT GAME!!!");
    }

}