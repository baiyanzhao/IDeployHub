namespace IDeployHub;

/// <summary>
/// 版本信息
/// </summary>
public class PackageInfo
{
	/// <summary>
	/// 仓库名称
	/// </summary>
	public string Name { get; set; } = "Magic";

	/// <summary>
	/// 版本
	/// </summary>
	public string? Version { get; set; }

	/// <summary>
	/// 作者
	/// </summary>
	public string? Author { get; set; }

	/// <summary>
	/// 更新时间
	/// </summary>
	public DateTime UpdateTime { get; set; }

	/// <summary>
	/// 客户名称
	/// </summary>
	public string? Customer { get; set; }

	/// <summary>
	/// 评审单号
	/// </summary>
	public string? OrderNumber { get; set; }

	/// <summary>
	/// 提交信息
	/// </summary>
	public string? Message { get; set; }
}
