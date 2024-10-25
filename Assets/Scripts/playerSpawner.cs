using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;

public class playerSpawner : MonoBehaviourPunCallbacks
{
    GameObject player;

    // 이게 실행이 안된다. 
    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        // 스폰 되는 위치가 이상하다. 
        player = PhotonNetwork.Instantiate("Player", transform.position, transform.rotation);
        Debug.Log("생성된 Player 위치 : " + transform.position + ", ");
    }

    public override void OnLeftRoom()
    {
        base.OnLeftRoom();
        PhotonNetwork.Destroy(player);
    }
}
