using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SusMine : MonoBehaviour
{
    public MonoBehaviour[] monoBehaviours;
    private PhotonView photonView;
    // Start is called before the first frame update
    void Start()
    {
        photonView = GetComponent<PhotonView>();
        if (!photonView.IsMine)
        {
            foreach (var script in monoBehaviours)
            {
                script.enabled = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
