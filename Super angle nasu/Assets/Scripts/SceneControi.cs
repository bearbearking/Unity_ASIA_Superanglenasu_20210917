using UnityEngine;
using UnityEngine.SceneManagement;    //�ޥγ����޲zAPI

public class SceneControi : MonoBehaviour
{
    public void LoadScene(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }

    public void Quit()
    {
        Application.Quit();
        print("�����C��");
    }
}
