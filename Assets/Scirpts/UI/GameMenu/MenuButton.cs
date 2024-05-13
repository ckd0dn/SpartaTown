using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    public GameObject menu;

    public void ViewMenu()
    {
        bool isActive = menu.active;
        menu.SetActive(!isActive);
    }
}
