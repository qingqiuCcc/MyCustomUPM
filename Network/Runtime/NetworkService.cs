using UnityEngine;

public class NetworkService
{
    public void Connect()
    {
        Debug.Log("[Network] Connecting...");
        // 使用 Core 模块里的类，证明跨模块依赖（Network -> Core）生效
        var core = new MyTest();
        core.DoPrint();
        Debug.Log("[Network] Connected. (成功调用了 Core.MyTest)");
    }
	public void Close()
{
        Debug.Log("[Network] Close");
}
}
