using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Photon.Pun;

public class playerSpawner : MonoBehaviourPunCallbacks
{
    GameObject player;

    // �̰� ������ �ȵȴ�. 
    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        // ���� �Ǵ� ��ġ�� �̻��ϴ�. 
        player = PhotonNetwork.Instantiate("Player", transform.position, transform.rotation);
        Debug.Log("������ Player ��ġ : " + transform.position + ", ");
    }

    public override void OnLeftRoom()
    {
        base.OnLeftRoom();
        PhotonNetwork.Destroy(player);
    }
}
