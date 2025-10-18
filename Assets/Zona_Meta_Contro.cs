using UnityEngine;

public class Zona_Meta_Contro : MonoBehaviour
{
    // jugador en la meta
    public AudioClip sonidoDeLaMeta; // Clip de audio para la meta
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  
        {

            Debug.Log("¡HAZ LLEGADO A LA META!");
            
            if (sonidoDeLaMeta != null)
                AudioSource.PlayClipAtPoint(sonidoDeLaMeta, transform.position, 1f);
            
        }
    }
}




