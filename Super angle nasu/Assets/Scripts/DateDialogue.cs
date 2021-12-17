using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// NPC要對玩家說的對話內容
/// </summary>
[CreateAssetMenu(menuName = "God/對話資料")]
public class DateDialogue : ScriptableObject
{
    // Text Area (最小行數, 最大行數) - 僅限string
    [Header("對話內容"), TextArea(3, 5)]
    public string[] dialogues;
}
