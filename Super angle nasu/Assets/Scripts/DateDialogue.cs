using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//NPC�n�缾�a������ܤ��e
[CreateAssetMenu(menuName = "God/��ܸ��")]
public class DateDialogue : ScriptableObject
{
    // Text Area (�̤p���, �̤j���) - �ȭ�string
    [Header("��ܤ��e"), TextArea(3, 5)]
    public string[] dialogues;
}
