using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class SlidersAudioMixer : MonoBehaviour
{
    [SerializeField] private AudioMixer mixer;
    [SerializeField] private Slider sliderMaster;
    [SerializeField] private Slider sliderBackground;
    [SerializeField] private Slider sliderSFX;
    [SerializeField] private Slider sliderUI;


    private void Awake()
    {
        sliderMaster.onValueChanged.AddListener(OnSliderMasterChanged);
        sliderBackground.onValueChanged.AddListener(OnSliderBackgroundChanged);
        sliderSFX.onValueChanged.AddListener(OnSliderSFXChanged);
        sliderUI.onValueChanged.AddListener(OnSliderUIChanged);
    }

    private void OnDestroy()
    {
        sliderMaster.onValueChanged.RemoveListener(OnSliderMasterChanged);
        sliderBackground.onValueChanged.RemoveListener(OnSliderBackgroundChanged);
        sliderSFX.onValueChanged.RemoveListener(OnSliderSFXChanged);
        sliderUI.onValueChanged.RemoveListener(OnSliderUIChanged);
    }
    private void OnSliderMasterChanged(float value)
    {
        ModifyMixerVolume("VolumeMaster", value);
    }

    private void OnSliderBackgroundChanged(float value)
    {
        ModifyMixerVolume("VolumeBackground", value);
    }

    private void OnSliderSFXChanged(float value)
    {
        ModifyMixerVolume("VolumeSFX", value);
    }
    private void OnSliderUIChanged(float value)
    {
        ModifyMixerVolume("VolumeUI", value);
    }

    private void ModifyMixerVolume (string parameter, float volume)
    {
        float finalVolume = Mathf.Clamp(Mathf.Log10(volume) * 30f, -80f, 0f);
        mixer.SetFloat(parameter, finalVolume);
    }
}
