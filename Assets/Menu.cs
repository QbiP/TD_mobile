using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI oints;
    Contact scorescript;
    [SerializeField] GameObject WinScreen;

    // Start is called before the first frame update
    void Start()
    {
        GameObject EnemyPrefab = GameObject.Find("Enemy");
        Contact scorescript = EnemyPrefab.GetComponent<Contact>();
        scorescript.points = 0;
    }

    // Update is called once per frame
    //void Update()
    //{
    //    //oints.text = ("Points: " + scorescript.points);
    //    if (scorescript.points == 10)
    //    {
    //        WinScreen.SetActive(true);
    //    }

    //}
}
