using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Outlook = Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Interop.Word;
using PdfSharp.Pdf;
using System.Text.RegularExpressions;
using System.Configuration;

namespace HR_Automation_All_Fuctionality
{
   class Helper
   {
      // declare delegate 
      public delegate void UpdateCount(string msg, int c);

      //declare event of type delegate
      public event UpdateCount UpdateCountEvent;

      static List<Employee> Employee_List = null;

      // static Form1 form1 = (Form1)System.Windows.Forms.Application.OpenForms["Form1"];
      //static Form1 form1 = new Form1();
      // public static String result;

      //public static void  Subscribe(IObserver<string> observer,string value)
      //{
      //      observer.OnNext(value);
      //}
      public int Read_excel_file(String path_of_excel_file)
      {
         try
         {
            Employee_List = new List<Employee>();
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(@path_of_excel_file);
            Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range range = range = xlWorkSheet.UsedRange;

            int rw = range.Rows.Count;
            int cl = range.Columns.Count;
            UpdateSetting("No_of_colums_in_excel", cl.ToString());
            for (int rCnt = 3; rCnt <= rw; rCnt++)
            {
               Employee_List.Add(new Employee());
               int No_of_colums_in_excel = int.Parse(ConfigurationSettings.AppSettings.Get("No_of_colums_in_excel"));

               for (int cCnt = 1; cCnt <= No_of_colums_in_excel; cCnt++)
               {
                  Employee_List[rCnt - 3].Fields["a" + cCnt] = (range.Cells[rCnt, cCnt] as Excel.Range).Value2.ToString();
               }
            }

         }
         catch (Exception e)
         {
            // form1.OnNext(e.Message);
            throw e;

         }
         return Employee_List.Count;
      }


      public static void UpdateSetting(string key, String value)
      {
         try
         {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save();

            ConfigurationManager.RefreshSection("appSettings");
         }
         catch (Exception e)
         {
            throw e;
         }

      }

      private static string ReadSignature()
      {

         string appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Signatures";
         string signature = string.Empty;
         DirectoryInfo diInfo = new DirectoryInfo(appDataDir);
         try
         {
            if (diInfo.Exists)
            {
               FileInfo[] fiSignature = diInfo.GetFiles("*.htm");

               if (fiSignature.Length > 0)
               {
                  StreamReader sr = new StreamReader(fiSignature[0].FullName, Encoding.Default);
                  signature = sr.ReadToEnd();

                  if (!string.IsNullOrEmpty(signature))
                  {
                     string fileName = fiSignature[0].Name.Replace(fiSignature[0].Extension, string.Empty);
                     signature = signature.Replace(fileName + "_files/", appDataDir + "/" + fileName + "_files/");
                  }
               }
            }
         }
         catch (Exception e)
         {
            throw e;
         }
         return signature;
      }

      private  StringBuilder reademailtext(String pathofemailtemplate)
      {
         //emailbodytext.Clear();
         StringBuilder emailbodytext = new StringBuilder();
         String line;
         try
         {
            // Read the file and display it line by line.
            System.IO.StreamReader file =
               new System.IO.StreamReader(@pathofemailtemplate);
            while ((line = file.ReadLine()) != null)
            {
               emailbodytext.Append(line);
            }
            file.Close();
         }
         catch (Exception e)
         {
            throw e;
         }
         return emailbodytext;
      }

      private static void createlogfile()
      {
         string fileName = AppDomain.CurrentDomain.BaseDirectory + "log.txt";
         try
         {
            // Check if file already exists. If yes, delete it. 
            if (File.Exists(@fileName))
            {
               File.Delete(@fileName);
            }
            FileStream fs = File.Create(@fileName);
            fs.Close();
         }
         catch (Exception e)
         {
            throw e;
         }

      }

      private static void generatelogfile(string error)
      {
         string fileName = AppDomain.CurrentDomain.BaseDirectory + "log.txt";
         try
         {
            using (System.IO.StreamWriter file =
              new System.IO.StreamWriter(@fileName))
            {
               file.WriteLine(error);
               file.Close();
            }
         }
         catch (Exception e)
         {
            throw e;
         }
      }

