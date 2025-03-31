using UnityEngine;

public class NPCSeguidor : MonoBehaviour
{
    public Transform objetivo;     // El jugador u objeto a seguir
    public float velocidad = 2f;   // Velocidad de movimiento
    public float distanciaMinima = 2f;  // Se detiene si está muy cerca

    void Update()
    {
        if (objetivo == null) return;

        // Dirección hacia el jugador
        Vector3 direccion = objetivo.position - transform.position;
        direccion.y = 0; // Evita que rote verticalmente

        // Solo si está lejos
        if (direccion.magnitude > distanciaMinima)
        {
            // Rotar hacia el jugador
            Quaternion rotacion = Quaternion.LookRotation(direccion);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotacion, Time.deltaTime * 2f);

            // Moverse hacia el jugador
            transform.position += transform.forward * velocidad * Time.deltaTime;
        }
    }
}
