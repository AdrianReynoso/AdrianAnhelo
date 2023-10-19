using UnityEngine;
using UnityEngine.UI; 

public class PlayerHeart : MonoBehaviour
{
    [SerializeField] private RawImage[] hearts;
    private int heartCount;
    // Start is called before the first frame update
    void Start()
    {
        heartCount = 3;
    }
    private void OnCollisionEnter2D ( Collision2D collision )
{ 
    if (collision.gameObject.tag == "Enemy")
        {
        heartCount--;
        }
}
    // Update is called once per frame
    void Update()
    {
        switch  (heartCount)
        {
            case 0:
                hearts[0].GetComponent<RawImage>().enabled = false;
        break;
        case 1:
                hearts[1].GetComponent<RawImage>().enabled = false;
        break;
        case 2:
                hearts[2].GetComponent<RawImage>().enabled = false;
        break;
    }
}
}

