using UnityEngine;

public class Zona_Meta_Contro : MonoBehaviour
{
    // jugador en la meta
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  
        {
            
            Debug.Log("¡Meta alcanzada!");
            
        }
    }
}




