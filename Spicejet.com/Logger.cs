﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Spicejet.com
{
    class Logger
    {
        /// <summary>
        /// This method is used to write test results into a .CSV file
        /// </summary>
        /// <remarks>
        /// e.g.:
        /// ReusableCode.Logger.WriteTestResultsToCSV("<TestCaseName>","pass");
        /// </remarks>
        /// <param name="testName">the TestCaseName</param>
        /// <param name="result">the result of the test execution</param>
        /// <returns>Collection</returns>


        public void WriteTestResultsToCSV(string testName, string result, Exception exception = null)
        {
            try
            {

                // Below is the file path which is automaticaly Created and stored in the below path
                string resultsFilePath = @"..\..\Results\Results.csv";
                string exceptionDetails = "";
                if (exception != null)
                {
                    // If exception is occured then is showes the below messages 
                    exceptionDetails = exception.Message;
                    if (exception.InnerException != null)
                    {
                        exceptionDetails += "---Internal Exception:" + exception.InnerException.Message.ToString();
                    }
                    exceptionDetails = exceptionDetails.Replace("\r", "");
                    exceptionDetails = exceptionDetails.Replace("\n", "");
                }
                // If the file is not created or file is created some where else then its check the result
                if (System.IO.Directory.Exists(resultsFilePath) == false)
                {
                    System.IO.Directory.CreateDirectory(resultsFilePath);

                }
                // Its appent in the below formate 
                resultsFilePath = resultsFilePath + "\\";
                string fileName = Path.Combine(resultsFilePath + "TestResults_" + DateTime.Now.Day + "_" + DateTime.Now.Month + ".csv");
                string delimiter = ",";

                if (!System.IO.File.Exists(fileName))
                {

                    using (StreamWriter w = new StreamWriter(fileName, true))
                    {

                        string headers = "TestName" + delimiter + "Result" + delimiter + "Description/Comments" + delimiter + "Script Executed On";
                        w.WriteLine(headers);
                        string date = DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Year.ToString() + "  -  " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
                        //Write the test result to the file
                        w.WriteLine(testName + delimiter + result + delimiter + exceptionDetails + delimiter + date);

                        w.Flush();
                    }

                }

                else
                {
                    using (StreamWriter w = new StreamWriter(fileName, true))
                    {
                        string date = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
                        //Write the test result to the file
                        w.WriteLine(testName + delimiter + result + delimiter + exceptionDetails + delimiter + date);

                        w.Flush();
                    }

                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("because it is being used by another process"))
                    MessageBox.Show("Test Results file might be open. Please close the file and restart the test");
                throw ex;
            }

        }

    }
}
