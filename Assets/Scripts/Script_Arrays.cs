using UnityEngine;
using UnityEngine.UI;


public class Script_Arrays : MonoBehaviour
{
    public int[] numeros;
    public string[] palabras;
    public Text text_screen;
    public string chosen_word;

    void Start()
    {
        
        //Utilitzar array i combinal entre si
        numeros[0] = numeros[1] + numeros[2];
        Debug.Log("El array de palabras tiene " + palabras.Length + " slots");
        // Seleccionar una paraula random dins de l'Array de "palabras" i guardarho en una variable
        chosen_word = palabras[Random.Range(0,palabras.Length)];

        text_screen.text = chosen_word;

        /* deletrejar principi a fi
        for(int i = 0 ; i < chosen_word.Length ; i++){

            Debug.Log(chosen_word[i]);
        }*/

        for(int i = chosen_word.Length ; i > 0 ; i--){
                
                Debug.Log(chosen_word[i-1]);
        }

        

        /*
        Debug.Log(chosen_word[0]);
        Debug.Log(chosen_word[1]);
        Debug.Log(chosen_word[2]);
        Debug.Log(chosen_word[3]);
        Debug.Log(chosen_word[4]);
        Debug.Log(chosen_word[5]);
       */
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