      public void Generate_Email(String path_of_excel_file,String pathofemailtemplate, String emailsubject, String Path_Of_PDF_Folder_screen,string text_append_to_filename)
      {
         Read_excel_file(path_of_excel_file);
         string Oracle_Id = ConfigurationSettings.AppSettings.Get("Oracle_Id").Trim();
         string Email_Ids = ConfigurationSettings.AppSettings.Get("Email_Ids").Trim();
         string CC = ConfigurationSettings.AppSettings.Get("CC").Trim();
         string BCC = ConfigurationSettings.AppSettings.Get("BCC").Trim();
         string Employee_Name = ConfigurationSettings.AppSettings.Get("Employee_Name").Trim();
         string File_Names_To_Be_Attached = ConfigurationSettings.AppSettings.Get("File_Names_To_Be_Attached").Trim();
         Outlook.Application oApp;
         Outlook.MailItem oMsg;
         Outlook.Attachment oAttach;
         Outlook.Recipients oRecips;
         Outlook.Recipient oRecip;
         Outlook.Recipient recipTo = null;
         Outlook.Recipient recipCc = null;
         Outlook.Recipient recipBcc = null;
         StringBuilder emailBody = null;
         string signature = null;
         int no_of_Emails_Sent = 0;
         string error = null;
         createlogfile();
         String filepath = null;
         foreach (Employee e in Employee_List)
         {

            // Create the Outlook application.
            try
            {
               oApp = new Outlook.Application();
               // Create a new mail item.
               oMsg = (Outlook.MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);
               // Set HTMLBody. 
               //add the body of the email
               emailBody = reademailtext(pathofemailtemplate);
               emailBody.Replace("{Name}", e.Fields[Employee_Name]);
               signature = ReadSignature();
               oMsg.HTMLBody = emailBody.ToString() + " " + signature;
               //Add an attachment.
               if (string.IsNullOrEmpty(File_Names_To_Be_Attached))
               {
                  string fileName=null;
                  if (!string.IsNullOrEmpty(e.Fields[Oracle_Id]) && !string.IsNullOrEmpty(e.Fields[Employee_Name]))
                  {
                     fileName = e.Fields[Oracle_Id] + " - " + e.Fields[Employee_Name] + text_append_to_filename;
                  }
                  else
                  {
                     if (!string.IsNullOrEmpty(e.Fields[Oracle_Id]) && string.IsNullOrEmpty(e.Fields[Employee_Name]))
                     {
                        fileName = e.Fields[Oracle_Id] + text_append_to_filename;
                     }
                     else
                     {
                        if (string.IsNullOrEmpty(e.Fields[Oracle_Id]) && !string.IsNullOrEmpty(e.Fields[Employee_Name]))
                        {
                           fileName = e.Fields[Employee_Name] + text_append_to_filename;
                        }
                     }
                  }
                  filepath = @Path_Of_PDF_Folder_screen + "\\" + fileName;

               }
               else
               {
                  filepath = @Path_Of_PDF_Folder_screen + "\\" + e.Fields[File_Names_To_Be_Attached];
               }
               oAttach = oMsg.Attachments.Add(filepath);
               //Subject line
               oMsg.Subject = emailsubject;
               // Add a recipient For To.
               if (!string.IsNullOrEmpty(Email_Ids))
               {
                  if (!string.IsNullOrEmpty(e.Fields[Email_Ids]))
                  {
                     String[] EmailidTos = (e.Fields[Email_Ids]).Split(',');

                     foreach (String EmailidTo in EmailidTos)
                     {
                        recipTo = oMsg.Recipients.Add(EmailidTo);
                        recipTo.Type = (int)Outlook.OlMailRecipientType.olTo;
                        recipTo.Resolve();
                     }
                  }
               }
               if (!string.IsNullOrEmpty(CC))
               {
                  if (!string.IsNullOrEmpty(e.Fields[CC]))
                  {
                     String[] EmailidCCs = (e.Fields[CC]).Split(',');

                     foreach (String EmailidCC in EmailidCCs)
                     {
                        recipCc = oMsg.Recipients.Add(EmailidCC);
                        recipCc.Type = (int)Outlook.OlMailRecipientType.olCC;
                        recipCc.Resolve();
                     }
                  }
               }
               if (!string.IsNullOrEmpty(BCC))
               {
                  if (!string.IsNullOrEmpty(e.Fields[BCC]))
                  {
                     String[] EmailidBCCs = (e.Fields[BCC]).Split(',');

                     foreach (String EmailidBCC in EmailidBCCs)
                     {
                        recipBcc = oMsg.Recipients.Add(EmailidBCC);
                        recipBcc.Type = (int)Outlook.OlMailRecipientType.olBCC;
                        recipBcc.Resolve();
                     }
                  }
               }
               if (recipTo.Resolved || recipCc.Resolved || recipBcc.Resolved)
               {
                  // Send.
                  oMsg.Send();
                  no_of_Emails_Sent++;
                  //form1.Count_Of_Email_Sent(no_of_Emails_Sent);
                  UpdateCountEvent("updateEmailCount", no_of_Emails_Sent);
               }
            }
            catch (Exception exp)
            {
               throw exp;
            }


         }
         generatelogfile(error);
         // Clean up.
         oRecip = null;
         oRecips = null;
         oMsg = null;
         oApp = null;
      }

