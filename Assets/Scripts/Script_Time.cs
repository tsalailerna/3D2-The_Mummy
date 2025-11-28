using UnityEngine;
using UnityEngine.UI;

public class Script_Time : MonoBehaviour
{
    public float tiempo_pasado;
    public bool activar_tiempo;
    public Text text_screen;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        text_screen.text = tiempo_pasado.ToString("F1");


        if(activar_tiempo){
        tiempo_pasado +=  Time.deltaTime;
        }

        if(tiempo_pasado>3){
            tiempo_pasado = 0;
            activar_tiempo = false;

        }


        //Debug.Log(Time.time);

    }

    public void OnClickStartTime(){

        if(activar_tiempo == false){
        Debug.Log("TREMENDO ATACK");
        }
        activar_tiempo = true;

    }
}
