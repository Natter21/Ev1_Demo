using UnityEngine;
using TMPro;  // Importa TextMeshPro para el manejo de texto en la UI

public class ControladorPlayer : MonoBehaviour
{
    public int puntos = 0;  // Variable para almacenar los puntos obtenidos por las gemas
    public TextMeshProUGUI contadorPuntosTexto;  // Referencia al texto en la UI donde se mostrarán los puntos

    void Start()
    {
        // Inicializa el texto de los puntos cuando inicie el juego
        ActualizarContadorTexto();
    }

    // Este método será llamado desde el script de las gemas cuando se recoja una
    public void RecogerGema(int valorGema)
    {
        puntos += valorGema;  // Aumenta los puntos por la gema recolectada
        ActualizarContadorTexto();  // Actualiza el texto en la UI
    }

    // Actualiza el texto de los puntos en la pantalla
    void ActualizarContadorTexto()
    {
        contadorPuntosTexto.text = "Puntos: " + puntos.ToString();  // Muestra los puntos actuales
    }
}
