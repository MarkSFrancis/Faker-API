using System;
using System.Linq;
using Bogus.DataSets;
using Faker_API.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Faker_API.Areas.v1.Controllers
{
    public class FinanceController : BaseApiController
    {
        public IActionResult Account(int length = 8) =>
            Result(Faker.Finance.Account(length));

        public IActionResult AccountName() =>
            Result(Faker.Finance.AccountName());

        public IActionResult Amount(decimal min = 0, decimal max = 1000, int decimals = 2) =>
            Result(Faker.Finance.Amount(min, max, decimals));

        public IActionResult TransactionType() =>
            Result(Faker.Finance.TransactionType());

        public IActionResult Currency(bool includeFundCodes = false) =>
            Result(Faker.Finance.Currency(includeFundCodes));

        public IActionResult CreditCardNumber(string provider = null)
        {
            CardType cardType;
            switch (provider)
            {
                case "visa":
                    cardType = CardType.Visa;
                    break;
                case "mastercard":
                    cardType = CardType.Visa;
                    break;
                case "discover":
                    cardType = CardType.Visa;
                    break;
                case "american_express":
                    cardType = CardType.Visa;
                    break;
                case "diners_club":
                    cardType = CardType.Visa;
                    break;
                case "jcb":
                    cardType = CardType.Visa;
                    break;
                case "switch":
                    cardType = CardType.Visa;
                    break;
                case "solo":
                    cardType = CardType.Visa;
                    break;
                case "maestro":
                    cardType = CardType.Visa;
                    break;
                case "laser":
                    cardType = CardType.Visa;
                    break;
                case "instapayment":
                    cardType = CardType.Visa;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(provider));
            }

            return Result(Faker.Finance.CreditCardNumber(cardType));
        }

        public IActionResult CreditCardCvv() =>
            Result(Faker.Finance.CreditCardCvv());

        public IActionResult BitcoinAddress() =>
            Result(Faker.Finance.BitcoinAddress());

        public IActionResult EthereumAddress() =>
            Result(Faker.Finance.EthereumAddress());

        public IActionResult RoutingNumber() =>
            Result(Faker.Finance.RoutingNumber());

        public IActionResult Bic() =>
            Result(Faker.Finance.Bic());

        public IActionResult Iban(bool formatted = false) =>
            Result(Faker.Finance.Iban(formatted));
    }
}