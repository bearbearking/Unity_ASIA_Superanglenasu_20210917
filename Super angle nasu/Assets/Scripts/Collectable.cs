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

}
