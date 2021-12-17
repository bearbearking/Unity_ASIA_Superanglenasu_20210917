using UnityEngine;


/// <summary>
/// NPC�欰
/// ///�����ؼжi�J�I����
/// ��ܹ�ܨt��
/// </summary>
public class NPCGB : MonoBehaviour
{
    [Header("��ܸ��")]
    public DateDialogue dateDialogue;
    [Header("��ܨt��")]
    public DialogueSystem dialogueSystem;
    [Header("Ĳ�o��ܪ���H")]
    public string target = "�X�X";

    //Ĳ�o�}�l�ƥ�
    //1.��Ӫ��󳣭n�� collider 2D
    //2.��ӭn���@�Ӧ� Rigidbody 2D
    //3.��ӭn���@�Ӥ� Is Trigger
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

