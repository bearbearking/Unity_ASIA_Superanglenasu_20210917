using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dangerous : MonoBehaviour
{
    [Header("�ؼйϼh")]
    public LayerMask layerTarget;
    [Header("�����O"), Range(0, 100)]
    public float attack = 100;
    [Header("�����ϰ�j�p�P�첾")]
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
