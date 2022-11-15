
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class SoundManager : UdonSharpBehaviour
{
    [SerializeField]
    AudioSource PanelUISound;

    [SerializeField]
    AudioSource BlockUISound;

    public void PlayPanel()
    {
        PanelUISound.gameObject.SetActive(true);
        SendCustomEventDelayedSeconds("ResetSounds", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
    }

    public void PlayBlocks()
    {
        BlockUISound.gameObject.SetActive(true);
        SendCustomEventDelayedSeconds("ResetSounds", 0.5f, VRC.Udon.Common.Enums.EventTiming.Update);
    }

    public void ResetSounds()
    {
        PanelUISound.gameObject.SetActive(false);
        BlockUISound.gameObject.SetActive(false);
    }
}