      public void Generate_PDF(String path_of_word_file, String text_append_to_filename, String path_of_pdf_folder, String path_of_word_folder)
      {
         string Oracle_Id = ConfigurationSettings.AppSettings.Get("Oracle_Id").Trim();
         string Employee_Name = ConfigurationSettings.AppSettings.Get("Employee_Name").Trim();
         string PAN_NO = ConfigurationSettings.AppSettings.Get("PAN_NO").Trim();
         string File_Names_To_Be_Attached = ConfigurationSettings.AppSettings.Get("File_Names_To_Be_Attached").Trim();
         string DOB = ConfigurationSettings.AppSettings.Get("DOB");
         int noOfPDFSent = 0;
         Object oMissing = System.Reflection.Missing.Value;
         Object oTrue = true;
         Object oFalse = false;
         Application oWord = new Application();
         Document oWordDoc = new Document();
         oWord.Visible = false;
         Object oTemplatePath = @path_of_word_file;
         //string PDFDirectory = @path_of_pdf_folder + "\\" + "PDF_Files";
         //string WORDDirectory = @path_of_word_folder + "\\" + "WORD_Files";
         string PDFDirectory = @path_of_pdf_folder;
         string WORDDirectory = @path_of_word_folder;
         Directory.CreateDirectory(PDFDirectory);
         Directory.CreateDirectory(WORDDirectory);
         string fileName = null;
         //  oWordDoc = oWord.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);
         foreach (Employee emp_info in Employee_List)
         {
            try
            {
               if (!string.IsNullOrEmpty(emp_info.Fields[Oracle_Id]) && !string.IsNullOrEmpty(emp_info.Fields[Employee_Name]))
               {
                  fileName = emp_info.Fields[Oracle_Id] + " - " + emp_info.Fields[Employee_Name] + text_append_to_filename;
               }
               else
               {
                  if (!string.IsNullOrEmpty(emp_info.Fields[Oracle_Id]) && string.IsNullOrEmpty(emp_info.Fields[Employee_Name]))
                  {
                     fileName = emp_info.Fields[Oracle_Id] + text_append_to_filename;
                  }
                  else
                  {
                     if (string.IsNullOrEmpty(emp_info.Fields[Oracle_Id]) && !string.IsNullOrEmpty(emp_info.Fields[Employee_Name]))
                     {
                        fileName = emp_info.Fields[Employee_Name] + text_append_to_filename;
                     }
                  }
               }
               // Console.WriteLine("Processing {0} letter for {1}, request {2} of {3}", this.MI_Type, emp_info.EmployeeNam, counter++, employees.MI_list.Count);
               oWordDoc = oWord.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);
               foreach (Field myMergeField in oWordDoc.Fields)
               {

                  Range rngFieldCode = myMergeField.Code;
                  String fieldText = rngFieldCode.Text;
                  if (fieldText.StartsWith(" MERGEFIELD"))
                  {
                     Int32 endMerge = fieldText.IndexOf("\\");
                     Int32 fieldNameLength = fieldText.Length - endMerge;
                     int No_of_colums_in_excel = int.Parse(ConfigurationSettings.AppSettings.Get("No_of_colums_in_excel"));
                     String fieldName = fieldText.Substring(11).Trim();
                     fieldName = fieldName.Trim();
                     bool result = Regex.IsMatch(fieldName, @"[""'\\]+");
                     if (result)
                     {
                        fieldName = fieldName.Trim('"');
                        fieldName = fieldName.Trim('\\');
                        //final = (fieldName.Substring((fieldName.Length - 1), (value.Length - 1)).Trim());
                     }
                     //String anum = fieldName;
                     int Field_value;
                     // if (int.Parse(anum.Substring(1, anum.Length - 1)) > 6)
                     if (!fieldName.Equals(Oracle_Id) && !fieldName.Equals(PAN_NO) && !fieldName.Equals(DOB))
                     {

                        if ((int.TryParse(emp_info.Fields[fieldName], out Field_value)))
                        {
                           emp_info.Fields[fieldName] = string.Format("{0:n0}", Field_value);
                        }
                     }
                     //fieldName = fieldName.Trim();

                     if (fieldName != "")
                     {
                        myMergeField.Select();
                        oWord.Selection.TypeText(emp_info.Fields[fieldName]);
                     }
                  }
               }
               String savePath_string_pdf = PDFDirectory + "\\" + fileName;
               Object savePathpdf = savePath_string_pdf;
               String savePath_string_word = WORDDirectory + "\\" + fileName;
               Object savePathword = savePath_string_word;
               object fileFormatpdf = WdSaveFormat.wdFormatPDF;
               object fileFormatword = WdSaveFormat.wdFormatDocument;
               object saveChanges = Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges;
               //saving wordfiles
               oWordDoc.SaveAs2(ref savePathword, ref fileFormatword, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing);
              
               //saving pdfs
               oWordDoc.SaveAs2(ref savePathpdf, ref fileFormatpdf, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing);
               oWordDoc.Close(ref saveChanges, ref oMissing, ref oMissing);
               //emp_info.Fields.Add("FileName", fileName + ".pdf");
               PdfDocument document = PdfSharp.Pdf.IO.PdfReader.Open(savePath_string_pdf + ".pdf");
               PdfSharp.Pdf.Security.PdfSecuritySettings securitySettings = document.SecuritySettings;

               // Setting one of the passwords automatically sets the security level to 
               // PdfDocumentSecurityLevel.Encrypted128Bit.
               if (!String.IsNullOrEmpty(emp_info.Fields[PAN_NO]))
               {
                  securitySettings.UserPassword = emp_info.Fields[PAN_NO];
               }
               else
               {
                  if (!String.IsNullOrEmpty(emp_info.Fields[DOB]))
                     securitySettings.UserPassword = emp_info.Fields[DOB];
               }
               securitySettings.OwnerPassword = "owner";
               // Don't use 40 bit encryption unless needed for compatibility reasons
               //securitySettings.DocumentSecurityLevel = PdfDocumentSecurityLevel.Encrypted40Bit;

               // Restrict some rights.
               securitySettings.PermitAccessibilityExtractContent = false;
               securitySettings.PermitAnnotations = false;
               securitySettings.PermitAssembleDocument = false;
               securitySettings.PermitExtractContent = false;
               securitySettings.PermitFormsFill = true;
               securitySettings.PermitFullQualityPrint = true;
               securitySettings.PermitModifyDocument = true;
               securitySettings.PermitPrint = true;

               // Save the document...
               document.Save(savePath_string_pdf + ".pdf");
               document.Close();
               noOfPDFSent++;
               //result = count.ToString();
               //Subscribe(observe, count.ToString());
               //Form1.OnNext(count1.ToString());
               //  form1.Count_Of_PDF_Sent(count);
               UpdateCountEvent("updatePdfCount", noOfPDFSent);
            }
            catch (Exception e)
            {
               //result += e.ToString();
               //Subscribe(observe, e.ToString());
               //Form1.OnNext(e.Message);
               throw e;
            }
         }


      }
   }
}




