using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Demo.DAL.DataContext
{
    public class AppConfiguration
    {
        public AppConfiguration()
        {
            //Current Path of this dll
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");

            var configurationBuilder = new ConfigurationBuilder();

            configurationBuilder.AddJsonFile(path, optional:false, reloadOnChange:true); //NOT optional, this has to be there
            var root = configurationBuilder.Build(); //Load the json File to the builder(Instantiating)
            var ConStringSection = root.GetSection("ConnectionStrings"); //ConnectionStrings = Section, DefaultConnection = Connection string name 
            sqlConnectionString = ConStringSection.GetSection("DefaultConnection").Value; // Assign connection string
                                                                                          // var ConString = root.GetSection("Settings");
        }
        public string sqlConnectionString { get; set; }
    }
}
