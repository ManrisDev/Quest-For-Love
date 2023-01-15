using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public float volumevalue;
    public Slider volumeslider;
    public AudioMixer audioEffectsMixer;
    public float effectsvalue;
    public Slider effectslider;
    private void Start()
    {
        volumeslider.value = PlayerPrefs.GetFloat("volume");
        effectslider.value = PlayerPrefs.GetFloat("effectsvolume");
    }

    private void Update()
    {
        audioMixer.SetFloat("volume", volumevalue);
        PlayerPrefs.SetFloat("volume", volumevalue);
        audioEffectsMixer.SetFloat("effectsvolume", effectsvalue);
        PlayerPrefs.SetFloat("effectsvolume", effectsvalue);
    }
    public void StartGame()
    {
        Debug.Log("Старт");
        SceneManager.LoadScene("MainScene");
    }

    public void Settings()
    {
        Debug.Log("Настройки");
    }

    public void Quit()
    {
        Debug.Log("Выход");
        Application.Quit();
    }

    public void SetVolume(float volume)
    {
        volumevalue = volume;
    }

    public void SetEffectsVolume(float effects)
    {
        effectsvalue = effects;
    }

    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
}
