using UnityEngine;
using System.Collections;


public class Coin_Script : MonoBehaviour
{
    public Color c;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        c = GetComponent<Renderer>().material.color;
        //Debug.Log(GetComponent<Renderer>().material.color.a);

        //other.gameObject.GetComponent<AudioSource>().Play();
        //    other.gameObject.GetComponent<MeshRenderer>().enabled = false;
        //    Destroy(other.gameObject,2);
        
    }

    // Update is called once per frame
    void Update()
    {
                transform.Rotate(0,0,0.3f);

    }

    void OnTriggerEnter(Collider col){

        if(col.gameObject.name == "Player"){

            StartCoroutine(nameof(Desapareixe));

        }
    }

    IEnumerator Desapareixe(){
        GetComponent<AudioSource>().Play();

        for(float i = 1; i>0 ; i -= Time.deltaTime){

            c.a = i;

            GetComponent<Renderer>().material.color = c;
            Debug.Log(i);
            yield return null;
        }
        Destroy(gameObject);


    }
}

