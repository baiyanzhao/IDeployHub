namespace IDeployHub;

/// <summary>
/// 远程控制服务器端
/// </summary>
public interface IDeployServer
{
	/// <summary>
	/// 获取用户信息
	/// </summary>
	Task<User> GetUser(User id);

	/// <summary>
	/// 重命名
	/// </summary>
	public Task RenameUser(User id);

	/// <summary>
	/// 向指定用户发送消息
	/// </summary>
	Task SendMessage(string user, string message);

	/// <summary>
	/// 广播消息
	/// </summary>
	Task BroadcastMessage(string message);

	/// <summary>
	/// 获取目录,如果路径是文件则直接下载
	/// </summary>
	Task<IEnumerable<string>> SendDir(string user, string info, FileOperate operate);

	/// <summary>
	/// 打开网址
	/// </summary>
	Task SendUrl(string user, string url);

	/// <summary>
	/// 上传文件
	/// </summary>
	Task UploadFile(string repoName, string name, IAsyncEnumerable<byte[]> stream);

	/// <summary>
	/// 上传文件
	/// </summary>
	Task UploadBytes(string repoName, string name, byte[] bytes);

	/// <summary>
	/// 上传ZIP包,解包到目标目录
	/// </summary>
	Task UploadZip(string repoName, string name, byte[] bytes);

	/// <summary>
	/// 获取版本列表
	/// </summary>
	public Task<string[]> GetPackageList(string repoName, string filter);

	/// <summary>
	/// 获取最近版本号
	/// </summary>
	Task<string?> SearchPackage(string repoName, string filter);

	/// <summary>
	/// 获取最近版本号
	/// </summary>
	Task<string?> SearchFolder(string repoName, string filter);

	/// <summary>
	/// 下载文件
	/// </summary>
	Task<IAsyncEnumerable<byte[]>> DownloadFile(string path);

	/// <summary>
	/// 获取版本列表
	/// </summary>
	Task<IEnumerable<PackageInfo>> GetVersionList(PackageInfo filter);

	/// <summary>
	/// 从GIT获取文件
	/// </summary>
	Task<IAsyncEnumerable<byte[]>> GitCatFile(string repoName, string branch, string name);

	/// <summary>
	/// 推送文件到GIT
	/// </summary>
	Task GitPushFile(string repoName, string branch, string path, IAsyncEnumerable<byte[]> stream);

	/// <summary>
	/// 推送文件到GIT
	/// </summary>
	Task GitPushBytes(string repoName, string branch, string path, byte[] bytes);

	/// <summary>
	/// 推送ZIP包到GIT,解包到目标目录后提交
	/// </summary>
	Task GitPushZip(string repoName, string branch, string path, byte[] bytes);

	/// <summary>
	/// 运行脚本
	/// </summary>
	Task<bool> GitRunScript(string repoName, string branch, string name, string arg);
}
