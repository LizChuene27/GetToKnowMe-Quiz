import java.util.Scanner; 
  public class LizQuiz { 
      public static void main(String[] args) { 
      // Create a Scanner object to read user input 
      Scanner scanner = new Scanner(System.in); 
      // Initialize variables to track correct answers and total questions 
      int correctAnswers = 0; 
      int totalQuestions = 6; 
      // Updated the total number of questions 
      // Display a welcome message 
      System.out.println("Welcome to the Liz Quiz!"); 
      // Question 1 
      System.out.println("\nQuestion 1: What is Liz's gender?"); 
      System.out.println("A) Male B) Female"); 
      char answer1 = getUserAnswer(scanner); 
        if (answer1 == 'B') { correctAnswers++; } 
      // Question 2 
      System.out.println("\nQuestion 2: How old is Liz?"); 
      System.out.println("A) 21 B) 28 C) 35 D) 42"); 
      char answer2 = getUserAnswer(scanner); 
         if (answer2 == 'B') { correctAnswers++; } 
         // Question 3 
         System.out.println("\nQuestion 3: Where is Liz from?"); 
         System.out.println("A) Brazil B) South Africa C) Canada D) Australia"); 
         char answer3 = getUserAnswer(scanner); 
             if (answer3 == 'B') { correctAnswers++; } 
             // Question 4 
             System.out.println("\nQuestion 4: What is Liz's profession?"); 
             System.out.println("A) Doctor B) Engineer C) Frontend Developer D) Teacher"); 
             char answer4 = getUserAnswer(scanner); 
               if (answer4 == 'C') { correctAnswers++; } 
        // Question 5 
        System.out.println("\nQuestion 5: What degree is Liz pursuing at the University of the People?"); 
        System.out.println("A) Medicine B) Computer Science C) Law D) Economics"); 
        char answer5 = getUserAnswer(scanner); 
          if (answer5 == 'B') { correctAnswers++; } 
         // Question 6 
         System.out.println("\nQuestion 6: Besides being a developer, what else is she good at?"); 
         System.out.println("A) Athletic B) Designing C) Swimming D) Musical"); 
         char answer6 = getUserAnswer(scanner); 
            if (answer6 == 'B') { correctAnswers++; } 
        // Calculate and display the final score 
        double percentage = (double) correctAnswers / totalQuestions * 100; 
        System.out.println("\nYour final score: " + correctAnswers + " out of " + totalQuestions + " (" + percentage + "%)"); 
        // Close the Scanner 
        scanner.close(); } 
        // Helper method to get a valid user answer (A, B, C, or D) 
       private static char getUserAnswer(Scanner scanner) { 
            char answer; do { 
            System.out.print("You answer: "); 
            answer = scanner.next().toUpperCase().charAt(0); } 
            while (answer < 'A' || answer > 'D'); 
            return answer; 
            
        }
} 

