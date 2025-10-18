using UnityEngine;
using TMPro;  // Importa TextMeshPro para el manejo de texto en la UI

public class ControladorPlayer : MonoBehaviour
{
    public int puntos = 0;  // puntos optenidos
    public TextMeshProUGUI contadorPuntosTexto;  // contador punto

    void Start()
    {
        
        ActualizarContadorTexto();
    }

    //sera llamda la gemma
    public void RecogerGema(int valorGema)
    {
        puntos += valorGema;  // se sumara los puntos recogido
        ActualizarContadorTexto();  // Actualiza el texto 
    }

    // Actualiza el texto de los puntos en la pantalla
    void ActualizarContadorTexto()
    {
        contadorPuntosTexto.text = "Puntos: " + puntos.ToString();  // Muestra los puntos actuales
    }
}
