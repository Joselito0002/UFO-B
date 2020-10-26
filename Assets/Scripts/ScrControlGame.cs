using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrControlGame : MonoBehaviour
{
    public static int punts = 0; //puntuació, llegir les boles que es menja(desapareix) Només hi ha 1 per tot el joc.
    public static int pickups = 0;
    public static int pickupsRestant = 0;
    public static float temps = 0;

    private void Update()
    {
        if (ScrControlGame.pickups == 0)
        {
            JuegoAcabado();
        }

        void JuegoAcabado()
        {
            print("S'ha acabat!");
        }
    }
}
