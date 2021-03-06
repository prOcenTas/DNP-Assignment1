﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Models;

namespace Assignment1.Data
{
    public class Service : IService
    {
        private readonly string adultsFile = "adults.json";
        private IList<Adult> Adults { get;  set; }

        public Service()
        { 
            Adults = File.Exists(adultsFile) ? ReadData<Adult>(adultsFile) : new List<Adult>();
        }
        
        private IList<T> ReadData<T>(string s) {
            using (var jsonReader = File.OpenText(s)) {
                return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
            }
        }
        
        public void SaveChanges() {
            
            string jsonAdults = JsonSerializer.Serialize(Adults, new JsonSerializerOptions {
                WriteIndented = true
            });

            using (StreamWriter outputFile = new StreamWriter(adultsFile, false)) {
                outputFile.Write(jsonAdults);
            }
        }


        public async Task<IList<Adult>> GetAdultsAsync()
        {
            List<Adult> tmp=new List<Adult>(Adults);
            return tmp;
        }

        public async Task AddAdultAsync(Adult adult)
        {
            
            Adults.Add(adult);
            SaveChanges();
        }

        public async Task RemoveAdultAsync(Adult adult)
        {

            Adult toRemove = Adults.First(t => t.Id == adult.Id);
            Adults.Remove(toRemove);
            SaveChanges();
        }

        public async Task UpdateAsync(Adult adult)
        {
            Adult toUpdate = Adults.First(t => t.Id == adult.Id);
            toUpdate.Update(adult);
            SaveChanges();
        }

    }
}