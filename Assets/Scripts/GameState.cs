using UnityEngine;

public class GameState : MonoBehaviour
{
    [SerializeField]
    private bool cutscene;
    public GameObject dialogueBox;
    
    void Start()
    {
        dialogueBox.SetActive(false);
    }


    void Update()
    {
        
    }
}
