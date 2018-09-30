using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Automation_All_Fuctionality
{
   public partial class Form1 : Form
   {
    //  List<Employee> Employee_List=null;
      static Helper helper = new Helper();
      static int employee_count=0;
      public Form1()
      {
         InitializeComponent();
         helper.UpdateCountEvent += UpdateCount;

      }
      private void panel1_Paint(object sender, PaintEventArgs e)
      {

      }

      private void label7_Click(object sender, EventArgs e)
      {

      }

      private void path_of_excel_file_TextChanged(object sender, EventArgs e)
      {
         try
         {
            generate_pdf.Enabled = false;
            if (!string.IsNullOrEmpty(path_of_excel_file.Text) && !string.IsNullOrEmpty(path_of_word_file.Text) && !string.IsNullOrEmpty(text_append_to_filename.Text) && !string.IsNullOrEmpty(path_of_word_folder.Text) && !string.IsNullOrEmpty(path_of_pdf_folder.Text))
            {
               generate_pdf.Enabled = true;
            }
           // employee_count = helper.Read_excel_file(path_of_excel_file.Text);
         }
         catch (Exception exc)
         {
            error_screen2.Visible = true;
            //Controls["PDF_Generator_Panel"].Controls["error_screen2"].Visible = true;
           // progressBar_no_of_pdfs_generated.Value = progressBar_no_of_pdfs_generated.Maximum;
            // if (!String.IsNullOrEmpty(Controls["PDF_Generator_Panel"].Controls["error_screen2"].Text))
            Controls["PDF_Generator_Panel"].Controls["error_screen2"].ForeColor = System.Drawing.Color.Red;
            Controls["PDF_Generator_Panel"].Controls["error_screen2"].Text = "Error" + "\n" + exc.Message;

         }
      }

      private void path_of_excel_file_Leave_Or_LostFocus(object sender, EventArgs e)
      {
         try
         {
            employee_count = helper.Read_excel_file(path_of_excel_file.Text);
         }
         catch (Exception exc)
         {
            error_screen2.Visible = true;
            //Controls["PDF_Generator_Panel"].Controls["error_screen2"].Visible = true;
            // progressBar_no_of_pdfs_generated.Value = progressBar_no_of_pdfs_generated.Maximum;
            // if (!String.IsNullOrEmpty(Controls["PDF_Generator_Panel"].Controls["error_screen2"].Text))
            Controls["PDF_Generator_Panel"].Controls["error_screen2"].ForeColor = System.Drawing.Color.Red;
            Controls["PDF_Generator_Panel"].Controls["error_screen2"].Text = "Error" + "\n" + exc.Message;

         }

      }
      private void path_of_word_file_TextChanged(object sender, EventArgs e)
      {
         generate_pdf.Enabled = false;
         if (!string.IsNullOrEmpty(path_of_excel_file.Text) && !string.IsNullOrEmpty(path_of_word_file.Text) && !string.IsNullOrEmpty(text_append_to_filename.Text) && !string.IsNullOrEmpty(path_of_word_folder.Text) && !string.IsNullOrEmpty(path_of_pdf_folder.Text))
         {
            generate_pdf.Enabled = true;
         }
      }

      private void generate_pdf_Click(object sender, EventArgs e)
      {
         try
         {
            progressBar_no_of_pdfs_generated.Visible = true;
            error_screen2.Text = string.Empty;
            error_screen2.Visible = true;
            count.Text = string.Empty;
            count.Visible = true;
            progressBar_no_of_pdfs_generated.Value = 0;
            progressBar_no_of_pdfs_generated.Minimum = 0;
            // List<Employee> Employee_List = Helper.Read_excel_file(path_of_excel_file.Text);
            //Employee_List = helper.Read_excel_file(path_of_excel_file.Text);
            progressBar_no_of_pdfs_generated.Maximum = employee_count;
            helper.Generate_PDF(path_of_word_file.Text, text_append_to_filename.Text, path_of_pdf_folder.Text, path_of_word_folder.Text);
            //int no_of_PDF_generated;
            //if (int.TryParse(Helper.result, out no_of_PDF_generated))
            //   count.Text = "No Of PDF's Generated " + no_of_PDF_generated;
            //else
            //{
            //   count.Text = "Error" + "\n" + Helper.result;
            //}
         }
         catch (Exception exc)
         {
            error_screen2.Visible = true;
            //Controls["PDF_Generator_Panel"].Controls["error_screen2"].Visible = true;
            progressBar_no_of_pdfs_generated.ForeColor= System.Drawing.Color.Red;
            progressBar_no_of_pdfs_generated.Value = progressBar_no_of_pdfs_generated.Maximum;
            // if (!String.IsNullOrEmpty(Controls["PDF_Generator_Panel"].Controls["error_screen2"].Text))
            Controls["PDF_Generator_Panel"].Controls["error_screen2"].ForeColor = System.Drawing.Color.Red;
            Controls["PDF_Generator_Panel"].Controls["error_screen2"].Text ="Error"+ "\n" + exc.Message;

         }
      }
      private void excelFile_Click(object sender, EventArgs e)
      {
         OpenFileDialog excelfile = new OpenFileDialog();
         excelfile.Title = "Excel File Open File Dialog";
         excelfile.InitialDirectory = @"c:\";
         excelfile.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
         excelfile.FilterIndex = 2;
         excelfile.RestoreDirectory = true;
         if (excelfile.ShowDialog() == DialogResult.OK)
         {
            path_of_excel_file.Text = excelfile.FileName;
         }
      }

      private void wordFile_Click(object sender, EventArgs e)
      {
         OpenFileDialog wordfile = new OpenFileDialog();
         wordfile.Title = "Excel File Open File Dialog";
         wordfile.InitialDirectory = @"c:\";
         wordfile.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
         wordfile.FilterIndex = 2;
         wordfile.RestoreDirectory = true;
         if (wordfile.ShowDialog() == DialogResult.OK)
         {
            path_of_word_file.Text = wordfile.FileName;
         }
      }

      private void text_append_to_filename_TextChanged(object sender, EventArgs e)
      {
         generate_pdf.Enabled = false;
         if (!string.IsNullOrEmpty(path_of_excel_file.Text) && !string.IsNullOrEmpty(path_of_word_file.Text) && !string.IsNullOrEmpty(text_append_to_filename.Text) && !string.IsNullOrEmpty(path_of_word_folder.Text) && !string.IsNullOrEmpty(path_of_pdf_folder.Text))
         {
            generate_pdf.Enabled = true;
         }
      }

      private void path_of_pdf_folder_TextChanged(object sender, EventArgs e)
      {
         generate_pdf.Enabled = false;
         if (!string.IsNullOrEmpty(path_of_excel_file.Text) && !string.IsNullOrEmpty(path_of_word_file.Text) && !string.IsNullOrEmpty(text_append_to_filename.Text) && !string.IsNullOrEmpty(path_of_word_folder.Text) && !string.IsNullOrEmpty(path_of_pdf_folder.Text))
         {
            generate_pdf.Enabled = true;
         }
      }

      private void path_of_word_folder_TextChanged(object sender, EventArgs e)
      {
         generate_pdf.Enabled = false;
         if (!string.IsNullOrEmpty(path_of_excel_file.Text) && !string.IsNullOrEmpty(path_of_word_file.Text) && !string.IsNullOrEmpty(text_append_to_filename.Text) && !string.IsNullOrEmpty(path_of_word_folder.Text) && !string.IsNullOrEmpty(path_of_pdf_folder.Text))
         {
            generate_pdf.Enabled = true;
         }
      }

      private void pdfFolder_Click(object sender, EventArgs e)
      {
         FolderBrowserDialog folderDlg = new FolderBrowserDialog();
         folderDlg.ShowNewFolderButton = true;
         // Show the FolderBrowserDialog.
         DialogResult result = folderDlg.ShowDialog();
         if (result == DialogResult.OK)
         {
            path_of_pdf_folder.Text = folderDlg.SelectedPath;
         }
      }

      private void wordFolder_Click(object sender, EventArgs e)
      {
         FolderBrowserDialog folderDlg = new FolderBrowserDialog();
         folderDlg.ShowNewFolderButton = true;
         // Show the FolderBrowserDialog.
         DialogResult result = folderDlg.ShowDialog();
         if (result == DialogResult.OK)
         {
            path_of_word_folder.Text = folderDlg.SelectedPath;
         }
      }

      private void Next2_Click(object sender, EventArgs e)
      {
         PDF_Generator_Panel.Visible = false;
          Mail_Automation_panel.Visible = true;
         if(Generate_PDF_and_Mail.Checked)
         {
            Path_of_Excel_File_screen3.Text = path_of_excel_file.Text;
            Path_of_Excel_File_screen3.Enabled = false;
            label_Path_Of_Excel_File.Enabled = false;
            excelFile_screen3.Enabled = false;
            Path_Of_PDF_Folder_screen3.Text = path_of_pdf_folder.Text;
            Path_Of_PDF_Folder_screen3.Enabled = false;
            label_Path_Of_PDF_Folder.Enabled = false;
            pdfFolder_screen3.Enabled = false;
         }
      }

      private void Previous2_Click(object sender, EventArgs e)
      {
         count.Text = string.Empty;
         emailsentcounter.Text = string.Empty;
         progressBar_no_of_pdfs_generated.Value = 0;
         error_screen2.Text = string.Empty;
         progressBar_no_of_pdfs_generated.Visible = false;
         PDF_Generator_Panel.Visible = false;
         Mail_Automation_panel.Visible = false;
         if (Generate_PDF_and_Mail.Checked)
         {
            Path_of_Excel_File_screen3.Text = string.Empty;
            Path_of_Excel_File_screen3.Enabled = true;
            label_Path_Of_Excel_File.Enabled = true;
            excelFile_screen3.Enabled = true;
            Path_Of_PDF_Folder_screen3.Text = string.Empty;
            Path_Of_PDF_Folder_screen3.Enabled = true;
            label_Path_Of_PDF_Folder.Enabled = true;
            pdfFolder_screen3.Enabled = true;
         }
         // next1.Visible = true;
      }

 

      private void next1_Click_1(object sender, EventArgs e)
      {
         //Form formr = this;
         //this.PDF_Generator_Panel;
        if(Generate_PDF_and_Mail.Checked == true && Send_Mail_by_PDF_Attached.Checked == false)
            PDF_Generator_Panel.Visible = true;
         if (Generate_PDF_and_Mail.Checked == false && Send_Mail_by_PDF_Attached.Checked == true)
            Mail_Automation_panel.Visible = true;

        // next1.Visible = false;
         generate_pdf.Enabled = false;
         if (!string.IsNullOrEmpty(path_of_excel_file.Text) && !string.IsNullOrEmpty(path_of_word_file.Text) && !string.IsNullOrEmpty(text_append_to_filename.Text) && !string.IsNullOrEmpty(path_of_word_folder.Text) && !string.IsNullOrEmpty(path_of_pdf_folder.Text))
         {
            generate_pdf.Enabled = true;
         }
      }

      //public void Count_Of_PDF_Sent(int c)
      //{
      // count.Text= "No Of PDF's Generated " + c + "/" + Employee_List.Count;
      //   //Controls["PDF_Generator_Panel"].Controls["count"].Text = "No Of PDF's Generated " + count+"/" + Employee_List.Count;
      //   progressBar_no_of_pdfs_generated.Value += 1;
         
      //}
      //public void Count_Of_Email_Sent(int count)
      //{

      //   emailsentcounter.Text= "No Of Email's Sent " + count + "/" + Employee_List.Count;
      //   //Controls["Mail_Automation_panel"].Controls["emailsentcounter"].Text = "No Of Email's Sent " + count +"/"+Employee_List.Count;
      //   EmailSent_progressBar.Value += 1;
      //}

      private void Previous3_Click(object sender, EventArgs e)
      {
         emailsentcounter.Text = string.Empty;
         count.Text = string.Empty;
         EmailSent_progressBar.Value = 0;
         EmailSent_progressBar.Visible = false;
         error_screen3.Text = string.Empty;
         if(Generate_PDF_and_Mail.Checked)
         PDF_Generator_Panel.Visible = true;
         else
            Mail_Automation_panel.Visible = false;
      }

      private void Configuration_Click(object sender, EventArgs e)
      {
         Form form=null;
         if (Generate_PDF_and_Mail.Checked)
         {
            form = new popup("Generate_PDF_and_Mail");
         }
         else
             form = new popup();
         form.Show();
         form.Location = new Point(170, 49);

      }

      private void generate_emails_Click(object sender, EventArgs e)
      {
         EmailSent_progressBar.Visible = true;
         error_screen3.Text = string.Empty;
         error_screen3.Visible = true;
         emailsentcounter.Text = string.Empty;
         emailsentcounter.Visible = true;
         EmailSent_progressBar.Value = 0;
         EmailSent_progressBar.Minimum = 0;
         
         try
         {
            //if (Employee_List == null)
            //   Employee_List = helper.Read_excel_file(Path_of_Excel_File_screen3.Text);
            EmailSent_progressBar.Maximum = employee_count;
            helper.Generate_Email(Path_of_Excel_File_screen3.Text, pathofemailtemplate.Text, emailsubject.Text, Path_Of_PDF_Folder_screen3.Text, text_append_to_filename.Text);

         }
         catch (Exception exc)
         {
            error_screen3.Visible = true;
            // Controls["Mail_Automation_panel"].Controls["error_screen3"].Visible = true;
           // Controls["Mail_Automation_panel"].Controls["EmailSent_progressBar"].ForeColor= System.Drawing.Color.Red;
            EmailSent_progressBar.Value = EmailSent_progressBar.Maximum;
            // if (!String.IsNullOrEmpty(Controls["Mail_Automation_panel"].Controls["error_screen3"].Text))
            Controls["Mail_Automation_panel"].Controls["error_screen3"].ForeColor = System.Drawing.Color.Red;
               Controls["Mail_Automation_panel"].Controls["error_screen3"].Text = "Error" + "\n" + exc.Message;
         }
      }

      private void Generate_PDF_and_Mail_CheckedChanged(object sender, EventArgs e)
      {
         next1.Enabled = false;
      }

      private void excelFile_screen3_Click(object sender, EventArgs e)
      {
         OpenFileDialog excelfile = new OpenFileDialog();
         excelfile.Title = "Excel File Open File Dialog";
         excelfile.InitialDirectory = @"c:\";
         excelfile.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
         excelfile.FilterIndex = 2;
         excelfile.RestoreDirectory = true;
         if (excelfile.ShowDialog() == DialogResult.OK)
         {
            Path_of_Excel_File_screen3.Text = excelfile.FileName;
         }
      }

      private void pdfFolder_screen2_Click(object sender, EventArgs e)
      {
         FolderBrowserDialog folderDlg = new FolderBrowserDialog();
         folderDlg.ShowNewFolderButton = true;
         // Show the FolderBrowserDialog.
         DialogResult result = folderDlg.ShowDialog();
         if (result == DialogResult.OK)
         {
            Path_Of_PDF_Folder_screen3.Text = folderDlg.SelectedPath;
         }
      }

      private void emailtemplatebrowse_Click(object sender, EventArgs e)
      {
         OpenFileDialog emailfile = new OpenFileDialog();
         emailfile.Title = "Excel File Open File Dialog";
         emailfile.InitialDirectory = @"c:\";
         emailfile.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
         emailfile.FilterIndex = 2;
         emailfile.RestoreDirectory = true;
         if (emailfile.ShowDialog() == DialogResult.OK)
         {
            pathofemailtemplate.Text = emailfile.FileName;
         }
      }

      private void Send_Mail_by_PDF_Attached_CheckedChanged(object sender, EventArgs e)
      {
         next1.Enabled = false;
      }

      private void Path_of_Excel_File_screen3_TextChanged(object sender, EventArgs e)
      {
         try
         { 
         generate_emails.Enabled = false;
         if (!string.IsNullOrEmpty(Path_of_Excel_File_screen3.Text) && !string.IsNullOrEmpty(Path_Of_PDF_Folder_screen3.Text) && !string.IsNullOrEmpty(pathofemailtemplate.Text) && !string.IsNullOrEmpty(emailsubject.Text))
         {
            generate_emails.Enabled = true;
         }
        // employee_count = helper.Read_excel_file(Path_of_Excel_File_screen3.Text);
         }
         catch (Exception exc)
         {
            error_screen3.Visible = true;
            // Controls["Mail_Automation_panel"].Controls["error_screen3"].Visible = true;
            // Controls["Mail_Automation_panel"].Controls["EmailSent_progressBar"].ForeColor= System.Drawing.Color.Red;
           // EmailSent_progressBar.Value = EmailSent_progressBar.Maximum;
            // if (!String.IsNullOrEmpty(Controls["Mail_Automation_panel"].Controls["error_screen3"].Text))
            Controls["Mail_Automation_panel"].Controls["error_screen3"].ForeColor = System.Drawing.Color.Red;
            Controls["Mail_Automation_panel"].Controls["error_screen3"].Text = "Error" + "\n" + exc.Message;
         }

      }

      private void Path_of_Excel_File_screen3_Leave_Or_LostFocus(object sender, EventArgs e)
      {
         try
         {
            employee_count = helper.Read_excel_file(Path_of_Excel_File_screen3.Text);
         }
         catch (Exception exc)
         {
            error_screen3.Visible = true;
            // Controls["Mail_Automation_panel"].Controls["error_screen3"].Visible = true;
            // Controls["Mail_Automation_panel"].Controls["EmailSent_progressBar"].ForeColor= System.Drawing.Color.Red;
            // EmailSent_progressBar.Value = EmailSent_progressBar.Maximum;
            // if (!String.IsNullOrEmpty(Controls["Mail_Automation_panel"].Controls["error_screen3"].Text))
            Controls["Mail_Automation_panel"].Controls["error_screen3"].ForeColor = System.Drawing.Color.Red;
            Controls["Mail_Automation_panel"].Controls["error_screen3"].Text = "Error" + "\n" + exc.Message;
         }
      }

      private void Path_Of_PDF_Folder_screen3_TextChanged(object sender, EventArgs e)
      {
         generate_emails.Enabled = false;
         if (!string.IsNullOrEmpty(Path_of_Excel_File_screen3.Text) && !string.IsNullOrEmpty(Path_Of_PDF_Folder_screen3.Text) && !string.IsNullOrEmpty(pathofemailtemplate.Text) && !string.IsNullOrEmpty(emailsubject.Text))
         {
            generate_emails.Enabled = true;
         }
      }

      private void pathofemailtemplate_TextChanged(object sender, EventArgs e)
      {
         generate_emails.Enabled = false;
         if (!string.IsNullOrEmpty(Path_of_Excel_File_screen3.Text) && !string.IsNullOrEmpty(Path_Of_PDF_Folder_screen3.Text) && !string.IsNullOrEmpty(pathofemailtemplate.Text) && !string.IsNullOrEmpty(emailsubject.Text))
         {
            generate_emails.Enabled = true;
         }
      }

      private void emailsubject_TextChanged(object sender, EventArgs e)
      {
         generate_emails.Enabled = false;
         if (!string.IsNullOrEmpty(Path_of_Excel_File_screen3.Text) && !string.IsNullOrEmpty(Path_Of_PDF_Folder_screen3.Text) && !string.IsNullOrEmpty(pathofemailtemplate.Text) && !string.IsNullOrEmpty(emailsubject.Text))
         {
            generate_emails.Enabled = true;
         }
      }

      private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
      {

      }
      void UpdateCount(string msg, int c)
      {
         if (msg.Equals("updatePdfCount"))
         {
            count.Text = "No Of PDF's Generated " + c + "/" + employee_count;
            //Controls["PDF_Generator_Panel"].Controls["count"].Text = "No Of PDF's Generated " + count+"/" + Employee_List.Count;
            progressBar_no_of_pdfs_generated.Value += 1;
         }
         else
         {
            if (msg.Equals("updateEmailCount"))
               emailsentcounter.Text = "No Of Email's Sent " + c + "/" + employee_count;
            //Controls["Mail_Automation_panel"].Controls["emailsentcounter"].Text = "No Of Email's Sent " + count +"/"+Employee_List.Count;
            EmailSent_progressBar.Value += 1;
         }
      }
   }
}
