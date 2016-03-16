namespace Spicejet.com.BookingPageClasses
{
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Spicejet.com.BookingPageClasses;
    
    
    public partial class BookingPage
    {

        public bool VerifyRediractiononBookingPage()
        {
            
            //HtmlDiv symbol = new HtmlDiv();
            HtmlDiv symbol = new HtmlDiv();
            //HtmlDocument symbol = new HtmlSpan();
            symbol = CheapAirTicketsOnlinWindow.CheapAirTicketsOnlinDocument.WrapperPane.ItemPane;
            if (symbol.Exists)
            {
                symbol.DrawHighlight();
                return true;
            }
            else
            {
                return false;
            }
        }
    }


}
