namespace HR_Automation_All_Fuctionality
{
   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.Generate_PDF_and_Mail = new System.Windows.Forms.RadioButton();
         this.Send_Mail_by_PDF_Attached = new System.Windows.Forms.RadioButton();
         this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
         this.PDF_Generator_Panel = new System.Windows.Forms.Panel();
         this.pdfFolder = new System.Windows.Forms.Button();
         this.wordFile = new System.Windows.Forms.Button();
         this.excelFile = new System.Windows.Forms.Button();
         this.count = new System.Windows.Forms.Label();
         this.generate_pdf = new System.Windows.Forms.Button();
         this.text_append_to_filename = new System.Windows.Forms.TextBox();
         this.label7 = new System.Windows.Forms.Label();
         this.path_of_word_folder = new System.Windows.Forms.TextBox();
         this.path_of_pdf_folder = new System.Windows.Forms.TextBox();
         this.label6 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.path_of_word_file = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.path_of_excel_file = new System.Windows.Forms.TextBox();
         this.progressBar_no_of_pdfs_generated = new System.Windows.Forms.ProgressBar();
         this.error_screen2 = new System.Windows.Forms.Label();
         this.Previous2 = new System.Windows.Forms.Button();
         this.Next2 = new System.Windows.Forms.Button();
         this.wordFolder = new System.Windows.Forms.Button();
         this.Mail_Automation_panel = new System.Windows.Forms.Panel();
         this.Previous3 = new System.Windows.Forms.Button();
         this.error_screen3 = new System.Windows.Forms.Label();
         this.emailsentcounter = new System.Windows.Forms.Label();
         this.EmailSent_progressBar = new System.Windows.Forms.ProgressBar();
         this.generate_emails = new System.Windows.Forms.Button();
         this.emailtemplatebrowse = new System.Windows.Forms.Button();
         this.pdfFolder_screen3 = new System.Windows.Forms.Button();
         this.excelFile_screen3 = new System.Windows.Forms.Button();
         this.emailsubject = new System.Windows.Forms.TextBox();
         this.pathofemailtemplate = new System.Windows.Forms.TextBox();
         this.Path_Of_PDF_Folder_screen3 = new System.Windows.Forms.TextBox();
         this.Path_of_Excel_File_screen3 = new System.Windows.Forms.TextBox();
         this.lable4 = new System.Windows.Forms.Label();
         this.lable3 = new System.Windows.Forms.Label();
         this.label_Path_Of_PDF_Folder = new System.Windows.Forms.Label();
         this.label_Path_Of_Excel_File = new System.Windows.Forms.Label();
         this.next1 = new System.Windows.Forms.Button();
         this.Configuration = new System.Windows.Forms.Button();
         this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
         ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
         this.PDF_Generator_Panel.SuspendLayout();
         this.Mail_Automation_panel.SuspendLayout();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(251, 32);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(216, 32);
         this.label1.TabIndex = 0;
         this.label1.Text = "HR Automation";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(48, 145);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(395, 16);
         this.label2.TabIndex = 1;
         this.label2.Text = "Please select from the following the fuctionality to be implemented";
         // 
         // Generate_PDF_and_Mail
         // 
         this.Generate_PDF_and_Mail.AutoSize = true;
         this.Generate_PDF_and_Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Generate_PDF_and_Mail.Location = new System.Drawing.Point(51, 202);
         this.Generate_PDF_and_Mail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.Generate_PDF_and_Mail.Name = "Generate_PDF_and_Mail";
         this.Generate_PDF_and_Mail.Size = new System.Drawing.Size(169, 20);
         this.Generate_PDF_and_Mail.TabIndex = 3;
         this.Generate_PDF_and_Mail.TabStop = true;
         this.Generate_PDF_and_Mail.Text = "Generate PDF and Mail.";
         this.Generate_PDF_and_Mail.UseVisualStyleBackColor = true;
         this.Generate_PDF_and_Mail.CheckedChanged += new System.EventHandler(this.Generate_PDF_and_Mail_CheckedChanged);
         // 
         // Send_Mail_by_PDF_Attached
         // 
         this.Send_Mail_by_PDF_Attached.AutoSize = true;
         this.Send_Mail_by_PDF_Attached.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Send_Mail_by_PDF_Attached.Location = new System.Drawing.Point(51, 252);
         this.Send_Mail_by_PDF_Attached.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.Send_Mail_by_PDF_Attached.Name = "Send_Mail_by_PDF_Attached";
         this.Send_Mail_by_PDF_Attached.Size = new System.Drawing.Size(193, 20);
         this.Send_Mail_by_PDF_Attached.TabIndex = 4;
         this.Send_Mail_by_PDF_Attached.TabStop = true;
         this.Send_Mail_by_PDF_Attached.Text = "Send Mail by PDF Attached.";
         this.Send_Mail_by_PDF_Attached.UseVisualStyleBackColor = true;
         this.Send_Mail_by_PDF_Attached.CheckedChanged += new System.EventHandler(this.Send_Mail_by_PDF_Attached_CheckedChanged);
         // 
         // fileSystemWatcher1
         // 
         this.fileSystemWatcher1.EnableRaisingEvents = true;
         this.fileSystemWatcher1.SynchronizingObject = this;
         // 
         // PDF_Generator_Panel
         // 
         this.PDF_Generator_Panel.Controls.Add(this.pdfFolder);
         this.PDF_Generator_Panel.Controls.Add(this.wordFile);
         this.PDF_Generator_Panel.Controls.Add(this.excelFile);
         this.PDF_Generator_Panel.Controls.Add(this.count);
         this.PDF_Generator_Panel.Controls.Add(this.generate_pdf);
         this.PDF_Generator_Panel.Controls.Add(this.text_append_to_filename);
         this.PDF_Generator_Panel.Controls.Add(this.label7);
         this.PDF_Generator_Panel.Controls.Add(this.path_of_word_folder);
         this.PDF_Generator_Panel.Controls.Add(this.path_of_pdf_folder);
         this.PDF_Generator_Panel.Controls.Add(this.label6);
         this.PDF_Generator_Panel.Controls.Add(this.label5);
         this.PDF_Generator_Panel.Controls.Add(this.path_of_word_file);
         this.PDF_Generator_Panel.Controls.Add(this.label4);
         this.PDF_Generator_Panel.Controls.Add(this.label3);
         this.PDF_Generator_Panel.Controls.Add(this.path_of_excel_file);
         this.PDF_Generator_Panel.Controls.Add(this.progressBar_no_of_pdfs_generated);
         this.PDF_Generator_Panel.Controls.Add(this.error_screen2);
         this.PDF_Generator_Panel.Controls.Add(this.Previous2);
         this.PDF_Generator_Panel.Controls.Add(this.Next2);
         this.PDF_Generator_Panel.Controls.Add(this.wordFolder);
         this.PDF_Generator_Panel.Location = new System.Drawing.Point(-3, -1);
         this.PDF_Generator_Panel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.PDF_Generator_Panel.Name = "PDF_Generator_Panel";
         this.PDF_Generator_Panel.Size = new System.Drawing.Size(664, 705);
         this.PDF_Generator_Panel.TabIndex = 6;
         this.PDF_Generator_Panel.Visible = false;
         this.PDF_Generator_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
         // 
         // pdfFolder
         // 
         this.pdfFolder.Location = new System.Drawing.Point(574, 164);
         this.pdfFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.pdfFolder.Name = "pdfFolder";
         this.pdfFolder.Size = new System.Drawing.Size(73, 26);
         this.pdfFolder.TabIndex = 14;
         this.pdfFolder.Text = "Browse";
         this.pdfFolder.UseVisualStyleBackColor = true;
         this.pdfFolder.Click += new System.EventHandler(this.pdfFolder_Click);
         // 
         // wordFile
         // 
         this.wordFile.Location = new System.Drawing.Point(574, 116);
         this.wordFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.wordFile.Name = "wordFile";
         this.wordFile.Size = new System.Drawing.Size(73, 26);
         this.wordFile.TabIndex = 13;
         this.wordFile.Text = "Browse";
         this.wordFile.UseVisualStyleBackColor = true;
         this.wordFile.Click += new System.EventHandler(this.wordFile_Click);
         // 
         // excelFile
         // 
         this.excelFile.Location = new System.Drawing.Point(574, 63);
         this.excelFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.excelFile.Name = "excelFile";
         this.excelFile.Size = new System.Drawing.Size(73, 26);
         this.excelFile.TabIndex = 12;
         this.excelFile.Text = "Browse";
         this.excelFile.UseVisualStyleBackColor = true;
         this.excelFile.Click += new System.EventHandler(this.excelFile_Click);
         // 
         // count
         // 
         this.count.AutoSize = true;
         this.count.Location = new System.Drawing.Point(248, 411);
         this.count.Name = "count";
         this.count.Size = new System.Drawing.Size(0, 16);
         this.count.TabIndex = 11;
         // 
         // generate_pdf
         // 
         this.generate_pdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.generate_pdf.Location = new System.Drawing.Point(250, 336);
         this.generate_pdf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.generate_pdf.Name = "generate_pdf";
         this.generate_pdf.Size = new System.Drawing.Size(168, 65);
         this.generate_pdf.TabIndex = 10;
         this.generate_pdf.Text = "Generate PDF";
         this.generate_pdf.UseVisualStyleBackColor = true;
         this.generate_pdf.Click += new System.EventHandler(this.generate_pdf_Click);
         // 
         // text_append_to_filename
         // 
         this.text_append_to_filename.Location = new System.Drawing.Point(155, 271);
         this.text_append_to_filename.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.text_append_to_filename.Name = "text_append_to_filename";
         this.text_append_to_filename.Size = new System.Drawing.Size(400, 22);
         this.text_append_to_filename.TabIndex = 9;
         this.text_append_to_filename.TextChanged += new System.EventHandler(this.text_append_to_filename_TextChanged);
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(20, 274);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(116, 16);
         this.label7.TabIndex = 8;
         this.label7.Text = "Text To Be Appended:";
         this.label7.Click += new System.EventHandler(this.label7_Click);
         // 
         // path_of_word_folder
         // 
         this.path_of_word_folder.Location = new System.Drawing.Point(155, 219);
         this.path_of_word_folder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.path_of_word_folder.Name = "path_of_word_folder";
         this.path_of_word_folder.Size = new System.Drawing.Size(400, 22);
         this.path_of_word_folder.TabIndex = 7;
         this.path_of_word_folder.TextChanged += new System.EventHandler(this.path_of_word_folder_TextChanged);
         // 
         // path_of_pdf_folder
         // 
         this.path_of_pdf_folder.Location = new System.Drawing.Point(155, 161);
         this.path_of_pdf_folder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.path_of_pdf_folder.Name = "path_of_pdf_folder";
         this.path_of_pdf_folder.Size = new System.Drawing.Size(400, 22);
         this.path_of_pdf_folder.TabIndex = 6;
         this.path_of_pdf_folder.TextChanged += new System.EventHandler(this.path_of_pdf_folder_TextChanged);
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(20, 223);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(107, 16);
         this.label6.TabIndex = 5;
         this.label6.Text = "Path Of Word Folder:";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(20, 164);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(104, 16);
         this.label5.TabIndex = 4;
         this.label5.Text = "Path Of PDF Folder:";
         // 
         // path_of_word_file
         // 
         this.path_of_word_file.Location = new System.Drawing.Point(155, 112);
         this.path_of_word_file.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.path_of_word_file.Name = "path_of_word_file";
         this.path_of_word_file.Size = new System.Drawing.Size(400, 22);
         this.path_of_word_file.TabIndex = 3;
         this.path_of_word_file.TextChanged += new System.EventHandler(this.path_of_word_file_TextChanged);
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(20, 116);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(93, 16);
         this.label4.TabIndex = 2;
         this.label4.Text = "Path Of Word File:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(20, 73);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(94, 16);
         this.label3.TabIndex = 1;
         this.label3.Text = "Path Of Excel File:";
         // 
         // path_of_excel_file
         // 
         this.path_of_excel_file.Location = new System.Drawing.Point(155, 64);
         this.path_of_excel_file.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.path_of_excel_file.Name = "path_of_excel_file";
         this.path_of_excel_file.Size = new System.Drawing.Size(400, 22);
         this.path_of_excel_file.TabIndex = 0;
         this.path_of_excel_file.TextChanged += new System.EventHandler(this.path_of_excel_file_TextChanged);
         this.path_of_excel_file.Leave += new System.EventHandler(this.path_of_excel_file_Leave_Or_LostFocus);
         this.path_of_excel_file.LostFocus += new System.EventHandler(this.path_of_excel_file_Leave_Or_LostFocus);
         // 
         // progressBar_no_of_pdfs_generated
         // 
         this.progressBar_no_of_pdfs_generated.Location = new System.Drawing.Point(11, 430);
         this.progressBar_no_of_pdfs_generated.Name = "progressBar_no_of_pdfs_generated";
         this.progressBar_no_of_pdfs_generated.Size = new System.Drawing.Size(623, 23);
         this.progressBar_no_of_pdfs_generated.TabIndex = 18;
         this.progressBar_no_of_pdfs_generated.Visible = false;
         // 
         // error_screen2
         // 
         this.error_screen2.AutoSize = true;
         this.error_screen2.Location = new System.Drawing.Point(11, 491);
         this.error_screen2.Name = "error_screen2";
         this.error_screen2.Size = new System.Drawing.Size(33, 16);
         this.error_screen2.TabIndex = 19;
         this.error_screen2.Text = "Error";
         this.error_screen2.Visible = false;
         // 
         // Previous2
         // 
         this.Previous2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Previous2.Location = new System.Drawing.Point(23, 634);
         this.Previous2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.Previous2.Name = "Previous2";
         this.Previous2.Size = new System.Drawing.Size(112, 44);
         this.Previous2.TabIndex = 17;
         this.Previous2.Text = "Previous";
         this.Previous2.UseVisualStyleBackColor = true;
         this.Previous2.Click += new System.EventHandler(this.Previous2_Click);
         // 
         // Next2
         // 
         this.Next2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Next2.Location = new System.Drawing.Point(535, 634);
         this.Next2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.Next2.Name = "Next2";
         this.Next2.Size = new System.Drawing.Size(112, 44);
         this.Next2.TabIndex = 16;
         this.Next2.Text = "Next";
         this.Next2.UseVisualStyleBackColor = true;
         this.Next2.Click += new System.EventHandler(this.Next2_Click);
         // 
         // wordFolder
         // 
         this.wordFolder.Location = new System.Drawing.Point(574, 218);
         this.wordFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.wordFolder.Name = "wordFolder";
         this.wordFolder.Size = new System.Drawing.Size(73, 26);
         this.wordFolder.TabIndex = 15;
         this.wordFolder.Text = "Browse";
         this.wordFolder.UseVisualStyleBackColor = true;
         this.wordFolder.Click += new System.EventHandler(this.wordFolder_Click);
         // 
         // Mail_Automation_panel
         // 
         this.Mail_Automation_panel.Controls.Add(this.Previous3);
         this.Mail_Automation_panel.Controls.Add(this.error_screen3);
         this.Mail_Automation_panel.Controls.Add(this.emailsentcounter);
         this.Mail_Automation_panel.Controls.Add(this.EmailSent_progressBar);
         this.Mail_Automation_panel.Controls.Add(this.generate_emails);
         this.Mail_Automation_panel.Controls.Add(this.emailtemplatebrowse);
         this.Mail_Automation_panel.Controls.Add(this.pdfFolder_screen3);
         this.Mail_Automation_panel.Controls.Add(this.excelFile_screen3);
         this.Mail_Automation_panel.Controls.Add(this.emailsubject);
         this.Mail_Automation_panel.Controls.Add(this.pathofemailtemplate);
         this.Mail_Automation_panel.Controls.Add(this.Path_Of_PDF_Folder_screen3);
         this.Mail_Automation_panel.Controls.Add(this.Path_of_Excel_File_screen3);
         this.Mail_Automation_panel.Controls.Add(this.lable4);
         this.Mail_Automation_panel.Controls.Add(this.lable3);
         this.Mail_Automation_panel.Controls.Add(this.label_Path_Of_PDF_Folder);
         this.Mail_Automation_panel.Controls.Add(this.label_Path_Of_Excel_File);
         this.Mail_Automation_panel.Location = new System.Drawing.Point(-2, 1);
         this.Mail_Automation_panel.Name = "Mail_Automation_panel";
         this.Mail_Automation_panel.Size = new System.Drawing.Size(664, 705);
         this.Mail_Automation_panel.TabIndex = 19;
         this.Mail_Automation_panel.Visible = false;
         // 
         // Previous3
         // 
         this.Previous3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Previous3.Location = new System.Drawing.Point(25, 631);
         this.Previous3.Name = "Previous3";
         this.Previous3.Size = new System.Drawing.Size(111, 44);
         this.Previous3.TabIndex = 15;
         this.Previous3.Text = "Previous";
         this.Previous3.UseVisualStyleBackColor = true;
         this.Previous3.Click += new System.EventHandler(this.Previous3_Click);
         // 
         // error_screen3
         // 
         this.error_screen3.AutoSize = true;
         this.error_screen3.Location = new System.Drawing.Point(20, 462);
         this.error_screen3.Name = "error_screen3";
         this.error_screen3.Size = new System.Drawing.Size(33, 16);
         this.error_screen3.TabIndex = 14;
         this.error_screen3.Text = "Error";
         this.error_screen3.Visible = false;
         // 
         // emailsentcounter
         // 
         this.emailsentcounter.AutoSize = true;
         this.emailsentcounter.Location = new System.Drawing.Point(250, 367);
         this.emailsentcounter.Name = "emailsentcounter";
         this.emailsentcounter.Size = new System.Drawing.Size(0, 16);
         this.emailsentcounter.TabIndex = 13;
         // 
         // EmailSent_progressBar
         // 
         this.EmailSent_progressBar.Location = new System.Drawing.Point(7, 386);
         this.EmailSent_progressBar.Name = "EmailSent_progressBar";
         this.EmailSent_progressBar.Size = new System.Drawing.Size(629, 24);
         this.EmailSent_progressBar.TabIndex = 12;
         this.EmailSent_progressBar.Visible = false;
         // 
         // generate_emails
         // 
         this.generate_emails.Enabled = false;
         this.generate_emails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.generate_emails.Location = new System.Drawing.Point(253, 288);
         this.generate_emails.Name = "generate_emails";
         this.generate_emails.Size = new System.Drawing.Size(168, 65);
         this.generate_emails.TabIndex = 11;
         this.generate_emails.Text = "Generate Emails";
         this.generate_emails.UseVisualStyleBackColor = true;
         this.generate_emails.Click += new System.EventHandler(this.generate_emails_Click);
         // 
         // emailtemplatebrowse
         // 
         this.emailtemplatebrowse.Location = new System.Drawing.Point(580, 150);
         this.emailtemplatebrowse.Name = "emailtemplatebrowse";
         this.emailtemplatebrowse.Size = new System.Drawing.Size(75, 23);
         this.emailtemplatebrowse.TabIndex = 10;
         this.emailtemplatebrowse.Text = "Browse";
         this.emailtemplatebrowse.UseVisualStyleBackColor = true;
         this.emailtemplatebrowse.Click += new System.EventHandler(this.emailtemplatebrowse_Click);
         // 
         // pdfFolder_screen3
         // 
         this.pdfFolder_screen3.Location = new System.Drawing.Point(580, 101);
         this.pdfFolder_screen3.Name = "pdfFolder_screen3";
         this.pdfFolder_screen3.Size = new System.Drawing.Size(75, 23);
         this.pdfFolder_screen3.TabIndex = 9;
         this.pdfFolder_screen3.Text = "Browse";
         this.pdfFolder_screen3.UseVisualStyleBackColor = true;
         this.pdfFolder_screen3.Click += new System.EventHandler(this.pdfFolder_screen2_Click);
         // 
         // excelFile_screen3
         // 
         this.excelFile_screen3.Location = new System.Drawing.Point(580, 60);
         this.excelFile_screen3.Name = "excelFile_screen3";
         this.excelFile_screen3.Size = new System.Drawing.Size(75, 23);
         this.excelFile_screen3.TabIndex = 8;
         this.excelFile_screen3.Text = "Browse";
         this.excelFile_screen3.UseVisualStyleBackColor = true;
         this.excelFile_screen3.Click += new System.EventHandler(this.excelFile_screen3_Click);
         // 
         // emailsubject
         // 
         this.emailsubject.Location = new System.Drawing.Point(163, 206);
         this.emailsubject.Name = "emailsubject";
         this.emailsubject.Size = new System.Drawing.Size(394, 22);
         this.emailsubject.TabIndex = 7;
         this.emailsubject.TextChanged += new System.EventHandler(this.emailsubject_TextChanged);
         // 
         // pathofemailtemplate
         // 
         this.pathofemailtemplate.Location = new System.Drawing.Point(163, 151);
         this.pathofemailtemplate.Name = "pathofemailtemplate";
         this.pathofemailtemplate.Size = new System.Drawing.Size(394, 22);
         this.pathofemailtemplate.TabIndex = 6;
         this.pathofemailtemplate.TextChanged += new System.EventHandler(this.pathofemailtemplate_TextChanged);
         // 
         // Path_Of_PDF_Folder_screen3
         // 
         this.Path_Of_PDF_Folder_screen3.Location = new System.Drawing.Point(163, 107);
         this.Path_Of_PDF_Folder_screen3.Name = "Path_Of_PDF_Folder_screen3";
         this.Path_Of_PDF_Folder_screen3.Size = new System.Drawing.Size(394, 22);
         this.Path_Of_PDF_Folder_screen3.TabIndex = 5;
         this.Path_Of_PDF_Folder_screen3.TextChanged += new System.EventHandler(this.Path_Of_PDF_Folder_screen3_TextChanged);
         // 
         // Path_of_Excel_File_screen3
         // 
         this.Path_of_Excel_File_screen3.Location = new System.Drawing.Point(163, 61);
         this.Path_of_Excel_File_screen3.Name = "Path_of_Excel_File_screen3";
         this.Path_of_Excel_File_screen3.Size = new System.Drawing.Size(396, 22);
         this.Path_of_Excel_File_screen3.TabIndex = 4;
         this.Path_of_Excel_File_screen3.TextChanged += new System.EventHandler(this.Path_of_Excel_File_screen3_TextChanged);
         this.Path_of_Excel_File_screen3.LostFocus += new System.EventHandler(this.Path_of_Excel_File_screen3_Leave_Or_LostFocus);
         this.Path_of_Excel_File_screen3.Leave += new System.EventHandler(this.Path_of_Excel_File_screen3_Leave_Or_LostFocus);
         // 
         // lable4
         // 
         this.lable4.AutoSize = true;
         this.lable4.Location = new System.Drawing.Point(15, 212);
         this.lable4.Name = "lable4";
         this.lable4.Size = new System.Drawing.Size(73, 16);
         this.lable4.TabIndex = 3;
         this.lable4.Text = "Email Subject:";
         // 
         // lable3
         // 
         this.lable3.AutoSize = true;
         this.lable3.Location = new System.Drawing.Point(12, 157);
         this.lable3.Name = "lable3";
         this.lable3.Size = new System.Drawing.Size(147, 16);
         this.lable3.TabIndex = 2;
         this.lable3.Text = "Path Of Email Body Template:";
         // 
         // label_Path_Of_PDF_Folder
         // 
         this.label_Path_Of_PDF_Folder.AutoSize = true;
         this.label_Path_Of_PDF_Folder.Location = new System.Drawing.Point(12, 108);
         this.label_Path_Of_PDF_Folder.Name = "label_Path_Of_PDF_Folder";
         this.label_Path_Of_PDF_Folder.Size = new System.Drawing.Size(104, 16);
         this.label_Path_Of_PDF_Folder.TabIndex = 1;
         this.label_Path_Of_PDF_Folder.Text = "Path Of PDF Folder:";
         // 
         // label_Path_Of_Excel_File
         // 
         this.label_Path_Of_Excel_File.AutoSize = true;
         this.label_Path_Of_Excel_File.Location = new System.Drawing.Point(12, 69);
         this.label_Path_Of_Excel_File.Name = "label_Path_Of_Excel_File";
         this.label_Path_Of_Excel_File.Size = new System.Drawing.Size(94, 16);
         this.label_Path_Of_Excel_File.TabIndex = 0;
         this.label_Path_Of_Excel_File.Text = "Path Of Excel File:";
         // 
         // next1
         // 
         this.next1.Enabled = false;
         this.next1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.next1.Location = new System.Drawing.Point(535, 631);
         this.next1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.next1.Name = "next1";
         this.next1.Size = new System.Drawing.Size(112, 44);
         this.next1.TabIndex = 7;
         this.next1.Text = "Next";
         this.next1.UseVisualStyleBackColor = true;
         this.next1.Click += new System.EventHandler(this.next1_Click_1);
         // 
         // Configuration
         // 
         this.Configuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Configuration.Location = new System.Drawing.Point(51, 326);
         this.Configuration.Name = "Configuration";
         this.Configuration.Size = new System.Drawing.Size(125, 42);
         this.Configuration.TabIndex = 8;
         this.Configuration.Text = "Configuration";
         this.Configuration.UseVisualStyleBackColor = true;
         this.Configuration.Click += new System.EventHandler(this.Configuration_Click);
         // 
         // folderBrowserDialog1
         // 
         this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(665, 704);
         this.Controls.Add(this.Mail_Automation_panel);
         this.Controls.Add(this.PDF_Generator_Panel);
         this.Controls.Add(this.Send_Mail_by_PDF_Attached);
         this.Controls.Add(this.Generate_PDF_and_Mail);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.Configuration);
         this.Controls.Add(this.next1);
         this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.Name = "Form1";
         this.Text = "HR Automation.";
         ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
         this.PDF_Generator_Panel.ResumeLayout(false);
         this.PDF_Generator_Panel.PerformLayout();
         this.Mail_Automation_panel.ResumeLayout(false);
         this.Mail_Automation_panel.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.RadioButton Generate_PDF_and_Mail;
      private System.Windows.Forms.RadioButton Send_Mail_by_PDF_Attached;
      private System.IO.FileSystemWatcher fileSystemWatcher1;
      private System.Windows.Forms.Panel PDF_Generator_Panel;
      private System.Windows.Forms.TextBox path_of_excel_file;
      private System.Windows.Forms.TextBox text_append_to_filename;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.TextBox path_of_word_folder;
      private System.Windows.Forms.TextBox path_of_pdf_folder;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.TextBox path_of_word_file;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Button wordFolder;
      private System.Windows.Forms.Button pdfFolder;
      private System.Windows.Forms.Button wordFile;
      private System.Windows.Forms.Button excelFile;
      private System.Windows.Forms.Button Previous2;
      private System.Windows.Forms.Button Next2;
      private System.Windows.Forms.Button next1;
      private System.Windows.Forms.Label count;
      private System.Windows.Forms.Button generate_pdf;
      private System.Windows.Forms.ProgressBar progressBar_no_of_pdfs_generated;
      private System.Windows.Forms.Panel Mail_Automation_panel;
      private System.Windows.Forms.Button Previous3;
      private System.Windows.Forms.Label error_screen3;
      private System.Windows.Forms.Label emailsentcounter;
      private System.Windows.Forms.ProgressBar EmailSent_progressBar;
      private System.Windows.Forms.Button generate_emails;
      private System.Windows.Forms.Button emailtemplatebrowse;
      private System.Windows.Forms.Button pdfFolder_screen3;
      private System.Windows.Forms.Button excelFile_screen3;
      private System.Windows.Forms.TextBox emailsubject;
      private System.Windows.Forms.TextBox pathofemailtemplate;
      private System.Windows.Forms.TextBox Path_Of_PDF_Folder_screen3;
      private System.Windows.Forms.TextBox Path_of_Excel_File_screen3;
      private System.Windows.Forms.Label lable4;
      private System.Windows.Forms.Label lable3;
      private System.Windows.Forms.Label label_Path_Of_PDF_Folder;
      private System.Windows.Forms.Label label_Path_Of_Excel_File;
      private System.Windows.Forms.Button Configuration;
      private System.Windows.Forms.Label error_screen2;
      private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
   }
}

