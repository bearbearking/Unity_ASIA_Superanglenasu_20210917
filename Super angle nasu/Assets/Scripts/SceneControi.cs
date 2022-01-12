using UnityEngine;
using UnityEngine.SceneManagement;    //引用場景管理API

public class SceneControi : MonoBehaviour
{
    public void LoadScene(string nameScene)
    {
        SceneManager.LoadScene(nameScene);
    }

    public void Quit()
    {
        Application.Quit();
        print("關閉遊戲");
    }
}
