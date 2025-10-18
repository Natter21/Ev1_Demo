using UnityEngine;

public class GemaColeccionable : MonoBehaviour
{
    public int valorGema = 1;  // El valor de la gema (puedes asignar puntos aquí)

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) // Verifica si el objeto que entra es el jugador
        {
            // Obtén el script del jugador (ControladorPlayer)
            ControladorPlayer controladorPlayer = other.gameObject.GetComponent<ControladorPlayer>();

            if (controladorPlayer != null)
            {
                controladorPlayer.RecogerGema(valorGema);  // Llamamos al método para agregar puntos
            }

            // Desactiva el collider para que no pueda ser recogida nuevamente
            GetComponent<Collider>().enabled = false;

            // Destruye la gema después de ser recolectada
            Destroy(gameObject);
        }
    }
}
