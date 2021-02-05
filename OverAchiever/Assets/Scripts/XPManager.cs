using UnityEngine;
using TMPro;
public class XPManager : MonoBehaviour
{
    public TextMeshProUGUI currentXPText, levelText; // , targetXPtext;
    public int currentXP, targetXP, level;

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

        while(currentXP >= targetXP){
            currentXP = currentXP - targetXP;
            level++;
            levelText.text ="Level " + level.ToString();
            //targetXPtext.text = targetXP.ToString();
        }

        currentXPText.text = currentXP.ToString()+ " xp";
    }
}
