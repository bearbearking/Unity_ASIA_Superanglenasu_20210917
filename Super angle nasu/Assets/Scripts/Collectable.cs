using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �i�����_��
/// </summary>
public class Collectable : MonoBehaviour
{
    [Header("�Y�_���^��"), Range(0, 20)]
    public float hp = 20;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Nasu nasu = collision.GetComponent<Nasu>();
        print("�I�쪺�F��O:" + nasu);
        //nasu.ChangeHpBar(1);
        Destroy(gameObject);

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
