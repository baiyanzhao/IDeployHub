namespace IDeployHub;

/// <summary>
/// 远程控制客户端
/// </summary>
public interface IDeployClient
{
	/// <summary>
	/// 启动远程桌面
	/// </summary>
	Task ReceiveRDP(string user, bool on);

	/// <summary>
	/// 按键
	/// </summary>
	Task ReceiveKey(int arg);

	/// <summary>
	/// 实时消息
	/// </summary>
	Task ReceiveMessage(string user, string message);

	/// <summary>
	/// 获取目录,如果路径是文件则直接下载
	/// </summary>
	Task<IEnumerable<string>> ReceiveDir(string user, string path, FileOperate operate);

	/// <summary>
	/// 打开网址
	/// </summary>
	Task ReceiveUrl(string url);

	/// <summary>
	/// 设置
	/// </summary>
	Task<byte[]> RemoteHandle(int type, object arg);

	/// <summary>
	/// 下载文件
	/// </summary>
	Task ReceiveFile(string name, IAsyncEnumerable<byte[]> bytes);
}
