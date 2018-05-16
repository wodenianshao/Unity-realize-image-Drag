using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DragImage : MonoBehaviour,IBeginDragHandler,IEndDragHandler,IDragHandler
{
    public RectTransform rectTransform;
    // Use this for initialization
    void Start () {
        rectTransform = this.gameObject.GetComponent<RectTransform>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //实现接口，开始拖拽
    public void OnBeginDrag(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        print("开始拖拽");
    }

    //实现接口，拖拽时执行的方法
    public void OnDrag(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        Debug.Log("拖拽中x:{0}  y:{1}"+ eventData.position.x+" "+eventData.position.y);
        rectTransform.position = eventData.position;
    }

    //实现接口，结束拖拽
    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        print("结束拖拽");
    }

 
}
