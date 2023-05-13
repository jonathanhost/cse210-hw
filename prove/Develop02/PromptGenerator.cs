

public class PromptGenerator {
      Random random = new Random();
       string[] questions = {"What do you like to do?", "What is your favorite color?", "What do you will do today?", "What the best thing for you?"};
      
        public string Display()
        {
            var randomIndex = random.Next(0, questions.Length);
            return questions[randomIndex];
        {
      }
        }
}
        

      