using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dangerous : MonoBehaviour
{
    [Header("§ðÀ»¤O"), Range(0, 100)]
    public float attack = 100;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        HurtSystem angleEat = collision.GetComponent<HurtSystem>();
        angleEat.GoodAngle(-100);
    }
}
