using BankMicroservice.Dtos.Payment;
using BankMicroservice.Services.Payment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography.X509Certificates;

namespace BankMicroservice.Controllers
{
    [Controller]

    public class BankController : Controller
    {
        private readonly IPaymentService paymentService; 
        public BankController(IPaymentService paymentService)
        {
            _paymentService = paymentService;  
        }

        /// <summary>
        /// Sends A Payment Request to Bank user has sent its id
        /// </summary>
        /// <param name="paymentInput"></param>
        /// <returns></returns>
        /// 
        [HttpPost("Api/Banks/PaymentRequest")]
        public async Task<IActionResultResult> PaymentRequest(PaymentInputDto paymentInput)
        {
            var paymentResult = _paymentService.Payment(paymentInput).Result;
            return StatusCode((int)paymentResult.HttpStatusCode, paymentResult);  
        }
    }

}





