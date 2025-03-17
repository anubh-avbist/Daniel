using UnityEngine;
using System;
using System.Collections.Generic;

public class DialogueTree : MonoBehaviour
{

    [SerializeField]
    GameObject gameStateObject;
    private GameState gameState;

    [SerializeField]
    private List<DialogueNode> nodes;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.gameState = gameStateObject.GetComponent<GameState>();
    }

    // Update is called once per frame
    void Update()
    {
        
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
