using UnityEngine;

public class Script_Enemigos : MonoBehaviour
{

    public int vides;
    public float velocidad;
    public GameObject follow_point;
    public GameObject[] npc_Points;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        vides = 3;
        follow_point.transform.position = npc_Points[Random.Range(0,npc_Points.Length)].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(vides <= 0){

            Destroy(gameObject);
        }

        transform.LookAt(follow_point.transform.position);

        GetComponent<Rigidbody>().linearVelocity = transform.forward * velocidad;
        
    }

    void OnCollisionEnter(Collision col){

        if(col.gameObject.tag == "bullet"){
            vides--;
            Destroy(col.gameObject);


        }
    }

    void OnTriggerStay(Collider col){

        if(col.gameObject.tag == "NPC_Positions"){

        follow_point.transform.position = npc_Points[Random.Range(0,npc_Points.Length)].transform.position;


        }

        if(col.gameObject.tag == "Player"){
            follow_point.transform.position = col.gameObject.transform.position;    
        }
    }

    void OnTriggerExit(Collider col){

        if(col.gameObject.tag == "Player"){
            follow_point.transform.position = npc_Points[Random.Range(0,npc_Points.Length)].transform.position;    
        }
    }



    
    
}
