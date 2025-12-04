using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class Script_Spawn_Enemy : MonoBehaviour
{
    public GameObject enemy;
    public int dano_recivido;
    public int i;
    public Text texto_pantalla;
    void Start()
    {
        InvokeRepeating(nameof(Espauner_enemi),3,5);        
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K)){
            CancelInvoke();
        }

        if(Input.GetKeyDown(KeyCode.H)){
            StartCoroutine(nameof(Contar_Numeros));
        }
        texto_pantalla.text = i.ToString();
    }
    public void Espauner_enemi(){

        Instantiate(enemy,transform.position, Quaternion.identity);
    }
    public IEnumerator Contar_Numeros(){
        while(i<dano_recivido){
            Debug.Log(dano_recivido);
            yield return new WaitForSeconds(0.01f);
            i++;
        }
        if(dano_recivido>50){
            texto_pantalla.transform.localScale *= 2;
        }

        yield return new WaitForSeconds(2);

        Destroy(texto_pantalla.gameObject);
        
    }
}
