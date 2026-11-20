namespace IDeployHub;

/// <summary>
/// 用户角色
/// </summary>
public enum UserRole
{
	/// <summary>
	/// 无权限
	/// </summary>
	None,

	/// <summary>
	/// 只读. 用于车间生成
	/// </summary>
	Readonly,

	/// <summary>
	/// 修改. 用于研发客服等
	/// </summary>
	Modify,

	/// <summary>
	/// 管理
	/// </summary>
	Admin,

	/// <summary>
	/// 超级用户
	/// </summary>
	Super,
}
