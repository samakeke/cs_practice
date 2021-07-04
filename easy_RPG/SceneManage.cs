using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    public void TitleSceneChange()
    {
        SceneManager.LoadScene("TitleScene");
    }

    public void MainSceneChange()
    {
        SceneManager.LoadScene("GameMainScene");
    }

    public void OptionSceneChange()
    {
        SceneManager.LoadScene("OptionScene");
    }

    public void PlayerNameSceneChange()
    {
        SceneManager.LoadScene("PlayerNameScene");
    }

    public void CharaSelectSceneChange()
    {
        SceneManager.LoadScene("CharaSelectScene");
    }
}