using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    #region Public methods

    public void ExitPressed()
    {
        Application.Quit();
        Debug.Log("Exit pressed!");
    }

    public void PlayPressed()
    {
        SceneManager.LoadScene("SampleScene");
    }

    #endregion
}