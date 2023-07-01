using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    #region Public methods

    public void MainMenuPressed()
    {
        SceneManager.LoadScene("Menu");
    }

    public void RestartPressed()
    {
        SceneManager.LoadScene("SampleScene");
    }

    #endregion
}