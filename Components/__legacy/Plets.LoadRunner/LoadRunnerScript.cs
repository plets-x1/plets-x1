using System.Collections.Generic;
using System.Linq;
using Coc.Testing.Performance.AbstractTestCases;

namespace Lesse.LoadRunner {
    public class LoadRunnerScript {
        private object loadedTestData;
        private string path;
        public string scenarioName;

        public void GenerateScript () {
            List<Scenario> scenarioList = (List<Scenario>) loadedTestData;
            scenarioName = scenarioList.First ().Name;
            foreach (Scenario s in scenarioList) {
                //App.Execute(s, path + "\\" + s.Name, s.Name, null);                
            }
        }

        public string[] GetFileList () {
            return null;
        }

        public void SetLoadedTestData (object data) {
            this.loadedTestData = data;
        }

        public object GetLoadedTestData () {
            return this.loadedTestData;
        }

        public void SetPath (string path) {
            this.path = path;
        }

        public bool ValidateInput () {
            return true;
        }
    }
}