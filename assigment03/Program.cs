namespace assigment03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region question1

            //int pages = 464;
            //bool isavalibale = true;

            //if (pages>300 && isavalibale ==true)
            //{
            //    Console.WriteLine("you can borrow this book");
            //}


            #endregion

            #region question2
            string title = "refactoring";

            switch (title)
            {

                case "clean code" :
                    Console.WriteLine("great choice ");
                    break;

                case "refactoring":
                    Console.WriteLine("nice pickk ");
                    break;

                default:
                    Console.WriteLine("NEVER HEARD OF IT ");
                    break;

            }
            #endregion




        }
    }
}
