using System;
using UnityEngine;

public class ClickableChair : MonoBehaviour
{
    public string popupText = "I'm a chair";
    public GameObject popupPrefab;

    private void OnMouseDown()
    { 
        Debug.Log("you clicked on: " + gameObject.name);
        if (popupPrefab != null)
        {
            GameObject canvas = GameObject.Find("Canvas");
            if (canvas != null)
            {
                GameObject popup = Instantiate(popupPrefab, canvas.transform);
                popup.GetComponent<RectTransform>().anchoredPosition = Vector2.zero; // Popup zentriert
            }
            else
            {
                Debug.LogError("Kein Canvas gefunden!");
            }
        }
    }
}
