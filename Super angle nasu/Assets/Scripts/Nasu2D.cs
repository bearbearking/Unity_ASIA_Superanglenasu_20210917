using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nasu2D : MonoBehaviour
{
    #region ���:���}
    [Header("���ʳt��"), Range(0, 100)]
    public float speed = 3.5f;
    [Header("���D����"), Range(0, 1500)]
    public float jump = 500;
    #endregion

    // Start is called before the first frame update
    private Rigidbody2D rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Move();
    }
    #region 
    private void Move()
    {
        
    }
}
