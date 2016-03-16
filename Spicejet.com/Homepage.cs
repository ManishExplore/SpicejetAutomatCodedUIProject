namespace Spicejet.com.HomepageClasses
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
    using Spicejet.com.HomepageClasses;
    using Spicejet.com.BookingPageClasses;


    public partial class Homepage
    {
        // Verify that Browser is Launch Successfully 
        public bool VerifyBrowserLuanc()
        {
            // Make a object of Html Hyperlink class 
            HtmlHyperlink spicejetlogo = new HtmlHyperlink();
            // Copy the referance of the logo to the creating object 
            // For comformation of the successfull launch of browser we are checking that after login the logo of spice jet is present on the web page
            // In each and every function we do the same thing so refer the comment part for each method 
            spicejetlogo = SpiceJetFlightBookinWindow.SpiceJetFlightBookinDocument.HeaderPane.SpiceJetHyperlink;
            if (spicejetlogo.Exists)
            {
                // DrawHighlight function highlight the draw and show the capture logo
                spicejetlogo.DrawHighlight();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerifyAboutusHyperlink()
        {
            HtmlHyperlink about = new HtmlHyperlink();
            about = SpiceJetFlightBookinWindow.SpiceJetFlightBookinDocument.Smoothmenu1Pane.AboutUsHyperlink;
            if (about.Exists)
            {
                about.DrawHighlight();
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool VerifyContactusHyperlink()
        {
            HtmlHyperlink contact = new HtmlHyperlink();
            contact = SpiceJetFlightBookinWindow.SpiceJetFlightBookinDocument.Smoothmenu1Pane.ContactUsHyperlink;
            if (contact.Exists)
            {
                contact.DrawHighlight();
                return true;
            }
            else
            {
                return false;
            }

        }

        public void SelectLeavefromOption()
        {
            HtmlEdit leave = new HtmlEdit();
            leave = SpiceJetFlightBookinWindow.SpiceJetFlightBookinDocument.CTXTEdit;
            Mouse.Click(leave);
            //HtmlSpan select = new HtmlSpan();
            Mouse.Click(SpiceJetFlightBookinWindow.SpiceJetFlightBookinDocument.DropdownGroup1Pane.GoaGOIHyperlink);


        }
        public bool VerifyLeavefromListoptionisSelected(String s)
        {
            HtmlEdit selectoption = new HtmlEdit();
            selectoption = SpiceJetFlightBookinWindow.SpiceJetFlightBookinDocument.CTXTEdit;
            if (selectoption.Text == s)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SelectGoingtoOption()
        {
            HtmlEdit goingto = new HtmlEdit();
            goingto = SpiceJetFlightBookinWindow.SpiceJetFlightBookinDocument.CTXTEdit2;
            Mouse.Click(goingto);
            //HtmlSpan select = new HtmlSpan();
            Mouse.Click(SpiceJetFlightBookinWindow.SpiceJetFlightBookinDocument.DropdownGroup1Pane2.MumbaiBOMHyperlink);


        }
        public bool VerifyGoingtoListoptionisSelected()
        {
            HtmlEdit selectGoingtooption = new HtmlEdit();
            selectGoingtooption = SpiceJetFlightBookinWindow.SpiceJetFlightBookinDocument.CTXTEdit2;
            if (selectGoingtooption.Text == "Mumbai (BOM)")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SelectFromDate()
        {
            HtmlEdit fromdate = new HtmlEdit();
            fromdate = SpiceJetFlightBookinWindow.SpiceJetFlightBookinDocument.FromdateEdit;
            Mouse.Click(fromdate);
            Mouse.Click(SpiceJetFlightBookinWindow.UISpiceJetFlightBookinDocument.UidatepickerdivPane.Item30Hyperlink);
        }

        public bool VerifyFromDate()
        {
            HtmlEdit selectiondate = new HtmlEdit();
            selectiondate = SpiceJetFlightBookinWindow.SpiceJetFlightBookinDocument.FromdateEdit;
            if (selectiondate.Text == "30-11-2015")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SelectToDate()
        {
            HtmlEdit todate = new HtmlEdit();
            todate = SpiceJetFlightBookinWindow.SpiceJetFlightBookinDocument.TodateEdit;
            Mouse.Click(todate);
            Mouse.Click(SpiceJetFlightBookinWindow.SpiceJetFlightBookinDocument.UidatepickerdivPane.Item31Hyperlink);
        }

        public bool VerifyToDate()
        {
            HtmlEdit selectiontodate = new HtmlEdit();
            selectiontodate = SpiceJetFlightBookinWindow.SpiceJetFlightBookinDocument.TodateEdit;
            if (selectiontodate.Text == "31-12-2015")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void VerifyClickonFindFlight()
        {
            // HtmlButton find = new HtmlButton();
            HtmlInputButton find = new HtmlInputButton();
            find = SpiceJetFlightBookinWindow.SpiceJetFlightBookinDocument.FindFlightsButton;
            Mouse.Click(find);

        }

        public void VerifyNumberofAdultSelection()
        {
            HtmlComboBox adult = new HtmlComboBox();
            adult = SpiceJetFlightBookinWindow.SpiceJetFlightBookinDocument.AdultComboBox;
            Mouse.Click(adult);
        }
        public bool SelectNumberofAdultFromComboBox()
        {
            HtmlComboBox selectadult = new HtmlComboBox();
            selectadult = this.SpiceJetFlightBookinWindow.SpiceJetFlightBookinDocument.AdultComboBox;
            int x = 0, i;

            selectadult.SelectedItem = "2 Adults";


            //for ( i = 0; i < selectadult.Items.Count; i++)
            //{

            //    if (selectadult.Items[i].Name.ToString() != "2 Adults")
            //    {
            //        continue;

            //    }
            //    else
            //    {
            //        x = i;
            //    }

            //}
            //selectadult.SelectedIndex = x;

            if (selectadult.SelectedItem == "2 Adults")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }


}
