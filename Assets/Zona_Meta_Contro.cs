using UnityEngine;

public class Zona_Meta_Contro : MonoBehaviour
{
    // Evento cuando el jugador entra en la zona
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))  // Asegúrate de que el jugador tenga el tag "Player"
        {
            // Aquí puedes agregar la lógica para lo que sucede cuando el jugador llega a la meta
            Debug.Log("¡Meta alcanzada!");
            // También puedes agregar la lógica para finalizar el nivel, mostrar un mensaje, etc.
        }
    }
}




