
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class UdonSharpLight : UdonSharpBehaviour
{
    [SerializeField] MeshRenderer MyMesh;
    [SerializeField] Light MyLight;
    [SerializeField] Color TargetColor;

    [SerializeField] ReflectionManager ReflectionManager;

    [SerializeField]
    SoundManager SoundManager;

    const string ShaderEmissionProperty = "_EmissionColor";

    public override void Interact()
    {
        if (MyLight.enabled)
        {
            MyLight.enabled = false;
            MyMesh.material.SetColor(ShaderEmissionProperty, Color.black);
        }
        else
        {
            MyLight.enabled = true;
            MyLight.color = TargetColor;
            MyMesh.material.SetColor(ShaderEmissionProperty, TargetColor * 3.5f);
        }
        SoundManager.PlayBlocks();
        ReflectionManager.SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "RequestUpdate");
    }
}
