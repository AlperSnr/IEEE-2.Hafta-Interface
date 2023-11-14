using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelScript : MonoBehaviour,IDamageable
{
    public void Explode()
    {
        //
    }

    public void Damage()
    {
        Explode();
    }
}
