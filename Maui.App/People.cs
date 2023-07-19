using System;
using System.Collections.Generic;
namespace Maui.App
{
    public class People :List<User>
    {
        public People()
        {
            Add(new User() { Id = 1, Name = "Arianna Larson", 
                Email = "Arianna.Larson@xyz.com",Image= "AriannaLarson.jpg"
            });
            Add(new User()
            {
                Id = 2,
                Name = "Lorenzo Hewitt",
                Email = "Lorenzo.Hewitt@xyz.com",
                Image = "LorenzoHewitt.jpg"
            });
            Add(new User()
            {
                Id = 3,
                Name = "Susie Staffordn",
                Email = "Susie.Staffordn@xyz.com",
                Image = "SusieStafford.jpg"
            });
            Add(new User()
            {
                Id = 4,
                Name = "Aron Diaz",
                Email = "Aron.Diaz@xyz.com",

            });
            Add(new User()
            {
                Id = 5,
                Name = "Susie Staffordn",
                Email = "Susie.Staffordn@xyz.com",
                
            });
            Add(new User()
            {
                Id = 6,
                Name = "Chad Mcdaniel",
                Email = "Chad.Mcdanieln@xyz.com",
                
            });
            Add(new User()
            {
                Id = 7,
                Name = "Susie Staffordn",
                Email = "Susie.Staffordn@xyz.com",

            });
            Add(new User()
            {
                Id = 8,
                Name = "Kevin Cardenas",
                Email = "Kevin.Cardenas@xyz.com",

            });
            Add(new User()
            {
                Id = 9,
                Name = "Elliot Wrightn",
                Email = "Elliot.Wright@xyz.com",

            });
            Add(new User()
            {
                Id = 10,
                Name = "Tamara Lowe",
                Email = "Tamara.Lowe@xyz.com",

            });
        }
    }
}
