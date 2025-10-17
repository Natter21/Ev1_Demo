using UnityEngine;

public class GorroColeccionable : MonoBehaviour
{
    public Animator animatorGorro;
    public AudioSource audio;
    public int valorGorro = 1;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ControladorPlayer controladorPlayer = other.gameObject.GetComponent<ControladorPlayer>();

            // Llamamos al método RecogerGorro para actualizar el contador
            controladorPlayer.RecogerGorro();

            // Desactivamos el collider
            this.GetComponent<Collider>().enabled = false;

            // Activamos la animación del gorro
            animatorGorro.SetTrigger("activarGorro");

            // Reproducimos el sonido
            audio.Play();

            // Desactivamos el objeto
            Destroy(gameObject);

        }
    }
}
