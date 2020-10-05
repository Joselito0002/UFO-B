using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrPlayer : MonoBehaviour
{
    [SerializeField]
    float velocitat=3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x, y;  //Para leer el gamepad
        x = Input.GetAxis("Horizontal"); //Lectura Horizontal
        y = Input.GetAxis("Vertical");  //Lectura Vertical
        //print("Horizontal: " + y + " / Vertical: " + y);
        transform.Translate(x * Time.deltaTime * velocitat, y * Time.deltaTime * velocitat, 0);
        
    }
}
