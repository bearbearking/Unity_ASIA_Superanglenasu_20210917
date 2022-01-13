using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleNasuCollect : MonoBehaviour
{
    [Header("¦YÄ_ª«¦^¦å"), Range(0, 20)]
    public float hp = 20;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        HurtSystem angleEat = collision.GetComponent<HurtSystem>();
        angleEat.GoodAngle(20);
        Destroy(gameObject);
    }
}
