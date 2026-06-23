using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Audio_setting : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer; // 1단계의 믹서 연결용
    [SerializeField] private Slider volumeSlider;   // 하이어라키의 Sound 슬라이더 연결용
    [SerializeField] private Player p1;

    void Start()
    {
        volumeSlider.minValue = 0.0001f;
        volumeSlider.maxValue = 1f;
        volumeSlider.value = 1f;

        volumeSlider.onValueChanged.AddListener(OnVolumeChanged);
    }

    public void OnVolumeChanged(float value)
    {
        float decibel = Mathf.Log10(value) * 20;
        p1.sound = decibel;
        audioMixer.SetFloat("MasterVolume", decibel);
    }
}
