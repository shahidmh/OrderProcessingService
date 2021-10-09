﻿namespace OrderProcessService.Inteface
{

    /// <summary>
    /// inteface for rule logic 
    /// </summary>
    public interface IOrderProcessRule
    {
        public bool IsRuleApplied { get; set; }
        public string ApplyOrderRule();
    }
}