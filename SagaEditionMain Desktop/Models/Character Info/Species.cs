using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SagaEditionMain_Desktop.Models.Character_Info
{
    public class Species
    {
        //Advozse
        //aleena
        //Altiri
        //Amani
        //Anarrian
        //Anzati
        //Aqualish
        //Arcona
        //arkanian
        //arkanian offshoot
        public List<SpeciesBase> SpeciesList { get; set; }
        public Species()
        {
            var speciesList = new List<SpeciesBase>
            {
                new SpeciesBase
                {
                    Name = "Advozse"
                },
                new SpeciesBase
                {
                    Name = "Aleena"
                },
                new SpeciesBase
                {
                    Name = "Altiri"
                },
                new SpeciesBase
                {
                    Name = "Amani"
                },
                new SpeciesBase
                {
                    Name = "Anarrian"
                },
                new SpeciesBase
                {
                    Name = "Anzati"
                },
                new SpeciesBase
                {
                    Name = "Aqualish"
                },
                new SpeciesBase
                {
                    Name = "Arcona"
                },
                new SpeciesBase
                {
                    Name = "Arkanian"
                },
                new SpeciesBase
                {
                    Name = "Arkanian Offshoot"
                },
            };
            SpeciesList = speciesList;
        }
        public class SpeciesBase
        {
            public string? Name { get; set; }
        }

    }
}
