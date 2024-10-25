using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

[System.Serializable]
public class Room
{
    public string RoomName;
    public int sceneNum;
}
public class Network : MonoBehaviourPunCallbacks
{
    public List<Room> listRoom;
    public GameObject roomUI;

    public TMP_InputField NickName;
    private void Start()
    {
        //ServerConnect();
    }

    public void ServerConnect()
    {
        //에디터에서 설정된 Photon 에 연결
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        Debug.Log("방 입장");

    }

    public void CreatRoom(int roomIndex)
    {
        PhotonNetwork.LoadLevel(listRoom[roomIndex].sceneNum);

        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 10;

        PhotonNetwork.JoinOrCreateRoom(listRoom[roomIndex].RoomName, roomOptions, TypedLobby.Default);

    }

    //왜 얘가 바로 실행이 되는건가?
    public override void OnJoinedLobby()
    {
        base.OnJoinedLobby();

        PhotonNetwork.LocalPlayer.NickName = NickName.text;
        Debug.Log("조인 로비 : " + PhotonNetwork.LocalPlayer.NickName);
        roomUI.SetActive(true);
        
    }
}
