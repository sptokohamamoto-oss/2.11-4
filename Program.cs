using System;

class Program {

    static void Main(string[] args)
    {
        string userid = "admin";
        string password = "password123";


        if (userid == "admin" && password == "password123")
        {

            Console.WriteLine("ログイン成功");

        }
        else 
        {
            Console.WriteLine("不正アクセス");

        }

    }
     

}


