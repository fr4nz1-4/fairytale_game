using UnityEngine;

public class ClickableCharacter : MonoBehaviour
{
    public string characterName = "Fairy1";

    void OnMouseDown()
    {
        InteractWithCharacter();
    }

    void InteractWithCharacter()
    {
        Debug.Log("you clicked on" + characterName);
        print("you clicked on " + characterName);
    }
}
