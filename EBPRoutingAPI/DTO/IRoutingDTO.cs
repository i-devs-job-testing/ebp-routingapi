using System;
using EBPRoutingAPI.Domain.Entities;

namespace EBPRoutingAPI.DTO;

public interface IRoutingDTO
{
    public Client Client { get; set; }
    public Licence Licence { get; set; }
}
