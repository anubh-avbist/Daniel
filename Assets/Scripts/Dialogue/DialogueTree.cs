using UnityEngine;
using System;
using System.Collections.Generic;

public class DialogueTree : MonoBehaviour
{
    [SerializeField]
    GameObject gameStateObject;
    private GameState gameState;

    public List<DialogueNode> nodes;
    private bool active;
    
    void Start()
    {
        this.gameState = gameStateObject.GetComponent<GameState>();
    }

    void Next()
    {
        if(nodes.Count > 0){
            nodes.RemoveAt(0);
        }
    }
}


[System.Serializable]
public class DialogueNode
{
    public string text;
    public string name;
    public bool isFinal;
    public bool hasOption;
}
