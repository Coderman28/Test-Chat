using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class network : MonoBehaviour
{

    [SerializeField]
    private GameObject canvaser;

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings("chat1");
    }

    void OnJoinedLobby()
    {
        RoomOptions MyRoomOptions = new RoomOptions();
        MyRoomOptions.MaxPlayers = 20;
        PhotonNetwork.playerName = "Chater" + Random.Range(1, 500);
        PhotonNetwork.JoinOrCreateRoom("Chat", MyRoomOptions, TypedLobby.Default);


    }

    void OnJoinedRoom()
    {
        canvaser.SetActive(true);
        Debug.Log("hello");
    }

}
