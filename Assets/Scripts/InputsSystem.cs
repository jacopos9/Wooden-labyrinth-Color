using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

/// <summary>
/// classe che si occupa della gestione dei comandi (board)
/// </summary>
public class InputsSystem : MonoBehaviour,IDragHandler, IPointerDownHandler,IPointerUpHandler
{
    Vector3 direction;
    float maxRotation = 30f;
    private Rigidbody rb;

    public Image imgJoyStickBG;  // <--- cambiare nome
    public Image imgJoystick;   /// tambien
    private Vector2 posInput;


    private void Start()
    {
        imgJoyStickBG = GetComponent<Image>();
        imgJoystick = transform.GetChild(0).GetComponent<Image>();
    }

    #region Pc Input
    void PcInputs()
    {
        float h = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(h, 0, z) * 3f * Time.deltaTime);
    }

    void MoveBoard()
    {
        float h = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        transform.localRotation = Quaternion.Euler(new Vector3(h * 30f, 0 * 30f, z * 30f));
    }

    #endregion

    #region Accelerometer Input
    // input Accelerometro
    public void Accelerometer()
    {
        float x = Input.acceleration.x;
        float y = Input.acceleration.y;
        float z = Input.acceleration.z;

        gameObject.transform.rotation = Quaternion.Euler(new Vector3(x * maxRotation, y * maxRotation, z * maxRotation));
    }

    #endregion

    #region Joystick Input


    public void OnDrag(PointerEventData eventData)
    {

        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(
            imgJoyStickBG.rectTransform,
            eventData.position,eventData.pressEventCamera
            ,out posInput))
        {
            posInput.x = posInput.x / (imgJoyStickBG.rectTransform.sizeDelta.x);
            posInput.y = posInput.y / (imgJoyStickBG.rectTransform.sizeDelta.y);

            if (posInput.magnitude > 1.0f)
            {
                posInput = posInput.normalized;
            }

            imgJoystick.rectTransform.anchoredPosition = new Vector2(
                posInput.x * (imgJoyStickBG.rectTransform.sizeDelta.x /2)
                , posInput.y * (imgJoyStickBG.rectTransform.sizeDelta.y /2));
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        OnDrag(eventData);
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        posInput = Vector2.zero;
        imgJoystick.rectTransform.anchoredPosition = Vector2.zero;
    }

    public float InputHorizontal()
    {
        if(posInput.x != 0)
        
            return posInput.x;
            else
                return Input.GetAxis("Horizontal");
    }

    public float InputVertical()
    {
        if (posInput.y != 0)

            return posInput.y;
        else
            return Input.GetAxis("Vertical");
    }

    #endregion

    private void Update()
    {
        PcInputs();
        //Accelerometer();
        //MoveBoard();
    }

}
