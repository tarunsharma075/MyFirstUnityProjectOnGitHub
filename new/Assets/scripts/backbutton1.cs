using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class backbutton1 : MonoBehaviour
{
    public Button button;
    public string changesence;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button.onClick.AddListener(onclick);
    }
      

    private void onclick()
    {
        SceneManager.LoadScene(changesence);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
