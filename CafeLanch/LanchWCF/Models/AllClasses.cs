using LanchWCF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace LanchWCF.Models
{
    public class AllClasses : ICategory, IDrink, IPizza, IOrder, IIngredient,ISushi,IDessert
    {
       //CafeLanchDAL allClasses = new CafeLanch();
        public List<PizzaDTO> GetCategories()
        {
            throw new NotImplementedException();
        }

        public List<PizzaDTO> GetDrinks()
        {
            throw new NotImplementedException();
        }

        public List<IngredientDTO> GetIngratients()
        {
            throw new NotImplementedException();
        }

        public List<PizzaDTO> GetOrders()
        {
            throw new NotImplementedException();
        }
     
      
        public List<PizzaDTO> GetPizzas()
        {
            //List<Pizza> Pizzas = phoneContext.Pizzas.ToList();
            //List<PizzaDTO> DTOPizzas = new List<PizzaDTO>();
            //foreach (var p in Pizzas)
            //{
            //    PizzaDTO phone = new PizzaDTO
            //    {
            //        ID = p.ID,
            //       Name = p.Name,
            //        Price = p.Price,
            //        Path = p.Path,

            //    };
            //    DTOPhones.Add(phone);
            //}


            // return DTOPizzas;
            throw new NotImplementedException();
        }

        List<PizzaDTO> IOrder.GetOrders()
        {
            throw new NotImplementedException();
        }
        SmtpClient smtpClient = new SmtpClient();
        void IOrder.SendOnEmail(string Subject, string Messege, OrderDTO order)
        {
            smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential(@"LanchCafe@gmail.com", "LanchCafe");
            MailAddress mailAddress = new MailAddress(@"LanchCafe@gmail.com");
            MailMessage m = new MailMessage();
            m.From = mailAddress;
            m.To.Add(order.Email);
            m.Subject = Subject;
            m.Body = Messege;
            smtpClient.EnableSsl = true;
            smtpClient.Send(m);

        }

        public List<DessertDTO> GetDessert()
        {
            throw new NotImplementedException();
        }

        public List<SushiDTO> GetSushis()
        {
            throw new NotImplementedException();
        }
    }
}
