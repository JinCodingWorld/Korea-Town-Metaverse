using Photon.Pun;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
public class player : MonoBehaviour
{
    public Transform playerHead;
    public Transform playerLeft;
    public Transform playerRight;

    Transform xrHead;
    Transform xrLeft;
    Transform xrRight;

    PhotonView pv;

    //public Animator animatorL;
    //public Animator animatorR;

    private void Start()
    {
        pv = GetComponent<PhotonView>();
        XROrigin o = FindObjectOfType<XROrigin>();

        xrHead = o.transform.Find("Camera Offset/Main Camera");
        xrLeft = o.transform.Find("Camera Offset/Left Controller");
        xrRight = o.transform.Find("Camera Offset/Right Controller");


        // 포톤이 자기면, 자기의 렌더를 끈다. 
        // 임시 시험
        if (pv.IsMine)
        {
            foreach (var r in GetComponentsInChildren<Renderer>())
            {
                r.enabled = false;
            }
        }
    }

    // 이게 굉장한 오류를 일으킨다. 
    void CopyTransform(Transform t, Transform s)
    {
        t.position = s.position;
        t.rotation = s.rotation;
    }

    private void Update()
    {
        if(pv.IsMine)
        {
            CopyTransform(playerHead, xrHead);
            CopyTransform(playerLeft, xrLeft);
            CopyTransform(playerRight, xrRight);
        }
    }

    //void SetAnimation(InputDevice input, Animator animator)
    //{
    //    if (input.TryGetFeatureValue(CommonUsages.trigger, out float t))
    //        animator.SetFloat("Trigger", t);
    //    else
    //        animator.SetFloat("Trigger", 0);
    //    if (input.TryGetFeatureValue(CommonUsages.trigger, out float g))
    //        animator.SetFloat("Trigger", g);
    //    else
    //        animator.SetFloat("Trigger", 0);
    //}
}
