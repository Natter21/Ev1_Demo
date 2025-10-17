using UnityEngine;
using TMPro;  // Importa TextMeshPro si usas ese

public class ControladorPlayer : MonoBehaviour
{
    public int contadorGorros = 0;  // Contador de gorros
    public TextMeshProUGUI contadorTexto;  // Referencia al texto de la UI

    void Start()
    {
        // Inicializa el texto al empezar (puedes dejarlo vacío si lo haces desde el Inspector)
        ActualizarContadorTexto();
    }

    // Llamado por el script del gorro cuando se recoge un gorro
    public void RecogerGorro()
    {
        contadorGorros++;  // Aumenta el contador de gorros
        ActualizarContadorTexto();  // Actualiza el texto de la UI
    }

    void ActualizarContadorTexto()
    {
        contadorTexto.text = "Gorros: " + contadorGorros.ToString();  // Muestra el contador
    }
}
