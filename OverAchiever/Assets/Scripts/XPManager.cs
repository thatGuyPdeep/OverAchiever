using UnityEngine;
using TMPro;
public class XPManager : MonoBehaviour
{
    public TextMeshProUGUI currentXPText, levelText; // , targetXPtext;
    public int currentXP, targetXP, level, temp, temp1;

    public int achievements;

    public static XPManager instance;

    private void Awake(){
        if(instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    private void Start(){
        currentXPText.text = currentXP.ToString();
        //targetXPtext.text = targetXP.ToString();
        levelText.text = level.ToString();
    }

    public void AddXP(int xp){
        currentXP += xp;
        temp = currentXP;
        while(temp >= targetXP){
            temp = temp - targetXP;
            temp1 = temp;
            level++;
            levelText.text ="Level " + level.ToString();
            //targetXPtext.text = targetXP.ToString();
        }

        currentXP += temp1;

        currentXPText.text = currentXP.ToString()+ " xp";
    }

    public void XPBoost(int xp){
        currentXP += xp;
        temp = currentXP;
        while(temp >= targetXP){
            temp = temp - targetXP;
            temp1 = temp;
            level++;
            levelText.text ="Level " + level.ToString();
            //targetXPtext.text = targetXP.ToString();
        }
        
        

        currentXPText.text = currentXP.ToString()+ " xp";
    }
}
