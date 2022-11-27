using System;
using Microsoft.AspNetCore.Mvc;

namespace BankMicroservice.Dtos.Bank.Vandar
{
    public class VandarPaymentResultDto
    {
        public int Status { get; set; }  
        public string Token { get; set; }
        public string Errors { get; set; }
    }

}

