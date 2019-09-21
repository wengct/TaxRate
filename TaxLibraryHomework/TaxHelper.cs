using System.Collections.Generic;

namespace TaxLibraryHomework
{
    public class TaxHelper
    {
        class RateTable
        {
            public decimal MinIncome { get; set; }
            public decimal MaxIncome { get; set; }
            public decimal Rate { get; set; }
        }

        public static decimal GetTaxResult(decimal income)
        {
            decimal result = 0M;
            foreach (RateTable item in GetRateTable())
            {
                if (income >= item.MinIncome)
                {
                    result += (
                        (income > item.MaxIncome ? item.MaxIncome : income)
                        - (item.MinIncome > 0 ? item.MinIncome - 1M : 0M)
                        ) * item.Rate;
                }
            }
            return result;
        }

        static IEnumerable<RateTable> GetRateTable()
        {
            /*
                ▪ 年收入0 ~ 540,000 : 5%
                ▪ 年收入540,001 ~ 1,210,000 : 12%
                ▪ 年收入1,210,001 ~ 2,420,000 : 20%
                ▪ 年收入2,420,001 ~ 4,530,000 : 30%
                ▪ 年收入4,530,001 ~ 10,310,000 : 40%
                ▪ 年收入10,310,001 ~ : 50%
             */
            return new List<RateTable>{
                new RateTable { MinIncome = 4530001M, MaxIncome = 10310000M, Rate = 0.4M },
                new RateTable { MinIncome = 1210001M, MaxIncome = 2420000M, Rate = 0.2M },
                new RateTable { MinIncome = 0M, MaxIncome = 540000M, Rate = 0.05M },
                new RateTable { MinIncome = 540001M, MaxIncome = 1210000M, Rate = 0.12M },
                new RateTable { MinIncome = 2420001M, MaxIncome = 4530000M, Rate = 0.3M },
                new RateTable { MinIncome = 10310001M, MaxIncome = decimal.MaxValue, Rate = 0.5M }
            };
        }
    }
}
