using OrderProcessService.Interface;

namespace OrderProcessService.Implementation
{
    public class UpgradeMemberShipRule : IOrderProcessRule
    {
        public bool IsRuleApplied { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public string ApplyOrderRule()
        {
            return "Upgarde membership";
        }


    }
}
