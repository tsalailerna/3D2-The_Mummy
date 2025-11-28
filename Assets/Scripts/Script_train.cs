using UnityEngine;

public class Script_train : MonoBehaviour
{
    public float time_pass;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < 0){
        transform.Translate(0.5f,0,0);
        }
        else{
            time_pass += Time.deltaTime;
        }

        if(time_pass >= 5){
        transform.Translate(0.5f,0,0);

        }

    }
}
