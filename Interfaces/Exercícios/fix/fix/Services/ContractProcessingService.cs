using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fix.Entities;

namespace fix.Services {
    class ContractProcessingService {

        public int NumberInstallments { get; set; }

        private IQuotaService _quotaService;

        public ContractProcessingService(int numberInstallments, IQuotaService quotaService) {
            this.NumberInstallments = numberInstallments;
            _quotaService = quotaService;
        }

        public void ProcessContract(Contract contract) {

            double dividedValue = contract.TotalValue / NumberInstallments;
            double quota = 0.0;

            for (int currentInstallment = 1; currentInstallment <= NumberInstallments; currentInstallment++) {

                quota = _quotaService.Quota(dividedValue, currentInstallment);
                DateTime dueDate = contract.Date.AddMonths(currentInstallment);

                contract.Installments.Add(new Installment(dueDate, quota));
            }
        }
    }
}
