using BusinessRuleEngine.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessRuleEngine.Service.Service
{
    public class PaymentService : IPaymentService
    {
        public string ProcessOrder(string productType)
        {
            string result = "";
            switch ((productType)
)
            {
                case "Physical":
                    result = GeneratePackingSlip();
                    break;
                case "Book":
                    result = GenerateDuplicatePackingSlip();
                    break;
                case "ActivateMembership":
                    result = ActivateMembership();
                    break;
                case "UpgradeMembership":
                    result = UpgradeMembership();
                    break;
                case "Video":
                    result = Video();
                    break;
                default:
                    break;
            }

            return result;

        }

        private string ActivateMembership()
        {
            EmailUser();
            return "Email Sent & Membership activated";
        }

        private string GenerateCommissionToAgent()
        {
            return "Commission generated";
        }

        private string GenerateDuplicatePackingSlip()
        {
            GenerateCommissionToAgent();
            return "Duplicate Packing Slip & Commission Payment Generated";
        }

        private string GeneratePackingSlip()
        {
            GenerateCommissionToAgent();
            return "Packing Slip & Commission Payment Generated";
        }

        private string UpgradeMembership()
        {
            EmailUser();
            return "Email Sent & Membership upgraded";
        }

        private string EmailUser()
        {
            return "Email Sent";
        }

        private string Video()
        {
            return "Video Added To Packing Slip";
        }
    }

}