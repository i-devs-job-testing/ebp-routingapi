### Candidat : Olivier AUTAR - 21 Novembre 2024 - Session 13h30-16h

### Projet API

Nom de l'API : EBPRoutingAPI

Couches :

- Controllers : Contient le controlleur "RoutingController" qui expose la méthode Post prenant en entrée un entité de type RoutingDTO et renvoie une entité QueueDTO ou un objet de type IActionResult en fonction du traitement

- Domain :
  Entities : Contient l'ensemble des entités METIER Client, Licence, Queue et RoutingRule
  Interfaces : Contient l'ensemble des interfaces repositories pour réaliser les traitements et validations METIER : IRoutingRepository, IValidator
  Validators : Contient l'ensemble des implémentations des validateurs METIER : RoutingValidator

- DTO : Expose l'ensemble des entites de transfert d'objet au client (entrée : RoutingDTO, sortie : QueueDTO)

- Infrastructure : Contient les implémentations des repositories, l'entité RoutingRuleEntity et le fichier sources de données : routing-rules.json, qui stock l'ensemble des règles de routage.

### Projet Tests

Nom : EBPRoutingAPI.Tests
=> Expose les tests TDD (à implémenter) sous la classe Repositories.RoutingRepositoryTest
