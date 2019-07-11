using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombs : MonoBehaviour
{
    public Rigidbody HipReference = null;

    [Header("Explosion Parameters")]
    [SerializeField] private float Magnitude = 100f;
    [SerializeField] private float Radius = 50f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Explode();
        }
    }

    private void Explode()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ViewportPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 100f, 8))
        {
            HipReference.AddExplosionForce(Magnitude, hit.point, Radius);
        }
    }
}
