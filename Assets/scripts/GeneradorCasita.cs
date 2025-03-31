using UnityEngine;

public class GeneradorCasita : MonoBehaviour
{
    void Start()
    {
        // 🧭 Usa directamente la posición, rotación y escala base
        Vector3 basePos = transform.position;
        Quaternion baseRot = Quaternion.Euler(0, 180, 0);
        float escala = 1f;

        // 🏠 Objeto vacío padre solo para organización
        GameObject casa = new GameObject("CasaCompleta");

        // BASE
        GameObject baseCasa = GameObject.CreatePrimitive(PrimitiveType.Cube);
        baseCasa.transform.position = basePos + baseRot * Vector3.up * escala * 1.5f;
        baseCasa.transform.localScale = new Vector3(6, 3, 6) * escala;
        baseCasa.transform.rotation = baseRot;
        baseCasa.GetComponent<Renderer>().material.color = new Color(0.9f, 0.8f, 0.6f);
        baseCasa.transform.parent = casa.transform;

        // TECHO
        GameObject techo = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        techo.transform.position = basePos + baseRot * Vector3.up * escala * 4f;
        techo.transform.localScale = new Vector3(6, 1, 6) * escala;
        techo.transform.rotation = baseRot;
        techo.GetComponent<Renderer>().material.color = new Color(0.5f, 0.1f, 0.1f);
        techo.transform.parent = casa.transform;

        // PUERTA
        GameObject puerta = GameObject.CreatePrimitive(PrimitiveType.Cube);
        puerta.transform.position = basePos + baseRot * (new Vector3(0, escala * 1f, escala * 3.05f));
        puerta.transform.localScale = new Vector3(1.2f, 2f, 0.1f) * escala;
        puerta.transform.rotation = baseRot;
        puerta.GetComponent<Renderer>().material.color = new Color(0.4f, 0.2f, 0f);
        puerta.transform.parent = casa.transform;

        // VENTANAS
        GameObject ventana1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        ventana1.transform.position = basePos + baseRot * new Vector3(-2f * escala, 2f * escala, 3.05f * escala);
        ventana1.transform.localScale = new Vector3(0.8f, 0.8f, 0.1f) * escala;
        ventana1.transform.rotation = baseRot;
        ventana1.GetComponent<Renderer>().material.color = Color.cyan;
        ventana1.transform.parent = casa.transform;

        GameObject ventana2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        ventana2.transform.position = basePos + baseRot * new Vector3(2f * escala, 2f * escala, 3.05f * escala);
        ventana2.transform.localScale = new Vector3(0.8f, 0.8f, 0.1f) * escala;
        ventana2.transform.rotation = baseRot;
        ventana2.GetComponent<Renderer>().material.color = Color.cyan;
        ventana2.transform.parent = casa.transform;

        // PISO
        GameObject piso = GameObject.CreatePrimitive(PrimitiveType.Cube);
        piso.transform.position = basePos;
        piso.transform.localScale = new Vector3(6.2f, 0.2f, 6.2f) * escala;
        piso.transform.rotation = baseRot;
        piso.GetComponent<Renderer>().material.color = Color.gray;
        piso.transform.parent = casa.transform;

        // CHIMENEA
        GameObject chimenea = GameObject.CreatePrimitive(PrimitiveType.Cube);
        chimenea.transform.position = basePos + baseRot * new Vector3(-2f * escala, 5f * escala, -2f * escala);
        chimenea.transform.localScale = new Vector3(0.5f, 2f, 0.5f) * escala;
        chimenea.transform.rotation = baseRot;
        chimenea.GetComponent<Renderer>().material.color = Color.black;
        chimenea.transform.parent = casa.transform;
    }
}
