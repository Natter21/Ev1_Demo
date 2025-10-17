using System.Collections.Generic;
using UnityEngine;

public class GorroSpawner : MonoBehaviour
{
    public GameObject gorroObject;  // Prefab del gorro
    public List<Transform> spawnPoints;  // Puntos de spawn para los gorros
    public int cantidadGorros = 10;  // Total de gorros a generar

    public List<GameObject> gorrosCreados;  // Lista de gorros creados

    public List<int> indexUtilizados;  // Índices de spawn utilizados

    // Start is called once before the first execution of Update
    void Start()
    {
        gorrosCreados = new List<GameObject>();
        indexUtilizados = new List<int>();

        for (int i = 0; i < cantidadGorros; i++)
        {
            SpawnGorro("Gorro_" + i);  // Instanciamos los gorros con un nombre único
        }
    }

    // Método para instanciar el gorro
    public void SpawnGorro(string nombreNuevo)
    {
        int randomIndex = Random.Range(0, spawnPoints.Count);  // Selección aleatoria de un punto de spawn

        // Posición de spawn
        Vector3 posicionSpawn = spawnPoints[randomIndex].position;

        // Instanciar el gorro
        GameObject nuevoGorro = Instantiate(gorroObject, posicionSpawn, Quaternion.identity);
        nuevoGorro.name = nombreNuevo;

        // Añadir a la lista de gorros creados
        gorrosCreados.Add(nuevoGorro);

        Debug.Log("Gorro creado: " + nombreNuevo);
    }
}
