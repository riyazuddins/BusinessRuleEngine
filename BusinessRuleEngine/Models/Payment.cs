using System;

namespace BusinessRuleEngine.Models
{
    public class Payment
    {
       public Product Product { get; set; }
    }

    public enum Product
    {
        Physical,
        Book,
        ActivateMembership,
        UpgradeMembership,
        Video

    }
}
