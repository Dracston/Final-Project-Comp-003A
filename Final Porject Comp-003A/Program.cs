using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Final_Porject_Comp_003A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInputint = 0;
            string userInputstr = "blank";
            List<string> questionarre = new List<string>(new string[] {"What is your full (first and last) name?", "What year were you born in?", "Are you Male (M), Female(F), or another option (O)", "How tall are you (In Inches)",
            "On a sclae from 1-10, what is your combat experience?", "Are you willing to put your life on the line for Super Earth?\n(Yes/No)", "What is your shoe size?", "In the event of a horific, sudden, potential, and unavoidable death by galactic entity, can your body be used for science?\n(Yes/No)",
            "Which Super Country of Super Earth are you from?", "Do you have previous Super Earth regulated firearm training?\n(Yes/No)", "Have you or a loved one been previously diagnosed with death by terminid mutilation?\n(Yes/No)", "If you know any active HellDivers, please state their name below: ",
            "Please state Yes if you will need any medical instruments to be provided for you by Super Earth. Please state No if no additional medical supplies will be needed for you.", "Which body part would you least want rennovated with bionic enhancements?"});

            
            UserAnswers(questionarre);

           
            }
        }
    }
    ///<summary> Program summary
    ///1: Catagorize each question into what answer it needs.
    /// 2: Create methods that assist in validating and exception handling those needs
    /// 3: Have an answer method for each question method (Either need to validate the question is answered in numbers or words)
    /// 4: Have a generic list of all 14 questions to use when printing answers
    /// 5: generate a list<> of each answer given. Answer methods will have to end with the answer being added to the list
    /// 6:Helldivers II theme
    /// 7: Loop my validation method by re-calling the method at the end of the catch
    /// 8:
    /// 
    /// </summary>
    

   static void UserAnswers(string)
{
    List<string> userAnswers = new List<string>();
    if (userInputstr = new)
            {
    try
    {
        Console.WriteLine($"{questionarre}");
        string newAnswer = Convert.ToString(Console.ReadLine());
        userAnswers.Add(newAnswer);

    }
    catch (NoNullAllowedException)
    {
        Console.WriteLine("You must asnwer each question, answer 'None' if you have no answer.");

    }
}
   
}
