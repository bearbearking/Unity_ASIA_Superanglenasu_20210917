using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dangerous : MonoBehaviour
{
    [Header("目標圖層")]
    public LayerMask layerTarget;
    [Header("攻擊力"), Range(0, 100)]
    public float attack = 100;
    [Header("攻擊區域大小與位移")]
    public Vector3 v3AttackSize = Vector3.one;
    public Vector3 v3AttackOffset;


    private void Attack()
    {
        Collider2D hit = Physics2D.OverlapBox(transform.position + transform.TransformDirection(v3AttackOffset), v3AttackSize, 0, layerTarget);
        hit.GetComponent<HurtSystem>().Hurt(attack);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        HurtSystem angleEat = collision.GetComponent<HurtSystem>();
        angleEat.GoodAngle(-100);
    }
}
