
// Kadir Hocamız bir e ticaret platformundan shaker alıyor.
// Shakerı sipariş etmeden önce bir ödeme yöntemi seçmesini sistem istiyor.

// Paypal ile ödeme
// Iban adresi ile ödeme
// Kredi Kartı ile ödeme 

using Polymorphism.ETicaret;

BasePayment payment = new PayPalPayment()
{
    Amount= 100000000,
    Email = "kdrarsln@gmail.com"
};

payment = new IbanPayment()
{
    AccountNo = "TR0006398542",
    Amount = 100000000
};

payment = new CreditCardPayment()
{
    CardNumber = "9792 0600 0571 4456",
    Amount = 100000000,
    CVV = "785",
    FullName = "Kadir Arslan"
};
payment.Pay();



