using UnityEngine;
using UnityEngine.UI;     //�ޥΤ���API
using UnityEngine.Events;

public class Dangerous : MonoBehaviour
{
    [Header("�����O"), Range(0, 100)]
    public float attack = 100;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        HurtSystem angleEat = collision.GetComponent<HurtSystem>();
        angleEat.Hurt(100);
    }

}
