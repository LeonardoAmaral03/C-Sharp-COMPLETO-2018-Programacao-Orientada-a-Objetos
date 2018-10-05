namespace fix.Services {
    class PaypalQuotaService : IQuotaService {

        public double Quota(double dividedValue, int currentInstallment) {

            double quota = dividedValue + dividedValue * 0.01 * currentInstallment;
            quota += quota * 0.02;

            return quota;
        }

    }
}
