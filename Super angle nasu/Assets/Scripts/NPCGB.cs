using UnityEngine;


/// <summary>
/// NPC行為
/// ///偵測目標進入碰撞區
/// 顯示對話系統
/// </summary>
public class NPCGB : MonoBehaviour
{
    [Header("對話資料")]
    public DateDialogue dateDialogue;
    [Header("對話系統")]
    public DialogueSystem dialogueSystem;
    [Header("觸發對話的對象")]
    public string target = "茄茄";

    //觸發開始事件
    //1.兩個物件都要有 collider 2D
    //2.兩個要有一個有 Rigidbody 2D
    //3.兩個要有一個勾 Is Trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == target)
        {
            dialogueSystem.StartDialogue(dateDialogue.dialogues);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == target)
        {
            dialogueSystem.StopDialogue();
        }
    }
}

