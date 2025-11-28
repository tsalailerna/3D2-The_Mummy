using UnityEngine;
using UnityEngine.UI;

public class Script_Countdown : MonoBehaviour
{
    public float time_countdown;
    public Text text_screen;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        time_countdown = 10;
        
    }

    // Update is called once per frame
    void Update()
    {

        time_countdown -= Time.deltaTime;

        text_screen.text = time_countdown.ToString("F2");

        if(time_countdown <= 0){

            text_screen.text = "YOU LOSE";
        }

        
    }

    public void SumarTiempo(){

        time_countdown += 3;
    }

}
