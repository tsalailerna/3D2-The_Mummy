using UnityEngine;

public class Enemy_Clon_Script : MonoBehaviour
{
    public GameObject player_;
    public float dt;
    public int vides;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player_ = GameObject.Find("Player");
        vides = 3; 
        
    }

    // Update is called once per frame
    void Update()
    {
        dt = Time.deltaTime;

        if(vides <= 0){

            Destroy(gameObject);
        }

        transform.LookAt(player_.transform.position);

        transform.Translate(0,0,1 * dt * 3);
        
    }

    void OnCollisionEnter(Collision col){

        if(col.gameObject.tag == "bullet"){
            vides--;
            Destroy(col.gameObject);


        }
    }
}
