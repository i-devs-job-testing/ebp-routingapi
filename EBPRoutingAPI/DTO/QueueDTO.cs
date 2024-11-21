using System;

namespace EBPRoutingAPI.DTO;

public record QueueDTO : IQueueDTO
{
    public string QueueCode { get; set; }
}
