using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Extensions.Sql;
using Microsoft.Extensions.Logging;

using NRGnet_Finances.Models;

namespace NRGnet_Finances.Icome
{
    public class GetIncomes
    {
        private readonly ILogger<GetIncomes> _logger;

        public GetIncomes(ILogger<GetIncomes> logger)
        {
            _logger = logger;
        }

        [Function("GetIncomes")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "incomes/{walletId}")]
            HttpRequest req,
            [SqlInput(commandText: "select * from dbo.Incomes where WalletID = @WalletId",
                commandType: System.Data.CommandType.Text,
                parameters: "@WalletId={walletId}",
                connectionStringSetting: "SqlConnectionString")]
            IEnumerable<Income> toDoItems)
        {
            return new OkObjectResult(toDoItems);
        }
    }
}
