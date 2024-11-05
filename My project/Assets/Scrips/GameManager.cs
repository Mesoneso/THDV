using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int collectableCounter;
    [SerializeField] private TextMeshProUGUI socketCounter;
    public static GameManager Instance {  get; private set; }

    public void IncreaseCollectableCounter()
    {
        collectableCounter += 1;
        socketCounter.text = "Sockets: " + collectableCounter;
    }

    private void Awake()
    {
        Instance = this;
    }

    public int GetCollectableCounter()
    {
        return collectableCounter;
    }
}
