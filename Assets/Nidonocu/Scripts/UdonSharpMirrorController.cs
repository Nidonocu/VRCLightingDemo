
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class UdonSharpMirrorController : UdonSharpBehaviour
{
    [SerializeField]
    GameObject MirrorObject;

    [SerializeField]
    SoundManager SoundManager;

    public void ToggleMirror()
    {
        SoundManager.PlayPanel();
        MirrorObject.SetActive(!MirrorObject.activeInHierarchy);
    }
}
