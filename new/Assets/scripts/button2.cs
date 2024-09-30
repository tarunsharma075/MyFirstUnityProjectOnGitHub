using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class button2 : MonoBehaviour
{
    public Button button;
    public string changesence;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button.onClick.AddListener(onbuttonclicktwo);
    }

    private void onbuttonclicktwo()
    {
       
        SceneManager.LoadScene(changesence);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
