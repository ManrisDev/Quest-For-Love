using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public float volumevalue;
    public Slider volumeslider;

    private void Start()
    {
        volumeslider.value = PlayerPrefs.GetFloat("volume");
    }

    private void Update()
    {
        audioMixer.SetFloat("volume", volumevalue);
        PlayerPrefs.SetFloat("volume", volumevalue);
    }
    public void StartGame()
    {
        Debug.Log("�����");
        SceneManager.LoadScene("MainScene");
    }

    public void Settings()
    {
        Debug.Log("���������");
    }

    public void Quit()
    {
        Debug.Log("�����");
        Application.Quit();
    }

    public void SetVolume(float volume)
    {
        volumevalue = volume;
    }

    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
}
