using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue_System : MonoBehaviour
{
    public Dialogue_Container dialogueContainer = new Dialogue_Container();
        
    public static Dialogue_System instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            DestroyImmediate(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
