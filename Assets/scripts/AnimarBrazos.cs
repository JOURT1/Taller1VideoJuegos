using UnityEngine;

public class AnimarBrazos : MonoBehaviour
{
    public Transform brazoIzquierdo;
    public Transform brazoDerecho;
    public float amplitud = 40f; // Grados de rotación
    public float velocidad = 2f; // Velocidad del movimiento

    private float tiempo;

    void Start()
    {
        // Puedes buscar automáticamente los huesos si conoces la jerarquía
        if (brazoIzquierdo == null)
            brazoIzquierdo = transform.Find("root/spine/upper_arm_L");

        if (brazoDerecho == null)
            brazoDerecho = transform.Find("root/spine/upper_arm_R");
    }

    // ⏱ Se ejecuta después de Update (ideal para rotaciones de huesos)
    void LateUpdate()
    {
        tiempo += Time.deltaTime * velocidad;
        float angulo = Mathf.Sin(tiempo) * amplitud;

        // 🔄 Probar otro eje: Z en lugar de X
        if (brazoIzquierdo != null)
            brazoIzquierdo.localRotation = Quaternion.Euler(0f, 0f, angulo);

        if (brazoDerecho != null)
            brazoDerecho.localRotation = Quaternion.Euler(0f, 0f, angulo);
    }
}
