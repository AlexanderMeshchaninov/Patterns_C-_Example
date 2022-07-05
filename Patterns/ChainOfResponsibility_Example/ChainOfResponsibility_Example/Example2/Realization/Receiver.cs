namespace ChainOfResponsibility_Example.Example2.Realization
{
    public class Receiver
    {
        //Банковские переводы
        public bool BankTransfer { get; set; }
        //денежные переводы - WesternUnion, Unistream
        public bool MoneyTransfer { get; set; }
        //перевод через PayPal
        public bool PayPalTransfer { get; set; }

        public Receiver(
            bool bt, 
            bool mt, 
            bool ppt)
        {
            BankTransfer = bt;
            MoneyTransfer = mt;
            PayPalTransfer = ppt;
        }
    }
}