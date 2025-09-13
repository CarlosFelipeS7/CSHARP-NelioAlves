
namespace Herança.Entities
{
    class BusinessAccount : Account //Herança
    {
        public double loanLimit { get; set; }


        public BusinessAccount()
        {

        }
                                                                                             
        public BusinessAccount(int number, string holder, double balance, double loanLimit) 
            : base(number, holder, balance) //aproveitando o construtor da classe Account
        {
            //como usei o Base, so preciso fazer a atribuicao do loan Limit
            loanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            //limite emprestimo
            if (amount <= loanLimit) {
                Balance += amount;
                }
        }

    }
}