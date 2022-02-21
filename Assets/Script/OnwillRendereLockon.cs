using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// OnWillRenderObject()はシーンビューカメラに移ってる時でも呼ばれちゃうから使うなってイワナ、書かなかった？コメント
/// まあなにか発見があるかもしれないから多少は、ね？
/// </summary>
public class OnwillRendereLockon : MonoBehaviour
{
    private string _mainCameraTagName = "MainCamera";//const 暗黙的にstatic インスタンスが異なっても常に同じ値 constする意味ないから消した
    bool _canlockOn = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _canlockOn = false;
    }

    private void OnWillRenderObject()
    {
        _canlockOn = true;
    }
}
