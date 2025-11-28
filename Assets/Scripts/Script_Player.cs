using UnityEngine;

public class Script_Player : MonoBehaviour
{
    public int vida;
    public int points;

    public float energy;
    public float sens_jump;

    public bool direction;

    public float sens_horitzontal;
    public float sens_vertical;
    public float sens_mouseX;
    public float sens_mouseY;

    public GameObject cam;

    public float time_flash;
    public bool activar_flash;

    public GameObject bala;

    public GameObject objeto_destruccion;

    public int max_ammo;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)){
            Destroy(objeto_destruccion);

        }



        sens_horitzontal = Input.GetAxis("Horizontal");
        sens_vertical = Input.GetAxis("Vertical");

        transform.Translate(sens_horitzontal * 0.05f,0,sens_vertical* 0.05f); 

        sens_mouseX = Input.GetAxis("Mouse X");
        sens_mouseY = Input.GetAxis("Mouse Y");

        transform.Rotate(0,sens_mouseX,0);
        cam.transform.Rotate(sens_mouseY * (-1),0,0);

        if(Input.GetKeyDown(KeyCode.Space)){
            energy = 0;
        }

        if(Input.GetKey(KeyCode.Space)){
            energy += Time.deltaTime;
        }

        if(Input.GetKeyUp(KeyCode.Space)){
            Debug.Log(energy);
            GetComponent<Rigidbody>().AddForce(0,energy*sens_jump,0);
        }


        if(activar_flash == false){
        time_flash += Time.deltaTime;
        }

        if(time_flash >= 3){
            activar_flash=true;
            time_flash = 0;
        }


        if(Input.GetKeyDown(KeyCode.F) && activar_flash == true){
            transform.Translate(0,0,3);
            activar_flash = false;

        }


        if(Input.GetButtonDown("Fire1") && max_ammo > 0){
            max_ammo = max_ammo -1;
            
            Debug.Log("Disparo");

            GameObject clon_bala;
            clon_bala = Instantiate(bala ,cam.transform.position + cam.transform.forward * 2, Quaternion.identity);
            clon_bala.GetComponent<Rigidbody>().AddForce(cam.transform.forward*500);
            Destroy(clon_bala, 3);
        }

        if(Input.GetKeyDown(KeyCode.R)){

            for(int i = max_ammo ; i < 5 ; i++){

                max_ammo++;

                Debug.Log("He recargado la bala: " + max_ammo);

            }


        }


        /*
        if(Input.GetButtonDown("Fire2")){
            transform.Translate(0,0,-1);

            direction = false;
        }*/


        
    }

    void OnCollisionEnter(Collision col){

        Debug.Log(col.gameObject.name);

        
        if(col.gameObject.tag == "damage"){
            vida--;
        }

        
    }

    void OnTriggerStay(Collider other){

        if(other.gameObject.tag == "health"){
            vida++;
        }

        if(other.gameObject.tag == "money"){
            points++;

            other.gameObject.GetComponent<AudioSource>().Play();
            other.gameObject.GetComponent<MeshRenderer>().enabled = false;
            Destroy(other.gameObject,2);

        }

    }


}



