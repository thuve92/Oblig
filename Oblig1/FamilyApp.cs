using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace Oblig1
{
    class FamilyApp
    {
        public string CommandPrompt = "Skriv en kommando, vet du ikke om noen kommandoer kan du skrive hjelp";
        public string WelcomeMessage = "Hei! Morsomt at du stakk innom! Dette er et program som er laget i C# som er verdens beste programmerings språk! We all love it!";
        public List<Person> People;

        public FamilyApp(params Person[] people)
        {
            People = new List<Person>(people);
        }

        public string HandleCommand(string text)
        {
            if (text == "hjelp")
            {
                return MethodHjelp();
            }

            else if (text == "liste")
            {
                return MethodListe();
            }

            else if (text.Contains("vis "))
            {
                return MethodVis(text);
            }
            else
            {
                return "";
            }
        }

        private string MethodVis(string text)
        {
            var checkId = text.Substring(4);

            var children = new List<Person>();
            var selectedPerson = "";
            for (var i = 0; i < People.Count; i++)
            {
                if (People[i].Id == Int32.Parse(checkId))
                { 
                    selectedPerson += People[i].GetDescription() + "\n";
                }

                if (People[i].Mother.Id == Int32.Parse(checkId) || People[i].Father.Id == Int32.Parse(checkId))
                {
                    children.Add(People[i]);
                    
                }
            }

            return selectedPerson;
        }

        public string MethodListe()
        {
            var text = "";
            for (var i = 0; i < People.Count; i++)
            {
                text += People[i].GetDescription() + "\n";
            }
            return text;
        }

        public string MethodHjelp()
        {
            return @"hjelp => viser en hjelpetekst som forklarer alle kommandoene 
liste => lister alle personer med id, fornavn, fødselsår, dødsår og navn og id på mor og far om det finnes registrert. 
vis <id> => viser en bestemt person med mor, far og barn (og id for disse, slik at man lett kan vise en av dem)";
        }
    }
}
