using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    void Walk()
    {

    }

    void Shoot()
    {

        if (Physics.Raycast(transform.position, Vector3.forward, out RaycastHit hit, 50))
        {
            IDamageable damageable = hit.collider.GetComponent<IDamageable>();
            if(damageable != null)
            {
                damageable.Damage();
            }

        }


    }
}
