using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using Photon.Pun;

public class VRInteractable : XRGrabInteractable
{
    // �������� ���� ���� �������̵� �Լ�
    protected override void OnSelectEntering(SelectEnterEventArgs args)
    {
        // ������ ������ ������ ���ʽ��� ������ ��
        GetComponent<PhotonView>().RequestOwnership();
        base.OnSelectEntering(args);

        // ������� ������ Interactable, ���� Interactor �̴�. 
    }
}
