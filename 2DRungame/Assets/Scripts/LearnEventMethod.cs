using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnEventMethod : MonoBehaviour
{
    //事件:在特定時間會自動執行
    //開始:在播放遊戲後會執行一次,初始化,血量滿\
    //輸出 print("訊息") - 將訊息輸出到儀表板 - 測試用
    private void Start()
    {
        print("哈囉，沃德~");

        //呼叫方法
        //語法:方法名稱();
        Test();

        //呼叫有參數的方法時要輸入對應的引數
        Test2(999);
        Test2(123456);

        //有預設值的參數可以不填寫
        Drive(125, "右邊");
        Drive(999);

        //多個預設值參數時可以用 參數名稱:指定
        Drive(777, sound: "蹦蹦");

        Test3("火");
        Test3("電");

    }

    //更新:一秒執行約60次，持續執行，例如:移動、旋轉、監聽玩家輸入
    private void Update()
    {
        print("嗨~我在更新");
    }

    //方法:
    //*****語法:
    //修飾詞 傳回類型 方法名稱(參數) {程式內容}
    //無傳回 void
    //方法名稱:Unity 習慣會用大寫開頭
    //事件與方法的差異:事件名稱為藍色，方法為白色
    //事件與方法的差異:事件會自動執行，方法不會，需要呼叫
    public void Test()
    {
        print("測試!!!");
    }

    //RPG遊戲:施放火球
    public void ShootFire()
    {
        print("施放火球!!!!");
    }

    public void ShootIce()
    {
        print("施放冰球!!!!");

    }


    //參數語法:(參數類型 參數名稱，參數類型 參數名稱，....)
    //參數與欄位相同但不需要修飾詞


    public void Test2(int number)
    {
        print("我是測試2號,您所輸入的數字為");
        print(number);

    }

    public void Test3(string prop)
    {

        print("發射" + prop + "球!!!");
        print(prop);


    }

   
    //參數預設值:選填式參數
    //語法:類型 名稱=值

    public void Drive(int speed, string direction="前方",string sound="咻咻")
    {
        print("時速:" + speed);
        print("開車方向:" + direction);
        print("開車音效:" + sound);
    }


    #region 事件

   

    #endregion


    /// <summary>
    /// 移動
    /// </summary>
    private void Move()
    {

    }
    /// <summary>
    /// 跳躍
    /// </summary>
    private void Jump()
    {

    }
    /// <summary>
    /// 滑行
    /// </summary>
    private void Slide()
    {

    }
    /// <summary>
    /// 吃金幣
    /// </summary>
    private void Coin()
    {

    }
    /// <summary>
    /// 受傷
    /// </summary>
    private void Break()
    {

    }
    /// <summary>
    /// 死亡
    /// </summary>
    private void Dead()
    {

    }

    private void Complete()
    {

    }

}






