using BankMicroservice.Entities;
using BankMicroservice.Persistances.ReturnTypes;
using BankMicroservice.Services.BankTransactions;
using ErrorHandlingDll.ReturnTypes;
using Microsoft.AspNetCore.Mvc;
using Sentry.Extensibility;

namespace BankMicroservice.Controllers
{
    [Controller]  

    public class BankTransactionService : Controller
    {
        private readonly IBankTransactionService bankTransactionService;

        public BankTransactionController(IBankTransactionService bankTransactionService)
        {
            _bankTransactionService = bankTransactionService;   
        }

        /// <summary>
        /// Gets a bank transaction by id
        /// </summary>
        /// <param name="transactionId"></param>
        /// <returns></returns>   
        [HttpGet("Api/BankTransactions/{transactionId}")]    
        public async Task<IActionResult> GetTransaction([FromRoute] long transactionId)
        {
            ReturnModel<BankTransactionModel> result = _bankTransactionService.GetTransaction(transactionId).Result;
            return StatusCode((int)result.HttpStatusCode, result);  
        }

    }

}


