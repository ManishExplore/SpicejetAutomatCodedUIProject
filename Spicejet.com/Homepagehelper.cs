using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace Spicejet.com
{
    public class Homepagehelper
    {
        public void LaunchBrowser()
        {
            //BrowserWindow bObj = new BrowserWindow();
            //bObj.l

            BrowserWindow.Launch("www.spicejet.com/");


        }

        public void LaunchBrowserusingcsv(String s)
        {
            //BrowserWindow bObj = new BrowserWindow();
            //bObj.l

            BrowserWindow.Launch(s);


        }


       

    }

}
