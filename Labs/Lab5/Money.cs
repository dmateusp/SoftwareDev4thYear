using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public enum Currency { Euro, US, Yen };
    public struct Money
    {
        const double EuroToUS = 2.0;
        const double USToYen = 4.0;
        const double EuroToYen = 3.0;

        public int Amount { get; set; }
        public Currency Currency { get; set; }
        public Money(int amount, Currency currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public double convert(Currency toCurrency)
        {
            // not doing all currencies to not waste time
            switch (Currency)
            {
                case Currency.Euro:
                    if (toCurrency == Currency.Euro)
                        return Amount;
                    else if (toCurrency == Currency.US)
                        return Amount * EuroToUS;
                    else
                        return Amount * EuroToYen;
                case Currency.US:
                    if (toCurrency == Currency.Euro)
                        return Amount / EuroToUS;
                    else
                        return Amount;
                case Currency.Yen:
                    return Amount;
                default:
                    return 0.0;
            }
        }
        public static double operator +(Money left, Money right)
        {
            return left.Amount + right.convert(left.Currency);
        }
    }
}
