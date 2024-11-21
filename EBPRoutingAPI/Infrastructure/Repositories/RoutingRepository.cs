using System;
using EBPRoutingAPI.Domain.Entities;
using EBPRoutingAPI.Domain.Interfaces;

namespace EBPRoutingAPI.Infrastructure.Repositories;

public class RoutingRepository : IRoutingRepository
{
    //TODO : Charger le fichier JSON : routing-rules.json
    public Task<Queue> EvaluateRule(Client client, Licence licence)
    {
        throw new NotImplementedException();
    }
}
