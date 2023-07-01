using UnityEngine;
using UnityEngine.Audio;

public class Setttings : MonoBehaviour
{
    #region Variables

    public AudioMixer am;
    private bool _isFullScreen;

    #endregion

    #region Public methods

    public void AudioVolume(float sliderValue)
    {
        am.SetFloat("masterVolume", sliderValue);
    }

    public void FullScreenToggle()
    {
        _isFullScreen = !_isFullScreen;
        Screen.fullScreen = _isFullScreen;
    }

    public void Quality(int q)
    {
        QualitySettings.SetQualityLevel(q);
    }

    #endregion
}