using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class myscript : MonoBehaviour
{

    public Button Button;
    public string changesence;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Button.onClick.AddListener(onbuttonclick);
        Button.onClick.AddListener(onbuttonsecondclick);
    }
    public void onbuttonclick()
    {
        Debug.Log("Button 1 is clicked");
    }

    public void onbuttonsecondclick()
    {
        Debug.Log("Button 2 is clicked");
        SceneManager.LoadScene(changesence);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
