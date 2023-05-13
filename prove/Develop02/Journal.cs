
using System.IO; 
public class Journal {
      public List<Entry> _entries = new List<Entry>();
      
      public void AddEntry(Entry entry)
        {
           _entries.Add(entry);
      
        }
        public void DisplayAllEntries()
        {
          foreach (Entry entry in _entries)
        {
            // This calls the Display method on each job
            entry.Display();
          }
          
        }
        public void SaveToFile(String filename)
        {
          using (StreamWriter outputFile = new StreamWriter(filename))
      {
           foreach (Entry entry in _entries)
        {
            outputFile.WriteLine($"{entry._dateText},{entry._question},{entry._answer}");
          }
      }
        }
    public void LoadToFile(String filename){
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {   Entry _entry = new Entry();
            string[] parts = line.Split(",");

            _entry._dateText = parts[0];
            _entry._question = parts[1];
            _entry._answer = parts[2];
            _entries.Add(_entry);
        }
}
}
        

      