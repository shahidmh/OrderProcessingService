using OrderProcessService.Interface;

namespace OrderProcessService.Implementation
{
    public class GenerateDuplicateSlipRule : IOrderProcessRule
    {

        public string _departmentName { get; set; }

        public GenerateDuplicateSlipRule(string departmentName)
        {
            _departmentName = departmentName;
        }
        public bool IsRuleApplied { get; set; }


        /// <summary>
        /// generate duplicate slip
        /// </summary>
        /// <returns></returns>
        public string ApplyOrderRule()
        {
            IsRuleApplied = true;
            return $"Generating duplicate package slip for {_departmentName}";
        }
    }
}
