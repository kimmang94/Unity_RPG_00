using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Stage01");
    }
}
