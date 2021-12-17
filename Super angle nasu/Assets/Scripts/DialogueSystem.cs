using UnityEngine;
using UnityEngine.UI;
using System.Collections;

///<summary>
///��ܨt��
///�N�ݭn��X����r�Q�Υ��r�ĪG�e�{
///</summary>
public class DialogueSystem : MonoBehaviour
{
    [Header("��ܶ��j"), Range(0, 1)]
    public float interval = 0.3f;
    [Header("�e����ܨt��")]
    public GameObject goDialogue;
    [Header("���ܤ��e")]
    public Text textContent;
    [Header("��ܧ����ϥ�")]
    public GameObject goTip;
    [Header("��ܫ���")]
    public KeyCode keyDialogue = KeyCode.Mouse0;

    private void Start()
    {
        string test1 = "I WANNA BE AN ANGEL!!";
        string test2 = "HA!HA!HA!";
        string[] test = { test1, test2};
        StartCoroutine(TypeEffect(test));
    }
    /// <summary>
    /// ���r�ĪG
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>

    private IEnumerator TypeEffect(string[] content)
    {


        goDialogue.SetActive(true);                               //��ܹ�ܪ���

        for ( int j = 0; j < content.Length; j++)                 //�M�M�Ҧ����
        {
            textContent.text = "";                               //�M���W����ܤ��e
            goTip.SetActive(false);                              //���ô��ܹϥ� �T����   
            for (int i = 0; i < content[j].Length; i++)           //�M�M��ܪ��C�Ӧr
            {
                textContent.text += content[j][i];                //�|�[��ܤ��e��r����
                yield return new WaitForSeconds(interval);
            }
            goTip.SetActive(true);                               //��ܹ�ܧ����ϥ� �T����

            while (!Input.GetKeyDown(keyDialogue))                //���a�S������ܫ�����򵥫�
            {
                yield return null;                              //����null �@�Ӽv��ɶ� 
            }
        }
        goDialogue.SetActive(false);                             //���ù�ܨƥ�
    }

    
    ///<summary>
    ///�}�l���
    ///</summary>
    public void StartDialogue(string[] contents)
    {
        StartCoroutine(TypeEffect(contents));
    }

    ///<summary>
    ///������
    ///</summary>
    public void StopDialogue()
    {
        StopAllCoroutines();
        goDialogue.SetActive(false);
    }
}
