using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tornado : MonoBehaviour
{
    public float maxSize = 3;
    float size;

	// Update is called once per frame
	void Update ()
    {
        ParticleSystem tornado = GetComponent<ParticleSystem>();

	    if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ViewportPointToRay(Camera.main.ScreenToViewportPoint(Input.mousePosition));
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                transform.position = hit.point;
            }

            tornado.Play();
        }
        else if (Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ViewportPointToRay(Camera.main.ScreenToViewportPoint(Input.mousePosition));
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                transform.position = Vector3.Lerp(transform.position, hit.point, Time.deltaTime / size * 2);
            }

            size = Mathf.Min(size + Time.deltaTime, maxSize);
            
            ParticleSystem.ShapeModule shape = tornado.shape;
            shape.radius = size / 2;
            shape.length = size * 2.5f;

            ParticleSystem.EmissionModule emission = tornado.emission;
            emission.rateOverTimeMultiplier = 10 + size * size * size;

            Collider[] colliders = Physics.OverlapSphere(transform.position, size);

            foreach (Collider c in colliders)
            {
                if (c.GetComponent<Rigidbody>() != null)
                    c.GetComponent<Rigidbody>().AddExplosionForce(size * size, transform.position, size, 0, ForceMode.Force);
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            tornado.Stop();
            size = 0;

            ParticleSystem.ShapeModule shape = tornado.shape;
            shape.radius = 0;
            shape.length = 0;

            ParticleSystem.EmissionModule emission = tornado.emission;
            emission.rateOverTimeMultiplier = 10;
        }
	}

    //void OnDrawGizmos()
    //{
    //    Gizmos.color = Color.red;
    //    Gizmos.DrawSphere(this.transform.position, size);
    //}
}
