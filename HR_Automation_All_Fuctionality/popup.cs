using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Automation_All_Fuctionality
{
   public partial class popup : Form
   {
      public popup()
      {
         InitializeComponent();
      }
      public popup(String temp)
      {
         InitializeComponent();
         if (temp.Equals("Generate_PDF_and_Mail"))
         {
            File_Names_To_Be_Attached.Enabled = false;
            label8.Enabled = false;
         }

      
      }

      private void label7_Click(object sender, EventArgs e)
      {

      }

      private void label8_Click(object sender, EventArgs e)
      {

      }

      private void OK_Click(object sender, EventArgs e)
      {
         Form1 form1 = (Form1)System.Windows.Forms.Application.OpenForms["Form1"];
         Helper.UpdateSetting("File_Names_To_Be_Attached", File_Names_To_Be_Attached.Text);
        Helper.UpdateSetting("Oracle_Id", Oracle_Id.Text);
        Helper.UpdateSetting("Employee_Name", Employee_Name.Text);
        Helper.UpdateSetting("Email_Ids", Email_Ids.Text);
        Helper.UpdateSetting("CC", CC.Text);
        Helper.UpdateSetting("BCC", BCC.Text);
        Helper.UpdateSetting("DOB", DOB.Text);
        Helper.UpdateSetting("PAN_NO", PAN_NO.Text);
         popup popup1 = (popup)System.Windows.Forms.Application.OpenForms["popup"];
         form1.Controls["next1"].Enabled = true;
         popup1.Close();

      }

      private void label1_Click(object sender, EventArgs e)
      {

      }
   }
}
