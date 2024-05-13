using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameButton : MonoBehaviour
{

    public GameObject nameBoard;

    public void ViewNameBoard()
    {
        bool isActive = nameBoard.active;
        nameBoard.SetActive(!isActive);
    }
}
