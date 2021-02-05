using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Achievements : MonoBehaviour
{
    //XPManager _instance;
    public Image targetImage, homeworkHero, goodPun, scoreHero, perfectAttend;
    
    public int lvl;

    public void Start(){
        lvl = XPManager.instance.level;
    }
    
    public void change_color() 
    {
        targetImage.GetComponent<Image>().color = new Color32 (0,0,0,0);
    } 

    public void change_color1() 
    {
        homeworkHero.GetComponent<Image>().color = new Color32 (0,0,0,0);
    } 

    public void change_color2() 
    {
        goodPun.GetComponent<Image>().color = new Color32 (255,255,255,255);
    } 

    public void change_color3() 
    {
        scoreHero.GetComponent<Image>().color = new Color32 (255,255,255,255);
    } 

    public void change_color4() 
    {
        perfectAttend.GetComponent<Image>().color = new Color32 (255,255,255,255);
    }

    public void color(){
        for(int i = 0 ; i <= 5; i++)
        if(lvl == i){
            change_color1();
        }
        else if(lvl == i){
            change_color2();
        }
        else if(lvl == i){
            change_color3();
        }
        else if(lvl == i){
            change_color4();
        }
    }



}
