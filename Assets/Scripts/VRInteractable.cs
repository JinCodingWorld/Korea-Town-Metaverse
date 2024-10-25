using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using Photon.Pun;

public class VRInteractable : XRGrabInteractable
{
    // 교수님이 직접 만든 오버라이드 함수
    protected override void OnSelectEntering(SelectEnterEventArgs args)
    {
        // 물건을 던지면 상대방이 오너쉽을 가지는 것
        GetComponent<PhotonView>().RequestOwnership();
        base.OnSelectEntering(args);

        // 움켜쥐는 물건은 Interactable, 손은 Interactor 이다. 
    }
}
