using System;

namespace quiz_att_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string primer;
            string EXIT = "EXIT";
            int total;
            string policy;
            int number;
            
            primer = welcome();

            while(primer != EXIT){
                number = policynumber();
                policy = policytype();
                policy = defence(policy);
                total = premium(policy);
                System.Console.WriteLine($"Policy number:{number} is set to {policy} to the amount of ${total}");
                primer = cont();   
            }

            
        }//end main
        static string welcome(){
            string primer;
            System.Console.WriteLine("Welcome to the insurance company. If you would like to enter please type 'ENTER'");
            primer = Console.ReadLine();
            return primer;
        }
        static int policynumber(){
            int policyNumber;
            System.Console.WriteLine("Please type in your policy number.");
            policyNumber = Convert.ToInt32(Console.ReadLine());
            return policyNumber;
        }
        static string policytype(){
            string policy;
            System.Console.WriteLine("What type of policy do you have? Please type 'HEALTH' or 'AUTO'");
            policy = Console.ReadLine();
            return policy;
        }
        static string defence(string policy){
            
            if(policy != "HEALTH" && policy != "AUTO"){
                System.Console.WriteLine("You enter an invalad policy. Please enter either 'HEALTH' or 'AUTO'");
                policy = Console.ReadLine();
                
            }
            return policy;
        }
        static int premium(string policyType){
            int HEALTH = 550;
            int AUTO = 225;
            int price;
            if(policyType == "HEALTH"){
                price = HEALTH;
            }else{
                price = AUTO;
            }
            return price;
        }
        static string cont(){
            string primer;
            System.Console.WriteLine("Would you like to continue? if so type 'CONT'. To exit type 'EXIT'");
            primer = Console.ReadLine();
            return primer;
        }

    }//end class
}
