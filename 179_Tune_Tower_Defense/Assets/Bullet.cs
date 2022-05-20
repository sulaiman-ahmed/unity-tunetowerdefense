using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform target;

    public float speed = 60f;

    public void Chase(Transform _target) {
        target = _target;
    }

    // Update is called once per frame
    void Update()
    {
        if(target == null) {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distThisFrame = speed * Time.deltaTime;
        if(dir.magnitude <= distThisFrame) {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distThisFrame, Space.World);

    }

    void HitTarget () {
        Destroy(gameObject);
    }
    


}
