using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private Transform target;
    public float speed = 50f;
    public GameObject impactEffect;
    public float explocion = 0f;
    public int damage = 30;

    public void Seek(Transform _target)
    {
        target = _target;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
        transform.LookAt(target);

    }

    void HitTarget()
    {
        GameObject effect = Instantiate(impactEffect, transform.position, transform.rotation);

        if (explocion > 0f)
        {
            Explode();
        } else
        {
            Damage(target);
        }
        Destroy(effect, 1f);
        Destroy(gameObject);  
    }

    void Damage (Transform bug)
    {
        Bug b = bug.GetComponent<Bug>();
        b.TakeDamage(damage);
    }

    void Explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, explocion);
        foreach (Collider collider in colliders)
        {
            if (collider.tag == "Bug")
            {
                Damage(collider.transform);
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, explocion);
    }
}
