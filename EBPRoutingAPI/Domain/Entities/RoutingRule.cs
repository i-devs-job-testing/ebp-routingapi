using System;

namespace EBPRoutingAPI.Domain.Entities;

public class RoutingRule
{
    public string Nom { get; set; }
    public string Condition { get; set; }
    public string QueueCode { get; set; }
}
