using UnityEngine;

public class Script_Array_HighMove : MonoBehaviour
{

    public GameObject[] posiciones;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        for(int i = 0 ; i<posiciones.Length ; i++){
            
            if(transform.position.y < posiciones[i].transform.position.y){
                transform.position = posiciones[i].transform.position;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
