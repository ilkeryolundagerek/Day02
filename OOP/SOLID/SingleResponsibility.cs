using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.SOLID
{
    public class SingleResponsibility
    {
    }

    //Bad Way:
    class S_ProductBad
    {
        public string Title { get; set; }
        public string Desc { get; set; }
        public decimal Price { get; set; }
        public bool IsInCampaign { get; set; }

        public void AddToCart(int cartId)
        {

        }
    }

    class S_UserBad
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public void Login()
        {

        }
    }

    //Good Way:
    class S_ProductGood
    {
        public string Title { get; set; }
        public string Desc { get; set; }
        public decimal Price { get; set; }
        public bool IsInCampaign { get; set; }
    }

    class S_ProductPersistence
    {
        public void AddToCart(int cartId, S_ProductGood s_productGood)
        {

        }
    }

    class S_UserGood
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    class S_UserLoginService
    {
        public void Login(string username, string password)
        {

        }
    }
}
