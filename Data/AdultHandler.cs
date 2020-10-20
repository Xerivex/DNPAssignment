using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using DNPAssignment.Models;


namespace DNPAssignment.Data {
    public class AdultHandler : IAdultHandler {

        private string AdultFile = "adults.json";
        private IList<Adult> adults;

        public AdultHandler() {
            if (!File.Exists(AdultFile)) {
                Seed();
                WriteAdultsToFile();
            }
            else {
                string adultsC = File.ReadAllText(AdultFile);
                adults = JsonSerializer.Deserialize<List<Adult>>(adultsC);
            }
        }

        public void AddAdult(Adult adult) {
            int adultLength = adults.Max(adult => adult.Id);
            adult.Id = (++adultLength);
            adults.Add(adult);
            WriteAdultsToFile();
        }

        public IList<Adult> AquireAdults() {
            List<Adult> adultList = new List<Adult>(adults);
            return adultList;
        }

        public void removeAdult(int adultID) {
            foreach(Adult adult in adults) {
                if(adult.Id == adultID) {
                    adults.Remove(adult);
                    break;
                }
            }
            WriteAdultsToFile();
        }

        public void updateAdult(Adult adultUpdate) {
            foreach(Adult adult in adults) {
                if(adult.Id == adultUpdate.Id) {
                    adult.Age = adultUpdate.Age;
                    adult.EyeColor = adultUpdate.EyeColor;
                    adult.FirstName = adultUpdate.FirstName;
                    adult.HairColor = adultUpdate.HairColor;
                    adult.Height = adultUpdate.Height;
                    adult.JobTitle = adultUpdate.JobTitle;
                    adult.LastName = adultUpdate.LastName;
                    adult.Sex = adultUpdate.Sex;
                    adult.Weight = adultUpdate.Weight;
                    break;
                }
            }
            WriteAdultsToFile();
        }

        public void WriteAdultsToFile() {
            string jsonConvert = System.Text.Json.JsonSerializer.Serialize(adults); // look, i dont know what happend - the using didnt want to work, thats all i know.
            File.WriteAllText(AdultFile, jsonConvert);
        }

        public void Seed() {
            // if needed due to missing file
        }
    }
}
