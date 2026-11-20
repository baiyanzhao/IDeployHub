using System.ComponentModel.DataAnnotations;
namespace IDeployHub;

/// <summary>
/// 用户
/// </summary>
public class User
{
	/// <summary>
	/// 用户名
	/// </summary>
	[Display(Name = "用户名")]
	[Required(ErrorMessage = "请输入用户名")]
	public required string Name { get; set; }

	/// <summary>
	/// 标识
	/// </summary>
	[Display(Name = "标识")]
	[Required(ErrorMessage = "请输入标识")]
	public required string UniID { get; set; }

	/// <summary>
	/// 邮箱
	/// </summary>
	public string? Email { get; set; }

	/// <summary>
	/// 服务器
	/// </summary>
	[Display(Name = "服务器")]
	public string? Server { get; set; }

	/// <summary>
	/// 仓库列表
	/// </summary>
	[Display(Name = "部署仓库")]
	public string? Repo { get; set; }

	/// <summary>
	/// Url列表
	/// </summary>
	[Display(Name = "源程序仓库")]
	public string? Url { get; set; }

	/// <summary>
	/// 后缀列表
	/// </summary>
	[Display(Name = "后缀列表")]
	[Obsolete("后缀列表已废弃，根据平台自动匹配")]
	public string? Suffix { get; set; }

	/// <summary>
	/// 角色
	/// </summary>
	[Display(Name = "角色")]
	public UserRole UserRole { get; set; }
}
