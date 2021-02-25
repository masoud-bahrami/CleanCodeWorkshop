using System.Runtime.InteropServices;

namespace CleanCode.AgilePractices.Smells
{
    public class PageModelvm
    {
        public int CurrentPage { get; set; }
        public int CurrentOfPages { get; set; }


        public PageModelvm(int page , int ofPages)
        {
            CurrentOfPages = page;
            CurrentOfPages = ofPages;
        }
    }
}