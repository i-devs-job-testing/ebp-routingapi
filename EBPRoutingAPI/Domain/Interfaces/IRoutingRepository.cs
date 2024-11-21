using System;
using EBPRoutingAPI.Domain.Entities;

namespace EBPRoutingAPI.Domain.Interfaces;

public interface IRoutingRepository
{
    public Task<Queue> EvaluateRule(Client client, Licence licence);
}
