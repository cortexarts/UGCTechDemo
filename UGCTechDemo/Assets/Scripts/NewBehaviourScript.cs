using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LibGit2Sharp;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Repository.Clone("", "");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
