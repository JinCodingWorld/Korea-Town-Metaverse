using ReadyPlayerMe.Core.WebView;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Inputs;

public class ActivateTeleportationRay : MonoBehaviour
{
    public GameObject leftTeleportation;
    //public GameObject rightTeleportation;

    public InputActionProperty leftActive;
    //public InputActionProperty rightActive;

    public InputActionProperty leftCancel;
   //public InputActionProperty rightCancel;

    public XRRayInteractor leftRay;
    //public XRRayInteractor rightRay;
    private void Update()
    {
        bool isLeftRayHovering = leftRay.TryGetHitInfo(out Vector3 leftPos, out Vector3 leftNormal, 
            out int leftNumber, out bool leftValid);
        leftTeleportation.SetActive(!isLeftRayHovering && leftCancel.action.ReadValue<float>() == 0 && 
            leftActive.action.ReadValue<float>() > 0.1f);

        //bool isRightRayHovering = leftRay.TryGetHitInfo(out Vector3 RightPos, out Vector3 RightNormal,
        //    out int RightNumber, out bool RightValid);
        //rightTeleportation.SetActive(!isRightRayHovering && rightCancel.action.ReadValue<float>() == 0 && 
        //    rightActive.action.ReadValue<float>() > 0.1f);
    }
}
