using System;

namespace Iot.Users;

public class UserInfo : IotAggregateRoot<Guid>
{
    /// <summary>
    /// 账号
    /// </summary>
    public string? AccountNumber { get; protected set; }

    /// <summary>
    /// 手机号
    /// </summary>
    public string? PhoneNumber { get; protected set; }

    /// <summary>
    /// 微信id
    /// </summary>
    public string? WeChatOpenId { get; protected set; }

    /// <summary>
    /// 密码
    /// </summary>
    public string? Password { get; protected set; }

    /// <summary>
    /// 头像
    /// </summary>
    public string? Avatar { get; protected set; }

    /// <summary>
    /// 简介
    /// </summary>
    public string? Introduce { get; protected set; }

    /// <summary>
    /// 状态
    /// </summary>
    public UserInfoState State { get; protected set; }

    /// <summary>
    /// 名称
    /// </summary>
    public string? Name { get; protected set; }

    public UserInfo(Guid id) : base(id)
    {
    }

    public UserInfo(Guid id, string accountNumber, string phoneNumber, string weChatOpenId, string password,
        string avatar, string introduce, UserInfoState state, string name) : base(id)
    {
        AccountNumber = accountNumber;
        PhoneNumber = phoneNumber;
        WeChatOpenId = weChatOpenId;
        Password = password;
        Avatar = avatar;
        Introduce = introduce;
        State = state;
        Name = name;
    }
}