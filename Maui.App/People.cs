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

        }
    }
}
