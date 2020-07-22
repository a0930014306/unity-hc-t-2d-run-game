using UnityEngine;

public class CAR : MonoBehaviour
{
    //資料
    //品牌、cc數、重量、顏色、速度、是否有天窗

    //欄位 field:儲存資料
    //*****欄位語法
    //修飾詞 欄位類型 欄位名稱 (指定 值) 結束符號
    //*欄位值以unity屬性(inspector)面板為主

    //整數int:沒有小數點的數值、例:1、100、-999
    //浮點數 float:有小數點的數值、例:1.234、-999.9-結尾必須要有f 大小寫皆可
    //字串 string:文字、例:紅水、123456、email-必須包覆在""內
    //布林值 bool:是、否、例:true、false

    //修飾詞:預設為私人
    //私人 private:不顯示
    //公開 public:顯示

    //資料
    //品牌、cc數、重量、顏色、速度、是否有天窗
    //欄位的屬性
    //語法:[屬性名稱(值)]
    //標題 Header
    //提示 Tooltip(提示文字)
    //範圍 Ranger(最小值、最大值)-僅限於數值類型
    [Header("品牌")]
    public string brand="賓士";
    [Header("CC數"),Tooltip("汽車的CC數量")]
    public int cc=1500;
    [Header("重量"),Range(0,100)]
    public float weight=20.5f;
    [Header("是否有天窗"),Tooltip("打勾代表有,取消代表沒有")]
    public bool window=true;
    [Header("速度"),Range(0,200)]
    public float speed=60.5f;

    //補充:Unity 常用資料類型
    //顏色、座標(2、3、4)
    public Color red=Color.red;
    public Color mycolor = new Color(0.5f, 0.5f, 0.9f);

    public Vector2 posZero = Vector2.zero;
    public Vector2 PosOne = Vector2.one;
    public Vector2 PosCustom = new Vector2(9, 20);

    public Vector3 Pos3 = new Vector3(3,2,1);

    public Vector4 Pos4 = new Vector4(1,2,3,4);

    //儲存物件、元件
    //物件:階層(Hierarchy)面板內所有東西
    //元件:屬性(Inspector)面板內的粗體字>Class
    public GameObject cam;
    public Transform traCam;
    public Camera cam1;

    //類別、成員命名規則
    //不允許
    //1.特殊符號，例:%$#@ 空格
    //2.數字開頭，例:9CC
    //3.保留字，例:class、int、bool

    //允許
    //1.底線，例:player_a
    //2.數字中間後面，例:player1、player3zzz
    //3.中文，例:角色速度(不建議)

}
