using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage= 2;
    public int per;

    public void Init(float damage,int per)
    {
        this.damage = damage;
        this.per = per;
    }
}
