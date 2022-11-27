namespace BankMicroservice.Dtos.Payment
{
  public class PaymentInputDto
  {
    public int Price { get; set; }
    public string OrderId { get; set; }
    public int BankId { get; set; }

    public PaymentInputDto()
    {

    }

    public PaymentInputDto(int Price , string OrderId , int bankId)
    {
      Price = Price;
      OrderId = OrderId;
      BankId = bankId;
    }
  }
}
