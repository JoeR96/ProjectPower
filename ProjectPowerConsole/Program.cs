using System;
using ProjectPower.Formula;
using ProjectPowerData;
using ProjectPowerData.Folder.Models;

namespace ProjectPowerConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            using (var ctx = new DataContext())
            {
                UserAccounts userAccount = new UserAccounts()
                {
                    UserId = 0,
                    UserName = "Bzzt",
                    Password = "Zelfdwnq9512!",
                    Email = "Joeyrichardson96@gmail.com"
                };


                ctx.UserAccounts.Add(userAccount);
                ctx.SaveChanges();


            }
        }    
    }
}
