namespace Iot.Consul;

public class ConsulOptions
{
    public const string Name = "Consul";

    public string? Id { get; set; }
    
    public string? ServiceName { get; set; }

    public string? ServiceIP { get; set; }

    public int ServicePort { get; set; }

    public string ServiceHealthCheck { get; set; }

    public string Address { get; set; }
}