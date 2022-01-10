using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleNasuCollect : MonoBehaviour
{
    public GameObject pickE;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Nasu nasu = collision.GetComponent<Nasu>();

        print("碰撞到的東西是:" + nasu);

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
