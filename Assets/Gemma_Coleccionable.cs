using UnityEngine;

public class GemaColeccionable : MonoBehaviour
{
    public int valorGema = 1;
    public AudioClip sonidoRecoleccion;

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        // Suma puntos
        var player = other.GetComponent<ControladorPlayer>();
        if (player) player.RecogerGema(valorGema);

        // Reproduce el sonido aunque destruyas la gema
        if (sonidoRecoleccion != null)
            AudioSource.PlayClipAtPoint(sonidoRecoleccion, transform.position, 1f);

        // Desaparece la gema
        Destroy(gameObject);
    }
}

