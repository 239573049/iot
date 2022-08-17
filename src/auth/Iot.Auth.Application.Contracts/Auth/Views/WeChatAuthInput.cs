namespace Iot.Auth.Application.Contracts.Auth.Views;

public class WeChatAuthInput
{
    public string Code { get; set; }

    public string Avatar { get; set; }

    public string Name { get; set; }
}