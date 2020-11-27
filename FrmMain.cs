using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Reflection;
using System.IO;
using System.Xml;
using System.Xml.Schema;


namespace SimpleXMLValidator2
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmMain : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem MIFile;
		private System.Windows.Forms.MenuItem MIBlank;
		private System.Windows.Forms.MenuItem MIExit;
		private System.Windows.Forms.MenuItem MIAbout;
		private System.Windows.Forms.OpenFileDialog oFDialog;
		internal System.Windows.Forms.Button btnXSD;
		internal System.Windows.Forms.Button btnValidate;
		internal System.Windows.Forms.Button btnOpen;
		internal System.Windows.Forms.TextBox txtFileXml;
		internal System.Windows.Forms.Label lbValidate;
		internal System.Windows.Forms.RichTextBox Rtboxlog;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.MIFile = new System.Windows.Forms.MenuItem();
			this.MIBlank = new System.Windows.Forms.MenuItem();
			this.MIExit = new System.Windows.Forms.MenuItem();
			this.MIAbout = new System.Windows.Forms.MenuItem();
			this.oFDialog = new System.Windows.Forms.OpenFileDialog();
			this.btnXSD = new System.Windows.Forms.Button();
			this.btnValidate = new System.Windows.Forms.Button();
			this.btnOpen = new System.Windows.Forms.Button();
			this.txtFileXml = new System.Windows.Forms.TextBox();
			this.lbValidate = new System.Windows.Forms.Label();
			this.Rtboxlog = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.MIFile,
																					  this.MIAbout});
			// 
			// MIFile
			// 
			this.MIFile.Index = 0;
			this.MIFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				   this.MIBlank,
																				   this.MIExit});
			this.MIFile.Text = "&File";
			// 
			// MIBlank
			// 
			this.MIBlank.Index = 0;
			this.MIBlank.Text = "-";
			// 
			// MIExit
			// 
			this.MIExit.Index = 1;
			this.MIExit.Text = "E&xit";
			this.MIExit.Click += new System.EventHandler(this.MIExit_Click);
			// 
			// MIAbout
			// 
			this.MIAbout.Index = 1;
			this.MIAbout.Text = "&About";
			this.MIAbout.Click += new System.EventHandler(this.MIAbout_Click);
			// 
			// oFDialog
			// 
			this.oFDialog.Filter = "XML files|*.XML|XSD files|*.XSD|All files|*.*";
			// 
			// btnXSD
			// 
			this.btnXSD.Enabled = false;
			this.btnXSD.Location = new System.Drawing.Point(564, 16);
			this.btnXSD.Name = "btnXSD";
			this.btnXSD.Size = new System.Drawing.Size(80, 23);
			this.btnXSD.TabIndex = 14;
			this.btnXSD.Text = "Validate XSD";
			this.btnXSD.Click += new System.EventHandler(this.btnXSD_Click);
			// 
			// btnValidate
			// 
			this.btnValidate.Enabled = false;
			this.btnValidate.Location = new System.Drawing.Point(464, 16);
			this.btnValidate.Name = "btnValidate";
			this.btnValidate.Size = new System.Drawing.Size(80, 23);
			this.btnValidate.TabIndex = 13;
			this.btnValidate.Text = "Validate XML";
			this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(356, 16);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.TabIndex = 12;
			this.btnOpen.Text = "Open";
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// txtFileXml
			// 
			this.txtFileXml.Location = new System.Drawing.Point(124, 16);
			this.txtFileXml.Name = "txtFileXml";
			this.txtFileXml.Size = new System.Drawing.Size(224, 20);
			this.txtFileXml.TabIndex = 11;
			this.txtFileXml.Text = "";
			this.txtFileXml.TextChanged += new System.EventHandler(this.txtFileXml_TextChanged);
			// 
			// lbValidate
			// 
			this.lbValidate.AutoSize = true;
			this.lbValidate.Location = new System.Drawing.Point(12, 20);
			this.lbValidate.Name = "lbValidate";
			this.lbValidate.Size = new System.Drawing.Size(109, 16);
			this.lbValidate.TabIndex = 10;
			this.lbValidate.Text = "XML File to Validate:";
			// 
			// Rtboxlog
			// 
			this.Rtboxlog.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Rtboxlog.Location = new System.Drawing.Point(0, 61);
			this.Rtboxlog.Name = "Rtboxlog";
			this.Rtboxlog.Size = new System.Drawing.Size(652, 232);
			this.Rtboxlog.TabIndex = 9;
			this.Rtboxlog.Text = "";
			// 
			// frmMain
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(652, 293);
			this.Controls.Add(this.btnXSD);
			this.Controls.Add(this.btnValidate);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.txtFileXml);
			this.Controls.Add(this.lbValidate);
			this.Controls.Add(this.Rtboxlog);
			this.Menu = this.mainMenu1;
			this.Name = "frmMain";
			this.Text = "Simple XML Validator C#";
			this.ResumeLayout(false);

		}
		#endregion
		
		private bool m_Success = false;
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmMain());
		}

		private void MIExit_Click(object sender, System.EventArgs e)
		{
			this.Close() ;
		}

		private void MIAbout_Click(object sender, System.EventArgs e)
		{
		//Get the assemblyname object based off the name of this application
        //NOTE the version is pulled from the assemblyinfo.vb file
        AssemblyName tmpName = AssemblyName.GetAssemblyName(Application.ExecutablePath);
        //Show the assemblyVersion
        MessageBox.Show("Simple XML Validator C#" +  (Char)(13)+(Char)(10)+ "By: Ben Kubicek" + (Char)(13)+(Char)(10) + "ben.kubicek@hotmail.com" + (Char)(13)+(Char)(10) + "Version: " + tmpName.Version.ToString(), "Version", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnOpen_Click(object sender, System.EventArgs e)
		{
			//Click the open dialog button
			if (oFDialog.ShowDialog() == DialogResult.OK )
			{
				//They selected a file so put it in the text box
				txtFileXml.Text = oFDialog.FileName;
			}
        
		}

		private void writertbox(String instr)
		{
		//this will always append the log info with the time and date stamp
			Rtboxlog.AppendText(DateTime.Now.ToString("hh:mm:ss yyyy/MM/dd") + " " + instr + (Char)(13)+(Char)(10));
		}
		private void EnableDisable(bool SetEnabled)
		{
		
		//A little sub to help enable and disable form controls when validating
		if (SetEnabled) {
			btnOpen.Enabled = true;
			//looking for the correct extension to enable correct button
			btnValidate.Enabled = (txtFileXml.Text.ToUpper().IndexOf(".XML") >= 0);
			btnXSD.Enabled = (txtFileXml.Text.ToUpper().IndexOf(".XSD") >= 0);
			}
		else
		{
			btnOpen.Enabled = false;
			btnValidate.Enabled = false;
			btnXSD.Enabled = false;
		}

		}
		private bool validateXml(String infile)
		{
		//First we create the xmltextreader
		XmlTextReader xmlr = new XmlTextReader(infile);
		//We pass the xmltextreader into the xmlvalidatingreader
		//'This will validate the xml doc with the schema file
		//'NOTE the xml file it self points to the schema file
		XmlValidatingReader xmlvread = new XmlValidatingReader(xmlr);
//
//		//						' Set the validation event handler
		xmlvread.ValidationEventHandler += new ValidationEventHandler (ValidationCallBack);
		m_Success = true; //'make sure to reset the success var
//
//		//' Read XML data
		while (xmlvread.Read()){}

		//'Close the reader.
		xmlvread.Close();

		//'The validationeventhandler is the only thing that would set m_Success to false
		return m_Success;

		}
		private void ValidationCallBack(Object sender, ValidationEventArgs args)
		{
		//'Display the validation error.  This is only called on error
		m_Success = false; //'Validation failed
		writertbox("Validation error: " + args.Message);
		}
		private void btnValidate_Click(object sender, System.EventArgs e)
		{
			//The clicked the validate xml button
			if  (!File.Exists(txtFileXml.Text))
				{
				//File doesn't existing, must have miss typed it.
				MessageBox.Show("You need to put a valid file name in the text box.");
				txtFileXml.Focus();
				return;
				}
        
			try
			{
				            writertbox("");
				            writertbox("-------------------------");
				            writertbox("");
				
				            writertbox("Validating XML against schema (XSD) starting...");
				            writertbox("on " + txtFileXml.Text);
				            EnableDisable(false);
				            //Try to validate the xml file
				if (validateXml(txtFileXml.Text))
				{
					writertbox("XML File has successfully been validated against the schema");
				}
				else
				{
					writertbox("XML File failed validation against the schema." + (Char)(13)+(Char)(10) + "NOTE the xml file needs to point to the schema file (xsd)." + (Char)(13)+(Char)(10) + "The xsd file must be in the same dir as the xml file.");
				}
			}
			finally
			{
				            EnableDisable(true);
			}

		}

		private void txtFileXml_TextChanged(object sender, System.EventArgs e)
		{
			//'looking for the correct extension to enable correct button
			btnValidate.Enabled = txtFileXml.Text.ToUpper().IndexOf(".XML") >= 0;
			btnXSD.Enabled = txtFileXml.Text.ToUpper().IndexOf(".XSD") >= 0;
		}

		private bool validateSchema(String infilename)
		{
			//this function will validate the schema file (xsd)
			
			XmlSchema myschema; 
			m_Success = true; //'make sure to reset the success var
			StreamReader sr = new StreamReader(infilename);
			try
			{
				//sr = new StreamReader(infilename);
				myschema = XmlSchema.Read(sr, new ValidationEventHandler (ValidationCallBack));
				//'This compile statement is what ususally catches the errors
				myschema.Compile(new ValidationEventHandler (ValidationCallBack));
			}																														
			finally
			{
				sr.Close();
			}
			return m_Success;
		}
		private void btnXSD_Click(object sender, System.EventArgs e)
		{
		//Validate schema file click
        if (!File.Exists(txtFileXml.Text)){
            //'File doesn't exist must have mis-typed it.
            MessageBox.Show("The file is not found.");
            txtFileXml.Focus();
				return;
				}

			try
			{
				writertbox("");
					writertbox("-------------------------");
						writertbox("");

							writertbox("Schema File Validating Starting...");
								writertbox("on " + txtFileXml.Text);
									EnableDisable(false);
										//'Try to validate the schema file
				if (validateSchema(txtFileXml.Text) )
				{
					writertbox("XSD Schema File has successfully been validated.");
				}
				else
				{
					writertbox("XSD Schema File has Failed validation.");
				}

				
				}
			finally{
				EnableDisable(true);
			}
		}
	}
}
