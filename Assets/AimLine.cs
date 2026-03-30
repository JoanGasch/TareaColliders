using UnityEngine;

public class AimLine : MonoBehaviour
{
    public LineRenderer line;
    public BolaController lineController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (lineController.lanzada)
        {
            line.enabled = false;
        }
        else
        {
            line.enabled = true;
            Vector3 start = transform.position;
            Vector3 end = start + transform.forward * 20f;
            line.SetPosition(0, start);
            line.SetPosition(1, end);
        }
    }
}
