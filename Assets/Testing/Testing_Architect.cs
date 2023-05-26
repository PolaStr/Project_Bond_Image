using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TESTING
{
    public class Testing_Architect : MonoBehaviour
    {
        Dialogue_System ds;
        Text_Architect architect;

        string[] lines = new string[5]
        {
            "Random line nothing special here...",
            "bla bla bla",
            "whatever",
            "yeah u right",
            "its not matter",
        };
        
        void Start()
        {
            ds = Dialogue_System.instance;
            architect = new Text_Architect(ds.dialogueContainer.dialogue_text);
            architect.buildMethod = Text_Architect.BuildMethod.instant;
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                architect.Build(lines[Random.Range(0, lines.Length)]);
        }
    }
}

