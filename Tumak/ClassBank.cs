using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumak
{
    enum Typee
    {
        Saved,
        Personal
    }
    class Bank
    {
        private Guid rootcheck;
        private double balanse;
        private string typecheck;
        static Guid root;
        private System.Collections.Queue queue;
        
        public Bank() { }
        public Bank(double balanse)
        {
            this.balanse = balanse;
            rootcheck = Guid.NewGuid();
        }
        public Bank(double balanse, string typecheck)
        {
            this.balanse = balanse;
            this.typecheck = typecheck;
            rootcheck = Guid.NewGuid();
        }

        public void TakeoffMoney(int a) //Снять деньги
        {
            BankTransaction bbb = new BankTransaction(a);
            bbb.date = DateTime.Now;
            queue.Enqueue(bbb);
            if (a <= balanse)
            {
                balanse = balanse - a;
            }
            else
            {
                Console.WriteLine("Hедостаточно средств");
            }
        }
        public void CHeckMoney() // Проверка счета
        {
            Console.WriteLine($"{balanse}");
        }
        public virtual void Translate(Bank bank, double sum, Bank bank1) // Перевод
        {
            BankTransaction bbb = new BankTransaction(sum);
            bbb.date = DateTime.Now;
            queue.Enqueue(bbb);
            bank.balanse = balanse - sum;
        }
    }
    class Tinkof : Bank // Второй банк
    {
        private double balanse = 1000;

        public double Balanse
        {
            get { return balanse; }
            set { balanse = value; }
        }
        public override void Translate(Bank bank, double sum, Bank bank1)
        {
            base.Translate(bank, sum, bank1);
            balanse = balanse + sum;
        }


    }
}
