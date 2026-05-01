using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    private const string MusicVolumeKey = "musicVolume";

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey(MusicVolumeKey))
        {
            PlayerPrefs.SetFloat(MusicVolumeKey, 1f);
        }

        Load();
    }

   
    public void ChangeVolume()
    {
        if (volumeSlider == null)
        {
            return;
        }

        AudioListener.volume = volumeSlider.value;
        Save();
    }
    private void Load()
    {
        if (volumeSlider == null)
        {
            return;
        }

        volumeSlider.value = PlayerPrefs.GetFloat(MusicVolumeKey, 1f);
        AudioListener.volume = volumeSlider.value;
    }
    private void Save()
    {
        if (volumeSlider == null)
        {
            return;
        }

        PlayerPrefs.SetFloat(MusicVolumeKey, volumeSlider.value);
        PlayerPrefs.Save();
    }
}

