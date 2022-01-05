using System;
using ModelLibrary;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace RepositroyLibrary
{
    public class NumberSetRepository
    {
        private List<NumberSet> _numberSets;

        public List<NumberSet> NumberSets
        {
            get { return _numberSets; }
        }

        public NumberSetRepository() { }

        public NumberSetRepository(string path) 
        {
            _numberSets = new List<NumberSet>();
            if (File.Exists(path)) { Load(path); }
            else { File.Create("NumberSets.json"); }
        }

        public void Load(string path)
        {
            string jsonString = File.ReadAllText(path);
            if (jsonString == "") { return; }  // Terminate method if file exists but is empty
            _numberSets = JsonSerializer.Deserialize<List<NumberSet>>(jsonString);
        }

        public void Save(string path)
        {
            string jsonString = JsonSerializer.Serialize(NumberSets);
            File.WriteAllText(path, jsonString);
        }
    }
}
