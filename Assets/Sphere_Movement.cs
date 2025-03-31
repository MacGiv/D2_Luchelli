using Unity.VisualScripting;
using UnityEngine;

public class Sphere_Movement : MonoBehaviour
{

    [SerializeField] int speed = 100;

    void Update()
    {
        SphereCollider sphereCollider = GetComponent<SphereCollider>();
        if (sphereCollider)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("COLISIONE CON: " + collision.gameObject.name);
        //for (int i = 0; i < collision.gameObject.GetComponentCount(); i++)
        //{
        //    
        //}
        speed *= -1;
    }
}
