using UnityEngine;
using UnityEngine.UI;

public class Scripts_GetComp : MonoBehaviour
{

    public Text texto_pantalla;
    public GameObject[] elemento_3D;
    public int numero_random;
    public float tiempo_pasado;
    public bool activar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log(elemento_3D.tag);
        //Debug.Log(elemento_3D.layer);
        //Debug.Log(elemento_3D.transform.position);

        //elemento_3D.GetComponent<Rigidbody>().mass = 10;
        
        //elemento_3D[Random.Range(0,elemento_3D.Length)].GetComponent<Rigidbody>().isKinematic = false;
    }

    // Update is called once per frame
    void Update()
    {

        if(activar){
           tiempo_pasado += Time.deltaTime; 
        }

        if(tiempo_pasado>3){
        elemento_3D[numero_random].GetComponent<Rigidbody>().isKinematic = false;


        }


        
    }

    public void AlClickar(){
        activar = true;
        numero_random = Random.Range(0, elemento_3D.Length);
        texto_pantalla.text = "El cubo seleccionat es " + numero_random;


    }
}
