using UnityEngine;

public class Enemy_Random_Move_Script : MonoBehaviour
{
    public int vides;
    public float velocidad;
    public float time_rot;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        vides = 3;
  
    }

    // Update is called once per frame
    void Update()
    {
        if(vides <= 0){
            Destroy(gameObject);
        }
        GetComponent<Rigidbody>().linearVelocity = transform.forward * velocidad;
        time_rot += Time.deltaTime;

        if(time_rot >= 2){
            transform.Rotate(0,Random.Range(45,135),0);
            time_rot=0;
        }

    }

    void OnCollisionEnter(Collision col){

        if(col.gameObject.tag == "bullet"){
            vides--;
            Destroy(col.gameObject);

        }
    }
}
