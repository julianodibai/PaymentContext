using System;
using System.Collections.Generic;

namespace PaymentContext.Domain.Entities
{
   public class Subscription
   {
       private IList<Payment> _payments; //cria uma Interface List(pagamentos) que vai ter o (pagamento) como itens

       public Subscription( DateTime? expireDate)
       {
            CreateDate = DateTime.Now;
            LastUpdateDate = DateTime.Now;
            ExpireDate = expireDate;
            Active = true;
            _payments = new List<Payment>();
       }

       public DateTime CreateDate { get; private set; }
       public DateTime LastUpdateDate { get; private set; }
       public DateTime? ExpireDate { get; private set; } // o "?" significa que aceita null
       public bool Active { get; private set; }
       public IReadOnlyCollection<Payment> Payments { get; private set; }

       public void AddPayment(Payment payment)
       {
           _payments.Add(payment);
       }
       public void Activate()
       {
          Active = true;
          LastUpdateDate = DateTime.Now;
       }
       public void Inactivate()
       {
          Active = false;
          LastUpdateDate = DateTime.Now;
       }
   }
}