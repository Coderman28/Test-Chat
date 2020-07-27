using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class communication : MonoBehaviour
{

    

    string message;
    PhotonView view;

    public void Envoyer()
    {

        view.RPC("methode", PhotonTargets.All);

    }


    [PunRPC]
    private void methode()
    {
        GameObject entree = GameObject.Find("InputField");
        string message;
        GameObject texte1 = GameObject.Find("Text");
        Text texte = (Text)texte1;

        message = entree.text;
        texte.text = message;

    }

}
