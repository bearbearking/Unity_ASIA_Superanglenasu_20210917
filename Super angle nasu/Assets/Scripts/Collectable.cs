using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 可收集寶物
/// </summary>
public class Collectable : MonoBehaviour
{
    [Header("吃寶物回血"), Range(0, 20)]
    public float hp = 20;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Nasu nasu = collision.GetComponent<Nasu>();
        print("碰到的東西是:" + nasu);
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
