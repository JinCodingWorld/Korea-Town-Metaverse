using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using Photon.Pun;
using UnityEngine.UI;
using System;

public class VRChat : MonoBehaviour
{
    public Image backUI;

    List<string> list;
    public Text[] text;
    public TMP_InputField chat;

    PhotonView pv;

    private void Start()
    {
        pv = GetComponent<PhotonView>();
        // list �� �׳� ����� �ȵ�. �׻� new�� ��ü �������� ��.
        list = new List<string>();
    }

    public void SendTalk()
    {
        string str = PhotonNetwork.NickName + ": " + chat.text;
        Debug.Log(PhotonNetwork.NickName);
        // ��ΰ� AddTalkRPC �Լ� ȣ��
        pv.RPC("AddTalkRPC", RpcTarget.All, str);
        chat.text = "";
    }

    [PunRPC]
    void AddTalkRPC(string str)
    {
        while(list.Count > text.Length)
        {
            list.RemoveAt(0);
        }

        list.Add(str);

        UpdateTalk();
    }

    private void UpdateTalk()
    {
        for(int i=0;i< list.Count;i++)
        {
            text[i].text = list[i];
        }
    }
}
