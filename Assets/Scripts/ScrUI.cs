using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


/// <summary>
/// DESCRIPCIÓ:
///         Script utilitzat per gestionar les accions relacionades amb la UI
/// AUTOR: Mathias Miranda
/// DATA:   26/10/20
/// VERSIÓ: 1.0
/// CONTROL DE VERSIONS
///         1.0: primera versió. Mostra puntuació
/// </summary>
/// 

public class ScrUI : MonoBehaviour
{
    [SerializeField]
    Text puntuacio;  //accedir a l'element del UI
    [SerializeField]
    Text pickupsRestant;
    Text temps;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        puntuacio.text = "Puntuació: " + ScrControlGame.punts;
        pickupsRestant.text = "Pickups: " + ScrControlGame.pickupsRestant;
    }

}
