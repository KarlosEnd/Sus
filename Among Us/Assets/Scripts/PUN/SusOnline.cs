using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SusOnline : MonoBehaviourPunCallbacks
{
    public static SusOnline susOnline;
    // Start is called before the first frame update
    void Awake()
    {
        susOnline = this;
        DontDestroyOnLoad(gameObject);
    }

    public void Connect()
    {
        if (!PhotonNetwork.ConnectUsingSettings())
        {
            print("No se pudo conectar");
        }
    }

    public void CreateRoom()
    {
        if (PhotonNetwork.InLobby)
        PhotonNetwork.JoinRandomOrCreateRoom();
    }

    public override void OnConnectedToMaster()
    {
        print("Se conecto al master");
        PhotonNetwork.JoinLobby();       
    }

    public override void OnCreatedRoom()
    {
        print("CreatedRoom");
    }

    public override void OnJoinedRoom()
    {
        print("JoinedRoom");
        PhotonNetwork.Instantiate("Player",Vector3.zero,Quaternion.identity);
    }


}
