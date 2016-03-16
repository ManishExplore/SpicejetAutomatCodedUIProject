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
using Spicejet.com.HomepageClasses;
using Spicejet.com.BookingPageClasses;




namespace Spicejet.com
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class Homepagetest
    {
        // Here we are making the object of each and every class this is at top most level because of do not declared at each level of the method just use it.
        Homepagehelper help = new Homepagehelper();
        Homepage hp = new Homepage();
        BookingPage bp = new BookingPage();
        Logger lg = new Logger();
        public Homepagetest()
        {
        }
        // This is the Data Derivan concept in Coded Ui where you have to take input or comparision of output from the CSV file.
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\C:\\Users\\Manish.Mishra\\documents\\visual studio 2013\\Projects\\Spicejet.com\\Spicejet.com\\Url.csv", "Url#csv", DataAccessMethod.Sequential), DeploymentItem("Url.csv"), TestMethod] 
        public void Verifylaunchingthebrowser()
        {
            try
            {
                Homepagehelper help = new Homepagehelper();
                Homepage hp = new Homepage();
                //Here we are fatching the data from the csv file Url is the data row name in the csv file.
                string url = TestContext.DataRow["Url"].ToString();
                // Now here i am passing the url thing to this function.
                help.LaunchBrowserusingcsv(TestContext.DataRow["Url"].ToString());
               // and finally we have to verify using Asser function the action performing by code is doing correctly or not .
                Assert.IsTrue(hp.VerifyBrowserLuanc());
                // Here we are using the logger function to log the detail of the result and all to keep track of of the test cases.
                lg.WriteTestResultsToCSV("Verifylaunchingthebrowser", "pass");

            }
            catch(Exception ex)
            {
                Assert.IsTrue(false);
            }
            
        }
        [TestMethod]
        public void VerifyHyperlink()
        {
            try
            {
                help.LaunchBrowser();
                Assert.IsTrue(hp.VerifyAboutusHyperlink());
            }
           catch(Exception ex)
            {
                Assert.IsTrue(false);
            }
            
        }

        [TestMethod]
        public void VerifyContactHyperlink()
        {
            try
            {
                help.LaunchBrowser();
                Assert.IsTrue(hp.VerifyContactusHyperlink());
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }

        }

         [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\C:\\Users\\Manish.Mishra\\documents\\visual studio 2013\\Projects\\Spicejet.com\\Spicejet.com\\Testresult.csv", "Testresult#csv", DataAccessMethod.Sequential), DeploymentItem("Testresult.csv"), TestMethod]
        public void Verifyselectionoption()
        {
            try
            {
                //Arrange
                help.LaunchBrowser();
                
                //Act
                hp.SelectLeavefromOption();                

                //Assert
                Assert.IsTrue(hp.VerifyLeavefromListoptionisSelected(TestContext.DataRow["Leave From"].ToString()));
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }

        }

        [TestMethod]
        public void VerifyselectionoptionforGoingto()
        {
            try
            {
                help.LaunchBrowser();
                hp.SelectLeavefromOption();

                hp.SelectGoingtoOption();
                Assert.IsTrue(hp.VerifyGoingtoListoptionisSelected());
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }

        }
        [TestMethod]

        public void verifyFromDateSelectionOption()
        {
            try
            {
                help.LaunchBrowser();
                hp.SelectLeavefromOption();
                hp.SelectGoingtoOption();
                hp.SelectFromDate();
                Assert.IsTrue(hp.VerifyFromDate());
            }
            catch(Exception ex)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]

        public void verifyToDateSelectionOption()
        {
            try
            {
                help.LaunchBrowser();
                hp.SelectLeavefromOption();
                hp.SelectGoingtoOption();
                hp.SelectFromDate();
                hp.SelectToDate();
                Assert.IsTrue(hp.VerifyToDate());
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]

        public void verifyBookingFlightButton()
        {
            try
            {
                help.LaunchBrowser();
                hp.SelectLeavefromOption();
                hp.SelectGoingtoOption();
                hp.SelectFromDate();
                hp.SelectToDate();
                hp.VerifyClickonFindFlight();
                Assert.IsTrue(bp.VerifyRediractiononBookingPage());
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]

        public void verifyAdultSelection()
        {
            try
            {
                help.LaunchBrowser();
                hp.SelectLeavefromOption();
                hp.SelectGoingtoOption();
                hp.SelectFromDate();
                hp.SelectToDate();

                hp.SelectNumberofAdultFromComboBox();
                //hp.VerifyClickonFindFlight();
               // Assert.IsTrue( hp.VerifyNumberofAdultSelection());
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false);
            }
        }
        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        //Use TestInitialize to run code before running each test 
        [TestInitialize()]
        public void MyTestInitialize()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
           
        }

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
    }
}
