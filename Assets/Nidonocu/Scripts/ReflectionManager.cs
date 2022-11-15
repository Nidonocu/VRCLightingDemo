
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class ReflectionManager : UdonSharpBehaviour
{
    [SerializeField]
    ReflectionProbe[] Probes;

    [SerializeField]
    VRC_Pickup SunController;

    bool updateNeeded = false;

    void Start()
    {
        foreach (var probe in Probes)
        {
            probe.RenderProbe();
        }
    }

    private void LateUpdate()
    {
        if (SunController.currentPlayer != null)
        {
            updateNeeded = true;
        }

        if (updateNeeded)
        {
            foreach (var probe in Probes)
            {
                probe.RenderProbe();
            }
            updateNeeded = false;
        }
    }

    public void RequestUpdate()
    {
        updateNeeded = true;
    }
}
