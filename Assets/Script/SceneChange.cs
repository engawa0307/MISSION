using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    //メイン移行
    public void sceneLoadMain()
    {
        SceneManager.LoadScene("MainGame");
    }

    //タイトル移行
    public void sceneLoadTitle()
    {
        SceneManager.LoadScene("Title");
    }

}
