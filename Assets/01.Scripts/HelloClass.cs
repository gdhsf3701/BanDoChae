using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloClass : MonoBehaviour
{
    private void Start()
    {
        Animal manggo = new Animal();
        manggo.name = "Manggo";
        manggo.sound = "Warr-warr-";

        Animal reo = new Animal();
        reo.name = "Reo";
        reo.sound = "miaw-miaw-";

        Animal hehu = new Animal();
        hehu.name = "Manggo";
        hehu.sound = "hehe";
        manggo = reo;
        manggo.name = "Podo";
        Debug.Log(manggo.name);
        Debug.Log(manggo.sound);
        Debug.Log(reo.name);
        Debug.Log(reo.name);
        Debug.Log(hehu.name);
        Debug.Log(hehu.name);

    }
    public class Animal
    {
        public string name;
        public string sound;


    }
}