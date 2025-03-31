using UnityEngine;

public class GeneradorEdificio : MonoBehaviour
{
    void Start()
    {
        // 📍 Configuración base: posición, rotación, escala general
        Vector3 basePos = transform.position;
        Quaternion baseRot = Quaternion.Euler(0, 180, 0);
        float escala = 1.5f;

        // 🧱 Objeto principal (padre)
        GameObject edificio = new GameObject("EdificioCompleto");

        // 🏙️ Pisos (5 pisos)
        int cantidadPisos = 5;
        for (int i = 0; i < cantidadPisos; i++)
        {
            GameObject piso = GameObject.CreatePrimitive(PrimitiveType.Cube);
            piso.transform.position = basePos + baseRot * new Vector3(0, (i * 3f + 1.5f) * escala, 0);
            piso.transform.localScale = new Vector3(8, 3, 8) * escala;
            piso.GetComponent<Renderer>().material.color = new Color(0.7f, 0.7f, 0.8f);
            piso.transform.rotation = baseRot;
            piso.transform.parent = edificio.transform;
        }

        // 🚪 Puerta principal (solo planta baja)
        GameObject puerta = GameObject.CreatePrimitive(PrimitiveType.Cube);
        puerta.transform.position = basePos + baseRot * new Vector3(0, 1.2f * escala, 4.05f * escala);
        puerta.transform.localScale = new Vector3(1.5f, 2.5f, 0.2f) * escala;
        puerta.GetComponent<Renderer>().material.color = new Color(0.4f, 0.2f, 0.1f);
        puerta.transform.rotation = baseRot;
        puerta.transform.parent = edificio.transform;

        // 🪟 Ventanas por piso
        for (int i = 0; i < cantidadPisos; i++)
        {
            float yAltura = (i * 3f + 2f) * escala;

            GameObject ventana1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            ventana1.transform.position = basePos + baseRot * new Vector3(-2.5f * escala, yAltura, 4.05f * escala);
            ventana1.transform.localScale = new Vector3(1f, 1f, 0.1f) * escala;
            ventana1.GetComponent<Renderer>().material.color = Color.cyan;
            ventana1.transform.rotation = baseRot;
            ventana1.transform.parent = edificio.transform;

            GameObject ventana2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            ventana2.transform.position = basePos + baseRot * new Vector3(2.5f * escala, yAltura, 4.05f * escala);
            ventana2.transform.localScale = new Vector3(1f, 1f, 0.1f) * escala;
            ventana2.GetComponent<Renderer>().material.color = Color.cyan;
            ventana2.transform.rotation = baseRot;
            ventana2.transform.parent = edificio.transform;
        }

        // 🌐 Antena en el techo
        GameObject antena = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        antena.transform.position = basePos + baseRot * new Vector3(0, (cantidadPisos * 3f + 2f) * escala, 0);
        antena.transform.localScale = new Vector3(0.3f, 2.5f, 0.3f) * escala;
        antena.GetComponent<Renderer>().material.color = Color.black;
        antena.transform.rotation = baseRot;
        antena.transform.parent = edificio.transform;
    }
}
