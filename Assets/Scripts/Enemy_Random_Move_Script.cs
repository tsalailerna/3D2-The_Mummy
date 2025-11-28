using UnityEngine;

public class Enemy_Random_Move_Script : MonoBehaviour
{
    public int vides;
    public float velocidad;
    public float time_rot;
    public GameObject player_;
    public float distance;
    public bool me_mira;
    public Vector3 direccio;
    public float angle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        vides = 3;

        me_mira=false;

        player_ = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(vides <= 0){
            Destroy(gameObject);
        }
        GetComponent<Rigidbody>().linearVelocity = transform.forward * velocidad;

        distance = Vector3.Distance(transform.position, player_.transform.position);

        direccio = player_.transform.position - transform.position;
        angle = Vector3.Angle(direccio,transform.forward);

        if(distance<=7 && angle<=45){

            me_mira=true;
        }
        else{
            me_mira=false;
        }

        if(me_mira == false){
            time_rot += Time.deltaTime;

            if(time_rot >= 2){
                transform.Rotate(0,Random.Range(45,135),0);
                time_rot=0;
        }

        }
        else if(me_mira){
        transform.LookAt(player_.transform.position);
        }
        


    }

    void OnCollisionEnter(Collision col){

        if(col.gameObject.tag == "bullet"){
            vides--;
            Destroy(col.gameObject);

        }
    }
}
