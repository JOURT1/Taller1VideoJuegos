using UnityEngine;

public class GeneradorRobot : MonoBehaviour
{
    void Start()
    {
        Vector3 basePos = transform.position;
        Quaternion baseRot = Quaternion.Euler(0, -90, 0);
        float escala = 1f;

        GameObject robot = new GameObject("RobotCompleto");

        // 🧠 Cabeza
        GameObject cabeza = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cabeza.transform.position = basePos + baseRot * new Vector3(0, 5.5f * escala, 0);
        cabeza.transform.localScale = new Vector3(2, 2, 2) * escala;
        cabeza.GetComponent<Renderer>().material.color = new Color(0.7f, 0.7f, 0.8f);
        cabeza.transform.parent = robot.transform;

        // 👀 Ojos
        GameObject ojoIzq = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        ojoIzq.transform.position = cabeza.transform.position + new Vector3(-0.5f * escala, 0.2f * escala, 1f * escala);
        ojoIzq.transform.localScale = Vector3.one * 0.4f * escala;
        ojoIzq.GetComponent<Renderer>().material.color = Color.red;
        ojoIzq.transform.parent = robot.transform;

        GameObject ojoDer = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        ojoDer.transform.position = cabeza.transform.position + new Vector3(0.5f * escala, 0.2f * escala, 1f * escala);
        ojoDer.transform.localScale = Vector3.one * 0.4f * escala;
        ojoDer.GetComponent<Renderer>().material.color = Color.red;
        ojoDer.transform.parent = robot.transform;

        // 📦 Torso
        GameObject torso = GameObject.CreatePrimitive(PrimitiveType.Cube);
        torso.transform.position = basePos + baseRot * new Vector3(0, 3f * escala, 0);
        torso.transform.localScale = new Vector3(3, 4, 1.5f) * escala;
        torso.GetComponent<Renderer>().material.color = new Color(0.4f, 0.6f, 0.9f);
        torso.transform.parent = robot.transform;

        // 🤖 Brazos
        GameObject brazoIzq = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        brazoIzq.transform.position = basePos + baseRot * new Vector3(-2.2f * escala, 3.5f * escala, 0);
        brazoIzq.transform.localScale = new Vector3(0.5f, 2f, 0.5f) * escala;
        brazoIzq.transform.rotation = Quaternion.Euler(90, 0, 0);
        brazoIzq.GetComponent<Renderer>().material.color = Color.gray;
        brazoIzq.transform.parent = robot.transform;

        GameObject brazoDer = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        brazoDer.transform.position = basePos + baseRot * new Vector3(2.2f * escala, 3.5f * escala, 0);
        brazoDer.transform.localScale = new Vector3(0.5f, 2f, 0.5f) * escala;
        brazoDer.transform.rotation = Quaternion.Euler(90, 0, 0);
        brazoDer.GetComponent<Renderer>().material.color = Color.gray;
        brazoDer.transform.parent = robot.transform;

        // 🦿 Piernas
        GameObject piernaIzq = GameObject.CreatePrimitive(PrimitiveType.Cube);
        piernaIzq.transform.position = basePos + baseRot * new Vector3(-0.7f * escala, 0.75f * escala, 0);
        piernaIzq.transform.localScale = new Vector3(1f, 1.5f, 1f) * escala;
        piernaIzq.GetComponent<Renderer>().material.color = new Color(0.2f, 0.2f, 0.2f);
        piernaIzq.transform.parent = robot.transform;

        GameObject piernaDer = GameObject.CreatePrimitive(PrimitiveType.Cube);
        piernaDer.transform.position = basePos + baseRot * new Vector3(0.7f * escala, 0.75f * escala, 0);
        piernaDer.transform.localScale = new Vector3(1f, 1.5f, 1f) * escala;
        piernaDer.GetComponent<Renderer>().material.color = new Color(0.2f, 0.2f, 0.2f);
        piernaDer.transform.parent = robot.transform;

        // ⚙️ Antena
        GameObject antena = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        antena.transform.position = cabeza.transform.position + new Vector3(0, 1.4f * escala, 0);
        antena.transform.localScale = new Vector3(0.1f, 1f, 0.1f) * escala;
        antena.GetComponent<Renderer>().material.color = Color.black;
        antena.transform.parent = robot.transform;

        GameObject esferaAntena = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        esferaAntena.transform.position = antena.transform.position + new Vector3(0, 0.75f * escala, 0);
        esferaAntena.transform.localScale = Vector3.one * 0.3f * escala;
        esferaAntena.GetComponent<Renderer>().material.color = Color.red;
        esferaAntena.transform.parent = robot.transform;
    }
}
