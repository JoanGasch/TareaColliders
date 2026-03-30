using Unity.VisualScripting;
using UnityEngine;

public class BolaController : MonoBehaviour
{
    public float fuerza = 3500f;
    public Transform puntoInicial;
    private Rigidbody rb;
    public bool lanzada = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Reiniciar();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && !lanzada)
        {
            rb.AddForce(transform.forward * fuerza);
            lanzada = true;
        }

        if (!lanzada)
        {
            float h = Input.GetAxis("Horizontal");
            transform.Rotate(Vector3.up * h * 100f * Time.deltaTime);
        }

        if (transform.position.y < -5f)
        {
            Reiniciar();
        }
    }
    
    void Reiniciar()
    {
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        transform.position = puntoInicial.position;
        transform.rotation = puntoInicial.rotation;
        lanzada = false;
    }
}
