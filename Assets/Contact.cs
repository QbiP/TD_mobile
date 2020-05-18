using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Contact : MonoBehaviour
{

    [SerializeField] private GameObject Enemy;
    [SerializeField] private Transform EnemySpawn;
    [SerializeField] public TextMeshProUGUI oints;
    [SerializeField] public int points;
    [SerializeField] GameObject WinScreen;
    private PointsHandler pointshandler;


    void Awake()
    {
        pointshandler = GameObject.FindObjectOfType<PointsHandler>();
    }
        private void Update()
    {
        //oints.text = points.ToString();
        oints.text = ("Points: " + points);
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            GameOver();
            Debug.Log("GameOver");
        }

        if (col.gameObject.tag == "Bullet")
        {
            //pointshandler.UpdatePoints(points);
            //points ++;
            Debug.Log("Enemy hit!");
            
           // PointsUp();
            col.gameObject.SetActive(false);
            CreateNewEnemy();
            this.gameObject.SetActive(false);

            Destroy(col.gameObject);
            Destroy(this.gameObject, 1f);
            
        }
    }


    private void PointsUp()
    {
        
        //points++;
        //oints.text = points.ToString();
        //oints.text = ("Points: " + points);
        Debug.Log(points);
        if (points == 10)
        {
            WinScreen.SetActive(true);
        }

    }
    public void GameOver()
    {
        //Instantiate(Enemy, EnemySpawn.position, EnemySpawn.rotation);
    }

    public void CreateNewEnemy()
    {
        Instantiate(Enemy, EnemySpawn.position, EnemySpawn.rotation);
       
    }
   
}
