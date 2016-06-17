using EnergyPage.Utils;

namespace EnergyPage
{
    public class EnergyComparePage
    {
        public static string GetPageTitle()
        {
            return Driver.Instance.Title;
        }
    }
}