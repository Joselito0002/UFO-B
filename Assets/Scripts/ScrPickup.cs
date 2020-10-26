using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrPickup : MonoBehaviour
{
    [SerializeField]
    int velGir = 3;

    public int valor = 1; 

    // Start is called before the first frame update
    void Awake()
    {
        ScrControlGame.pickups++;
        ScrControlGame.pickupsRestant++;
    }

    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime (grados * segundo)
        transform.Rotate(0, 0, velGir * Time.deltaTime);
    }
}
