using System;

namespace EBPRoutingAPI.Domain.Entities;

public class Client
{
    public bool EstClientDirect { get; set; }
    public bool EstIntegrateur { get; set; }
    public bool EstCertifie { get; set; }

    public bool EstPartenaire { get; set; }
    public bool EstExpert { get; set; }
    public bool EstClientGrandCompte { get; set; }

}
