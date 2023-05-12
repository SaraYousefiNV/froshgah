
using ConsoleStore.DataModels;
using ConsoleStore.Enums;

namespace ConsoleStore
{
    public class Application
    {
        public void Run()
        {
            ConsolHelper consolHelper = new ConsolHelper();


            while (true)
            {
             
                Console.WriteLine("----------Please Choose The Items:---------- \n 1:AddCategory  2:AddProduct  3:ReportCategory  4:ReportProduct  5:Exit ");
                string readKeyItemType = Console.ReadKey().KeyChar.ToString();
                Console.ReadLine();

                if (int.Parse(readKeyItemType) == (int)(ActionType.AddCategory))
                {
                    consolHelper.SetCategory();
                }

                else if (int.Parse(readKeyItemType) == (int)(ActionType.AddProduct))
                {
                   
                    consolHelper.SetProduct();
                }
                else if (int.Parse(readKeyItemType) == (int)(ActionType.ReportCategory))
                {
                    consolHelper.ReportCategory();
                }
                else if (int.Parse(readKeyItemType) == (int)(ActionType.ReportProduct))
                {
                    consolHelper.ReportProduct();
                }
                else if (int.Parse(readKeyItemType) == (int)(ActionType.Exit))
                {
                    return;
                }

            }
        }
    }

    
}
