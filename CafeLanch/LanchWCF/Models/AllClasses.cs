
using cafeLanch;
using cafeLanch.models;
using CafeLanch.DAL.models;
using LanchWCF.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using CafeLanch;

namespace LanchWCF.Models
{
    
    public class AllClasses : ICategory, IDrink, IPizza, IOrder, IIngredient,ISushi,IDessert
    {
         cafeLanch.CafeLanch cafelanch = new cafeLanch.CafeLanch();
        
        public List<CategoryDTO> GetCategories()
        {
            
            List<Category> Categories = cafelanch.Categories.ToList();
            List<CategoryDTO> DTOCategory = new List<CategoryDTO>();
            foreach (var p in Categories)
            {
                CategoryDTO category = new CategoryDTO
                {
                    ID = p.ID,
                    Name = p.Name,


                };
                DTOCategory.Add(category);
            }
            return DTOCategory;
        }

        public List<DrinkDTO> GetDrinks()
        {
            List<Drink> Drinks = cafelanch.Drinks.ToList();
            List<DrinkDTO> DTODrinks = new List<DrinkDTO>();
            foreach (var p in Drinks)
            {
                DrinkDTO drink = new DrinkDTO
                {
                    ID = p.ID,
                    Name = p.Name,
                    Price=p.Price
                   
                };
                DTODrinks.Add(drink);
            }
            return DTODrinks;
        }

        public List<IngredientDTO> GetIngratients()
        {
            List<Ingredient> Ingredients = cafelanch.Ingredients.ToList();
            List<IngredientDTO> DTOIngredients = new List<IngredientDTO>();
            foreach (var p in Ingredients)
            {
               IngredientDTO ingredient = new IngredientDTO
                {
                    ID=p.ID,
                    Name=p.Name

                };
                DTOIngredients.Add(ingredient);
            }
            return DTOIngredients;
        }

        public List<OrderDTO> GetOrders()
        {
            throw new NotImplementedException();
        }
     
      
        public List<PizzaDTO> GetPizzas()
        {
            List<Pizza> Pizzas = cafelanch.Pizzas.ToList();
            List<PizzaDTO> DTOPizzas = new List<PizzaDTO>();
            foreach (var p in Pizzas)
            {
                PizzaDTO pizza = new PizzaDTO
                {
                    ID = p.ID,
                    Name = p.Name,
                    Price = p.Price,
                    Path = p.Path,

                };
                DTOPizzas.Add(pizza);
            }


            return DTOPizzas;
           
        }

       
        SmtpClient smtpClient = new SmtpClient();
        void IOrder.SendOnEmail(string Subject, string Messege, OrderDTO order)
        {
            smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential(@"lanchcafelanchcafe@gmail.com", "LanchcafelanchcafE");
            MailAddress mailAddress = new MailAddress(@"lanchcafelanchcafe@gmail.com");
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
            List<Dessert> Desserts = cafelanch.Desserts.ToList();
            List<DessertDTO> DTODesserts = new List<DessertDTO>();
            foreach (var p in Desserts)
            {
                DessertDTO desert = new DessertDTO
                {
                    ID = p.ID,
                    Name = p.Name,
                    Price = p.Price

                };
                DTODesserts.Add(desert);
            }
            return DTODesserts;
        }

        public List<SushiDTO> GetSushis()
        {
            List<Sushi> Sushis = cafelanch.Sushis.ToList();
            List<SushiDTO> DTOSushis = new List<SushiDTO>();
            foreach (var p in Sushis)
            {
                SushiDTO sushi = new SushiDTO
                {
                    ID = p.ID,
                    Name = p.Name,
                    Price = p.Price,
                    Path = p.Path,
                   
                };
                DTOSushis.Add(sushi);
            }


            return DTOSushis;
        }

       
    }
}
