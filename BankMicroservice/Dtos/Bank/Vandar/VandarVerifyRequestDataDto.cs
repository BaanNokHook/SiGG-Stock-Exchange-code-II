using System;
using Microsoft.AspNetCore.Mvc;

namespace BankMicroservice.Dtos.Bank.Vandar
{
    public class VandarVerifyRequestDataDto
    {
        public string Api_key { get; set; }
        public string Token { get; set; }
        public VandarVerifyRequestDataDto()
        {
        
        }
        public VandarVerifyRequestDataDto(string api_key, string token)
        {
            api_key = api_key;
            token = token;
        }
    }
}
