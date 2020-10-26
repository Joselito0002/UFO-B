using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrPlayer : MonoBehaviour
{

    [SerializeField]
    float fuerza = 10; 
    float x, y; //variables que guardan la lectura del teclado

    //Para acceder al componente Rigidbody2D(rb de rigidbody):
    Rigidbody2D rb; //Tipo nombre;
    ScrPickup scrP;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //apunta al component rigidbody del player
        
    }

    // Update is called once per frame
    void Update() //cada fotograma actualiza y hace lo que hemos escrito a continuacion, depende de la maquina (void Update)
    {
        /*float x, y;  //Para leer el gamepad*/
        x = Input.GetAxis("Horizontal"); //Lectura Horizontal
        y = Input.GetAxis("Vertical");  //Lectura Vertical
        //print("Horizontal: " + y + " / Vertical: " + y);
        /*transform.Translate(x * Time.deltaTime * velocitat, y * Time.deltaTime * velocitat, 0);*/
        
    }
    private void FixedUpdate() //cada tiempo, ex: cada decima de segundo hace lo que hemos escrito a continuacion, no depende de la maquina, no hace falta "deltaTime" (void FixedUpdate)
    {
        rb.AddForce(new Vector2(x*fuerza, y*fuerza));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        //if (collision.tag == "pickup") Destroy(collision.gameObject);
        if (collision.CompareTag("pickup"))
        {
            scrP = collision.GetComponent<ScrPickup>();
            ScrControlGame.punts += scrP.valor;
            ScrControlGame.pickupsRestant--;
            Destroy(collision.gameObject);
            ScrControlGame.pickups--;
            
            
        }
    }

}   
