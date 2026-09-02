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
            //string title = "refactoring";

            //switch (title)
            //{

            //    case "clean code":
            //        Console.WriteLine("great choice ");
            //        break;

            //    case "refactoring":
            //        Console.WriteLine("nice pickk ");
            //        break;

            //    default:
            //        Console.WriteLine("NEVER HEARD OF IT ");
            //        break;

            //}
            #endregion


            #region question3
            //int pages = 464;
            //string sizelabel = pages > 300 ? "long book " : "short book";
            //Console.WriteLine(sizelabel);
            #endregion

            #region question4
            //cannot answer
            #endregion

            #region question5
            //Cannot answer
            #endregion

            #region question6
            //int i = 1;
            //do
            //{
            //    Console.WriteLine("cheking book");
            //    i++;
            //}
            //while (i <= 3);


            #endregion

            #region question7
            //string[] books = { "clean code ", "the pragmtic programmer ", "refactoring " };

            //foreach (string book in books)
            //{
            //  Console.WriteLine(book);
            //}

            #endregion

            #region question8
            string[] books = { "clean code ", "the pragmtic programmer ", "refactoring " };
            foreach (string book in books)
            {
                Console.WriteLine(book);
                if (book=="refactoring ")
                {
                    break;
                }
            }
            #endregion
        }
        }
}
