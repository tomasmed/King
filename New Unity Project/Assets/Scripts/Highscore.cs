 using UnityEngine;
 using UnityEngine.UI;
 
 public class HighScore : MonoBehaviour
 {
     static int highscore;
     public static int score;
     Text text;
 
     // Set highscoreText up in the inspector.
     public Text highscoreText;
 
     void Awake()
     {
         text = GetComponent<Text>();
         score = 0;
         ////ighscore = PlayerPrefs.GetInt("highscore");
     }
 
     void Update()
     {
         if (score > highscore)
         {
             highscore = score;
             PlayerPrefs.SetInt("highscore", highscore);
             highscoreText.text = "Highscore: " + highscore;
         }
         text.text = "Score: " + score;
     }
 }