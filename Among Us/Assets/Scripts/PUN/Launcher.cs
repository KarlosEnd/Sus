using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Launcher : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void connect()
    {
        if (!PhotonNetwork.IsConnected)
        {
            if (PhotonNetwork.ConnectUsingSettings()) 
            {
                print("Conectado");
            } else
            {
                print("No se pudo conectar");
            }
        }
    }

    public override void OnConnectedToMaster()
    {
        print("Conectado a los serviores");
    }

    public void CreateRoom()
    {
        Photon.Realtime.RoomOptions a = new Photon.Realtime.RoomOptions();
        a.MaxPlayers = 5;
        PhotonNetwork.CreateRoom("test", a);
    }

    public override void OnCreatedRoom()
    {
        print("Si se creo wee");
    }


    public override void OnJoinRoomFailed(short returnCode, string message)
    {
       
    }

}
