namespace BankMicroservice.Dtos.Payment
{
  public class PaymentInputDto
  {
    public int BankMicroservice { get; set; }
    public string OrderId { get; set; }
    public int BankId { get; set; }

    public PaymentInputDto()
    {

    }

    public PaymentInputDto(int BankMicroservice , string OrderId , int bankId)
    {
      BankMicroservice = BankMicroservice;
      OrderId = OrderId;
      BankId = bankId;
    }
  }
}
