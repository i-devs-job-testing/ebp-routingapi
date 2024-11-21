using System;

namespace EBPRoutingAPI.Infrastructure.Persistence.Entities;

public class RoutingRuleEntity
{
    public string Nom { get; set; }
    public string Condition { get; set; }
    public string QueueCode { get; set; }
}
