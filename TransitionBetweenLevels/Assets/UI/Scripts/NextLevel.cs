using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        LevelController.instanse.isEndGame();
    }
}
